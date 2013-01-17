using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using THOK.ParamUtil;

namespace THOK.AS.Boxing
{
    public class Parameter :BaseObject
    {
        private string serverName;

        [CategoryAttribute("服务器数据库连接参数"), DescriptionAttribute("数据库服务器名称"), Chinese("服务器名称")]
        public string ServerName
        {
            get { return serverName;}
            set { serverName = value; }
        }
        private string dbName;
        [CategoryAttribute("服务器数据库连接参数"), DescriptionAttribute("数据库名称"), Chinese("数据库名")]
        public string DbName
        {
            get { return dbName; }
            set { dbName = value; }
        }
        private string dbUser;
        [CategoryAttribute("服务器数据库连接参数"), DescriptionAttribute("数据库连接用户名"), Chinese("用户名")]

        public string DbUser
        {
            get { return dbUser; }
            set { dbUser = value; }
        }
        private string password;
        [CategoryAttribute("服务器数据库连接参数"), DescriptionAttribute("数据库连接密码"), Chinese("密码")]

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string boxServerName;
        [CategoryAttribute("整件监控数据库连接参数"), DescriptionAttribute("数据库服务器名称"), Chinese("服务器名称")]
        public string BoxServerName
        {
            get
            {
                return boxServerName;
            }
            set
            {
                boxServerName = value;
            }
        }
        private string boxDbName;
        [CategoryAttribute("整件监控数据库连接参数"), DescriptionAttribute("数据库名称"), Chinese("数据库名称")]
        public string BoxDbName
        {
            get
            {
                return boxDbName;
            }
            set
            {
                boxDbName = value;
            }
        }
        private string boxDbUser;
        [CategoryAttribute("整件监控数据库连接参数"), DescriptionAttribute("数据库连接用户名"), Chinese("用户名")]
        public string BoxDbUser
        {
            get
            {
                return boxDbUser;
            }
            set
            {
                boxDbUser = value;
            }
        }
        private string boxPassword;
        [CategoryAttribute("整件监控数据库连接参数"), DescriptionAttribute("数据库连接密码"), Chinese("密码")]
        public string BoxPassword
        {
            get 
            {
                return boxPassword;
            }
            set
            {
                boxPassword = value;
            }
        } 
    }
}
