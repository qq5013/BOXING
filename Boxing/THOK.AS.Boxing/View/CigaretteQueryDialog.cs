using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace THOK.AS.Boxing.View
{
    public partial class CigaretteQueryDialog : Form
    {
        int quantity = 0;
        public string [] Filter
        {
            get { return new string[] { string.Format(" C.CIGARETTECODE = '{0}' "+"{1}", cbCigarette.SelectedValue != null ? cbCigarette.SelectedValue.ToString() : cbCigarette.Text,Int32.TryParse(txtCigaretteQuantity.Text, out quantity) ?string.Format(" AND C.QUANTITY={0} ",quantity):""), Int32.TryParse(txtCigaretteQuantity.Text, out quantity) ? string.Format(" HAVING SUM(C.QUANTITY) = {0} ", quantity) : "" }; }
        }

        public CigaretteQueryDialog(DataTable table)
        {
            InitializeComponent();
            cbCigarette.DataSource = table;
            cbCigarette.ValueMember = "CIGARETTECODE";
            cbCigarette.DisplayMember = "CIGARETTENAME";            
        }
    }
}