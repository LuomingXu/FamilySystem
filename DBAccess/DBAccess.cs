using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace DBAccess
{
    public class Access
    {
        private StackTrace st = new StackTrace();

        ///// <summary>
        ///// 从DB.config里面读取, 链接字符串
        ///// </summary>
        //private string strConnString = ConfigurationManager.ConnectionStrings["strConnStrings"].ConnectionString;

        /// <summary>
        /// 连接字符串
        /// </summary>
        private string strConnectionString = "Data Source=徐络溟\\SQLEXPRESS;Initial Catalog=FamilySystemTest;Integrated Security=True";

        /// <summary>
        /// 从SQLserver里面获取DataSet, 
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="strDsName">返回的DataSet的名字</param>
        /// <returns>DataSet</returns>
        public DataSet SQLServer(string strSQL, string strDsName)
        {
            SqlConnection conn = new SqlConnection()
            {
                ConnectionString = strConnectionString,
            };

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = strSQL,
                };

                SqlDataAdapter da = new SqlDataAdapter()
                {
                    SelectCommand = cmd,
                };

                DataSet ds = new DataSet();

                da.Fill(ds, strDsName);

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show(st.GetFrame(0).GetMethod().ToString() + e.Message, 
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DataSet ds = new DataSet();

                return ds;
            }
            finally
            {
                conn.Close(); 
            }     
        }

        /// <summary>
        /// 执行SQL语句, 返回影响行数
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <returns>影响行数</returns>
        public int SQLServer (string strSQL)
        {
            SqlConnection conn = new SqlConnection()
            {
                ConnectionString = strConnectionString,
            };

            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = strSQL,
                };

                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(st.GetFrame(0).GetMethod().ToString() + e.Message,
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
