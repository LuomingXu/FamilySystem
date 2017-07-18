using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo
{
    public class User
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PWD { set; get; }

        /// <summary>
        /// 账户等级
        /// </summary>
        public int Level { set; get; }

        /// <summary>
        /// 用户是否可用
        /// </summary>
        public string Enable { get; set; }
    }
}
