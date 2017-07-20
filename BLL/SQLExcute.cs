using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccess;
using System.Data;
using UserInfo;
using CardInfo;

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

        public DataTable IdentifyCard(string strCardNumber)
        {
            string strSQL = $"select CardPWD from CardInfo " +
                $"where CardNumber='{strCardNumber}'";

            return access.SQLServer(strSQL, "卡片密码表").Tables[0];
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
            string strSQL = $"select a.UserName,b.UserLevel,a.Enable,a.CreatTime,a.UpdateTime " +
                                $"from tb_Users as a " +
                                $"left join Level as b " +
                                $"on a.Level = b.Level " +
                                $"where UserName " +
                                $"like '%{strUserName}%'";

            return access.SQLServer(strSQL, "单一用户信息表");
        }

        /// <summary>
        /// 获取所有的存储卡信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllCardInfo()
        {
            string strSQL = $"select * " +
                $"from CardInfo as a";

            return access.SQLServer(strSQL, "所有卡片信息表").Tables[0];
        }

        /// <summary>
        /// 获取单一卡号的存储卡信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetCardInfoByNumber(string strCardNumber)
        {
            string strSQL = $"select * " +
                $"from CardInfo " +
                $"where CardNumber='{strCardNumber}'";

            return access.SQLServer(strSQL, "单一卡片信息表").Tables[0];
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
        /// 判断存储号是否存在
        /// </summary>
        /// <param name="strCardNumber">卡片号</param>
        /// <returns>是否存在</returns>
        public bool ConfirmTheOnlyCardNumber(string strCardNumber)
        {
            string strSQL = $"select CardNumber from CardInfo " +
                $"where CardNumber='{strCardNumber}'";

            return access.SQLServer(strSQL, "验证存储卡号是否唯一表").Tables[0].DefaultView.Count == 1;
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

        /// <summary>
        /// 删除存储卡信息
        /// </summary>
        /// <param name="strCardNumber">卡号</param>
        /// <returns>是否成功删除</returns>
        public bool DeleteCardInfo(string strCardNumber)
        {
            string strSQL = $"delete from CardInfo " +
                $"where CardNumber='{strCardNumber}'";

            return access.SQLServer(strSQL) == 1;
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user">用户类</param>
        /// <returns>是否更新成功</returns>
        public bool UpdateUserInfo(User user)
        {
            string strSQL = $"update tb_Users set Level={user.Level}," +
                $"Enable='{user.Enable}'," +
                $"UpdateTime=(getdate())" +
                $"where UserName='{user.Name}'";

            return access.SQLServer(strSQL) > 0;
        }

        /// <summary>
        /// 更新余额信息
        /// </summary>
        /// <param name="dbBalance">修改后的余额</param>
        /// <returns>是否更新了</returns>
        public bool UpdateBalance(double dbBalance, string strCardNumber)
        {
            string strSQL = $"update CardInfo set " +
                $"Balance={dbBalance} " +
                $"where CardNumber='{strCardNumber}'";

            return access.SQLServer(strSQL) == 1;
        }

        /// <summary>
        /// 获取余额
        /// </summary>
        /// <param name="strCardNumber">卡号</param>
        /// <returns>余额</returns>
        public string GetBalanceByCardNumber(string strCardNumber)
        {
            string strSQL = $"select Balance " +
                $"from CardInfo " +
                $"where CardNumber='{strCardNumber}'";

            return Convert.ToString(access.SQLServer(strSQL, "余额表").Tables[0].Rows[0][0]);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="PWD">新密码</param>
        /// <param name="strUserName">用户名</param>
        /// <returns>是否修改成功</returns>
        public bool ModifyPWD(string PWD, string strUserName)
        {
            string strSQL = $"update tb_Users " +
                $"set PWD='{PWD}' " +
                $"where UserName='{strUserName}'";

            return access.SQLServer(strSQL) == 1;
        }

        /// <summary>
        /// 修改存储卡密码
        /// </summary>
        /// <param name="PWD">新的密码</param>
        /// <param name="strCardNumber">卡号</param>
        /// <returns>是否更新成功</returns>
        public bool ModifyCardPWD(string PWD,string strCardNumber)
        {
            string strSQL = $"update CardInfo " +
                $"set CardPWD='{PWD}' " +
                $"where CardNumber='{strCardNumber}'";

            return access.SQLServer(strSQL) == 1;
        }

        /// <summary>
        /// 从数据库获取银行名称
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable GetBankName()
        {
            string strSQL = $"select * from BankName";

            return access.SQLServer(strSQL, "银行名称表").Tables["银行名称表"];
        }

        /// <summary>
        /// 从数据库获取持卡人信息
        /// </summary>
        /// <param name="strCardNumber">卡号</param>
        /// <returns>持卡人信息</returns>
        public string GetWhoHoldCard(string strCardNumber)
        {
            string strSQL = $"select WhoHoldCard " +
                $"from CardInfo " +
                $"where CardNumber='{strCardNumber}'";

            return Convert.ToString(access.SQLServer(strSQL, "持卡人表").Tables[0].Rows[0][0]);
        }

        /// <summary>
        /// 更新持卡人信息
        /// </summary>
        /// <param name="strCardNumber">卡号</param>
        /// <param name="strWhoHoldCardNow">新持卡人</param>
        /// <returns>是否修改成功</returns>
        public bool UpdateWhoHoldCard(string strCardNumber, string strWhoHoldCardNow)
        {
            string strSQL = $"update CardInfo " +
                $"set WhoHoldCard='{strWhoHoldCardNow}' " +
                $"where CardNumber='{strCardNumber}'";

            return access.SQLServer(strSQL) == 1;
        }

        /// <summary>
        /// 添加存储卡信息
        /// </summary>
        /// <param name="card">存储卡类</param>
        /// <returns>是否添加成功</returns>
        public bool InsertCardInfo(Card card)
        {
            string strSQL = $"insert into CardInfo" +
                $"(WhoCreatCard,WhoHoldCard,CardNumber,CardPWD,BankName,Balance) " +
                $"values('{card.WhoCreatCard}'," +
                $"'{card.WhoHoldCard}'," +
                $"'{card.CardName}'," +
                $"'{card.CardPWD}'," +
                $"'{card.BankName}'," +
                $"{card.Balance})";

            return access.SQLServer(strSQL) == 1;
        }

    }
}
