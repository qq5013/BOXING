using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using THOK.Util;
using THOK.AF.View;

namespace THOK.AS.Boxing.View
{
    public partial class ParameterForm :THOK.AF.View.ToolbarForm
    {
        private Parameter parameter = new Parameter();
        private DBConfigUtil serverConfig = new DBConfigUtil("ServerConnection", "SQLSERVER");
        private DBConfigUtil boxConfig = new DBConfigUtil("DefaultConnection", "SQLSERVER");

        public ParameterForm()
        {
            InitializeComponent();
            ReadParameter();
        }
        private void ReadParameter()
        {
            parameter.ServerName = serverConfig.Parameters["server"].ToString();
            parameter.DbName = serverConfig.Parameters["database"].ToString();
            parameter.DbUser = serverConfig.Parameters["uid"].ToString();
            parameter.Password = serverConfig.Parameters["password"].ToString();

            parameter.BoxServerName = boxConfig.Parameters["server"].ToString();
            parameter.BoxDbName = boxConfig.Parameters["database"].ToString();
            parameter.BoxDbUser = boxConfig.Parameters["uid"].ToString();
            parameter.BoxPassword = boxConfig.Parameters["password"].ToString();

            this.propertyGrid.SelectedObject = parameter;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            serverConfig.Parameters["server"] = parameter.ServerName;
            serverConfig.Parameters["database"] = parameter.DbName;
            serverConfig.Parameters["uid"] = parameter.DbUser;
            serverConfig.Parameters["password"] = serverConfig.Parameters["password"].ToString() == parameter.Password ? serverConfig.Parameters["password"] : THOK.Util.Coding.Encoding(parameter.Password);
            serverConfig.Save();

            boxConfig.Parameters["server"] = parameter.BoxServerName;
            boxConfig.Parameters["database"] = parameter.BoxDbName;
            boxConfig.Parameters["uid"] = parameter.BoxDbUser;
            boxConfig.Parameters["password"] = boxConfig.Parameters["password"].ToString() == parameter.BoxPassword ? boxConfig.Parameters["password"] : THOK.Util.Coding.Encoding(parameter.BoxPassword);
            boxConfig.Save();

            MessageBox.Show("保存成功，请重新启动系统!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}