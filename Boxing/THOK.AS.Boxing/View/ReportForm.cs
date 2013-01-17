using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using THOK.MCP;
using THOK.Util;
using THOK.AS.Boxing.Dao;
using THOK.AS.Boxing.Report;

namespace THOK.AS.Boxing.View
{
    public partial class ReportForm : THOK.AF.View.ToolbarForm
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.Refresh();
                BoxDao boxDao =new BoxDao();
                using (PersistentManager pm = new PersistentManager())
                {
                    PrintCrystalReport pr = new PrintCrystalReport();
                    pr.SetDataSource(boxDao.FindAllOrder());
                    crystalReportViewer1.ReportSource = pr;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }
    }
}