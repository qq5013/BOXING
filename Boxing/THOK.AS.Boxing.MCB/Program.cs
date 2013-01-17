using System;
using System.Collections.Generic;
using System.Windows.Forms;
using THOK.MCP;
using THOK.MCP.View;
using System.Drawing;

namespace THOK.AS.Boxing
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            THOK.AF.Config config = new THOK.AF.Config();
            THOK.AF.MainFrame mainFrame = new THOK.AF.MainFrame(config);
            mainFrame.Text = "天海欧康整件打票系统";
            mainFrame.Icon = new Icon(@"./App.ico");
            mainFrame.WindowState = FormWindowState.Maximized;   
            Application.Run(mainFrame);
        }
    }
}