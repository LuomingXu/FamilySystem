using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccess;
using System.Data;
using UserInfo;

namespace BLL
{
    public class SQLExcute
    {
        /// <summary>
        /// 全局的数据库连接的Access
        /// </summary>
        Access access = new Access();

        /// <summary>
        /// 全局的DataSet, 暂且在需要调试的时候使用
        /// </summary>
        DataSet ds = new DataSet();

        /// <summary>
        /// 从数据库中获取密码
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strPWD"></param>
        /// <returns>DataSet</returns>
        public DataSet IdentifyUser(string strUserName)
        {
            string strSQL = $"select PWD from tb_Users where UserName='{strUserName}'";

            return access.SQLServer(strSQL, "密码表");
        }

        /// <summary>
        /// 向数据库中插入数据, 返回影响的行数
        /// </summary>
        /// <param name="User">用户的信息</param>
        /// <returns>影响的行数</returns>
        public int InsertUserInfo(User User)
        {
            string strSQL = $"insert into tb_Users(UserName,PWD,Level,Enable) " +
                $"values('{User.Name}','{User.PWD}',{User.Level},'是')";

            return access.SQLServer(strSQL);
        }

        /// <summary>
        /// 获取所有用户的信息
        /// </summary>
        /// <param name="strUserName">用户名</param>
        /// <returns>DataSet</returns>
        public DataSet GetAllUserInfo()
        {
            string strSQL = $"select a.UserName,b.UserLevel,a.Enable,a.CreatTime,a.UpdateTime " +
                                $"from tb_Users as a " +
                                $"left join Level as b " +
                                $"on a.Level = b.Level";

            return access.SQLServer(strSQL, "用户信息表");
        }

        /// <summary>
        /// 根据所给定的用户名来获取用户数据
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public DataSet GetUserInfoByUserName(string strUserName)
        {
            string strSQL = $"select a.UserName,b.UserLevel,a.Enable,a.CreatTime " +
                                $"from tb_Users as a " +
                                $"left join Level as b " +
                                $"on a.Level = b.Level " +
                                $"where UserName='{strUserName}'";

            return access.SQLServer(strSQL, "单一用户信息表");
        }

        /// <summary>
        /// 判断用户名是否唯一存在, 返回此用户名的个数
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public Int32 ConfirmTheOnlyUserName(string strUserName)
        {
            string strSQL = $"select Level from tb_Users " +
                $"where UserName='{strUserName}'";

            return access.SQLServer(strSQL, "验证用户名是否唯一表").Tables["验证用户名是否唯一表"].DefaultView.Count;
        }

        /// <summary>
        /// 判断此用户是否为管理员
        /// </summary>
        /// <param name="strUserName">用户名</param>
        /// <returns>true:管理员\nfalse:普通用户</returns>
        public bool IsAdm(string strUserName)
        {
            string strSQL = $"select b.UserLevel " +
                $"from tb_Users as a " +
                $"left join Level as b " +
                $"on b.Level = a.Level " +
                $"where a.UserName='{strUserName}'";

            ds = access.SQLServer(strSQL, "用户等级表");

            string strLevel = Convert.ToString(ds.Tables["用户等级表"].Rows[0][0]);

            if (strLevel.Equals("管理员"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除指定用户名的信息
        /// </summary>
        /// <param name="strUserName">用户名</param>
        /// <returns>是否删除成功</returns>
        public bool DeleteUserInfo(string strUserName)
        {
            string strSQL = $"delete from tb_Users " +
                $"where UserName='{strUserName}'";

            return access.SQLServer(strSQL) > 0;
        }

        public bool UpdateUserInfo(User user)
        {
            string strSQL = $"update tb_Users set Level={user.Level}," +
                $"Enable='{user.Enable}'," +
                $"UpdateTime=(getdate())" +
                $"where UserName='{user.Name}'";

            return access.SQLServer(strSQL) > 0;
        }

        public bool ModifyPWD(string PWD, string strUserName)
        {
            string strSQL = $"update tb_Users " +
                $"set PWD='{PWD}' " +
                $"where UserName='{strUserName}'";

            return access.SQLServer(strSQL) == 1;
        }
    }
}
