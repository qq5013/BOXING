using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using THOK.AS.Boxing.Dal;

namespace THOK.AS.Boxing.View
{
    public partial class CustomerOrderQueryForm : THOK.AF.View.ToolbarForm
    {
        private BoxDal boxDal = new BoxDal();
        public CustomerOrderQueryForm()
        {
            InitializeComponent();
            this.Column2.FilteringEnabled = true;
            this.Column5.FilteringEnabled = true;
            this.Column6.FilteringEnabled = true;
            this.Column7.FilteringEnabled = true;
            this.Column8.FilteringEnabled = true;
            this.Column10.FilteringEnabled = true;
            btnRefresh_Click(null,null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bsMaster.DataSource = boxDal.GetPackMaster();
            if (bsMaster.DataSource != null)
            {
                DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dgvMaster);
            }
        }

        private void dgvMaster_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetail.DataSource = boxDal.GetPackDetail(dgvMaster.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            DataTable table = boxDal.GetCigarettes();
            if (table.Rows.Count != 0)
            {
                CigaretteQueryDialog cigaretteQueryDialog = new CigaretteQueryDialog(table);
                if (cigaretteQueryDialog.ShowDialog() == DialogResult.OK)
                {
                    string [] filter = cigaretteQueryDialog.Filter;
                    bsMaster.DataSource = boxDal.GetPackMaster(filter);
                }
            }

            if (bsMaster.DataSource != null)
            {
                DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dgvMaster);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Exit();
        }
    }
}

