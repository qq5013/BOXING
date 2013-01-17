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

        [CategoryAttribute("���������ݿ����Ӳ���"), DescriptionAttribute("���ݿ����������"), Chinese("����������")]
        public string ServerName
        {
            get { return serverName;}
            set { serverName = value; }
        }
        private string dbName;
        [CategoryAttribute("���������ݿ����Ӳ���"), DescriptionAttribute("���ݿ�����"), Chinese("���ݿ���")]
        public string DbName
        {
            get { return dbName; }
            set { dbName = value; }
        }
        private string dbUser;
        [CategoryAttribute("���������ݿ����Ӳ���"), DescriptionAttribute("���ݿ������û���"), Chinese("�û���")]

        public string DbUser
        {
            get { return dbUser; }
            set { dbUser = value; }
        }
        private string password;
        [CategoryAttribute("���������ݿ����Ӳ���"), DescriptionAttribute("���ݿ���������"), Chinese("����")]

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string boxServerName;
        [CategoryAttribute("����������ݿ����Ӳ���"), DescriptionAttribute("���ݿ����������"), Chinese("����������")]
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
        [CategoryAttribute("����������ݿ����Ӳ���"), DescriptionAttribute("���ݿ�����"), Chinese("���ݿ�����")]
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
        [CategoryAttribute("����������ݿ����Ӳ���"), DescriptionAttribute("���ݿ������û���"), Chinese("�û���")]
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
        [CategoryAttribute("����������ݿ����Ӳ���"), DescriptionAttribute("���ݿ���������"), Chinese("����")]
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
