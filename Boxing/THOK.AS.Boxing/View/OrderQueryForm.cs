using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using THOK.AS.Boxing.Dal;
using THOK.AS.Boxing.Dao;
using THOK.MCP;
using THOK.MCP.View;
using THOK.Util;

namespace THOK.AS.Boxing.View
{
    public partial class OrderQueryForm : THOK.AF.View.ToolbarForm
    {
        private BoxDal boxDal =new BoxDal();

        public OrderQueryForm()
        {
            InitializeComponent();
            this.Column2.FilteringEnabled = true;
            this.Column5.FilteringEnabled = true;
            this.Column6.FilteringEnabled = true;
            this.Column7.FilteringEnabled = true;
            this.Column8.FilteringEnabled = true;
            this.Column9.FilteringEnabled = true;
            this.Column10.FilteringEnabled = true;
            this.PACKQUANTITY1.FilteringEnabled = true;
            this.STATUS1.FilteringEnabled = true;
            btnRefresh_Click(null,null);
            lblTotalQty.Text = dgvMaster.Rows.Count.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (bsMaster.DataSource == null)
            {
                bsMaster.DataSource = boxDal.GetOrderMaster();
            }
            else
            {
                DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dgvMaster);
            }
        }

        private void dgvMaster_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetail.DataSource = boxDal.GetOrderDetail(dgvMaster.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (PersistentManager pm = new PersistentManager())
                {
                    BoxDao boxDao = new BoxDao();
                    using (PersistentManager pmServer = new PersistentManager("ServerConnection"))
                    {
                        ServerDao serverDao = new ServerDao();
                        serverDao.SetPersistentManager(pmServer);

                        string lineCode = "03";
                        string orderDate = "";
                        string batchNo = "";

                        DataTable printBatchTable = serverDao.FindAllUpLoadBatch();

                        BatchSelectDialog batchSelectDialog = new BatchSelectDialog(printBatchTable);


                        if (batchSelectDialog.ShowDialog() == DialogResult.OK)
                        {
                            orderDate = batchSelectDialog.SelectedBoxBatch.Split("|"[0])[0];
                            batchNo = batchSelectDialog.SelectedBoxBatch.Split("|"[0])[1];

                            DataTable batchTable = serverDao.FindOrderMaster(orderDate, batchNo, lineCode);

                            if (batchTable.Rows.Count == 0)
                                throw new Exception("没有数据");

                            DataTable table = serverDao.FindBatch(lineCode);

                            //2011-9-5修改从服务器下载件烟数据
                            #region/从服务器下载件烟数据/
                            //下载件烟订单主表
                            table = serverDao.FindOrderMaster(orderDate, batchNo, lineCode);
                            boxDao.InsertMaster(table);
                            System.Threading.Thread.Sleep(100);

                            //下载件烟订单明细表
                            table = serverDao.FindOrder(orderDate, batchNo, lineCode);
                            boxDao.InsertOrder(table);
                            #endregion
                            bsMaster.DataSource = boxDal.GetOrderMaster();
                            MessageBox.Show("数据下载完成");                            
                            Logger.Info("数据下载完成");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

