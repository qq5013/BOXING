namespace THOK.AS.Boxing.View
{
    partial class OrderQueryForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
#region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.ORDERDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BATCHNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Column2 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Column5 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Column6 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Column7 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Column8 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Column9 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.STATUS1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Column10 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.PACKQUANTITY1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.bsMaster = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.SORTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHANNELNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHANNELTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIGARETTECODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIGARETTENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHANNELLINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.pnlTool.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.Controls.Add(this.btnDownLoad);
            this.pnlTool.Controls.Add(this.lblTotalQty);
            this.pnlTool.Controls.Add(this.label1);
            this.pnlTool.Controls.Add(this.btnExit);
            this.pnlTool.Controls.Add(this.btnRefresh);
            this.pnlTool.Size = new System.Drawing.Size(1044, 53);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.scMain);
            this.pnlContent.Size = new System.Drawing.Size(1044, 405);
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(1044, 458);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dgvMaster);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgvDetail);
            this.scMain.Size = new System.Drawing.Size(1044, 405);
            this.scMain.SplitterDistance = 191;
            this.scMain.TabIndex = 0;
            // 
            // dgvMaster
            // 
            this.dgvMaster.AllowUserToAddRows = false;
            this.dgvMaster.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaster.AutoGenerateColumns = false;
            this.dgvMaster.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDERDATE,
            this.BATCHNO,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.STATUS1,
            this.Column10,
            this.PACKQUANTITY1});
            this.dgvMaster.DataSource = this.bsMaster;
            this.dgvMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvMaster.MultiSelect = false;
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.ReadOnly = true;
            this.dgvMaster.RowHeadersWidth = 30;
            this.dgvMaster.RowTemplate.Height = 23;
            this.dgvMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaster.Size = new System.Drawing.Size(1044, 191);
            this.dgvMaster.TabIndex = 0;
            this.dgvMaster.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaster_RowEnter);
            // 
            // ORDERDATE
            // 
            this.ORDERDATE.DataPropertyName = "ORDERDATE";
            this.ORDERDATE.HeaderText = "订单日期";
            this.ORDERDATE.Name = "ORDERDATE";
            this.ORDERDATE.ReadOnly = true;
            this.ORDERDATE.Width = 80;
            // 
            // BATCHNO
            // 
            this.BATCHNO.DataPropertyName = "BATCHNO";
            this.BATCHNO.HeaderText = "分拣批次";
            this.BATCHNO.Name = "BATCHNO";
            this.BATCHNO.ReadOnly = true;
            this.BATCHNO.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SORTNO";
            this.Column1.FilteringEnabled = false;
            this.Column1.HeaderText = "流水号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ORDERID";
            this.Column2.FilteringEnabled = false;
            this.Column2.HeaderText = "订单号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ROUTECODE";
            this.Column5.FilteringEnabled = false;
            this.Column5.HeaderText = "线路代码";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ROUTENAME";
            this.Column6.FilteringEnabled = false;
            this.Column6.HeaderText = "线路名称";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "CUSTOMERCODE";
            this.Column7.FilteringEnabled = false;
            this.Column7.HeaderText = "客户代码";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 110;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CUSTOMERNAME";
            this.Column8.FilteringEnabled = false;
            this.Column8.HeaderText = "客户名称";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 110;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "STATUS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column9.FilteringEnabled = false;
            this.Column9.HeaderText = "A线下单状态";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 110;
            // 
            // STATUS1
            // 
            this.STATUS1.DataPropertyName = "STATUS1";
            this.STATUS1.FilteringEnabled = false;
            this.STATUS1.HeaderText = "B线下单状态";
            this.STATUS1.Name = "STATUS1";
            this.STATUS1.ReadOnly = true;
            this.STATUS1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STATUS1.Width = 110;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "PACKAGE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column10.FilteringEnabled = false;
            this.Column10.HeaderText = "1号包装状态";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column10.Width = 113;
            // 
            // PACKQUANTITY1
            // 
            this.PACKQUANTITY1.DataPropertyName = "PACKAGE1";
            this.PACKQUANTITY1.FilteringEnabled = false;
            this.PACKQUANTITY1.HeaderText = "2号包装状态";
            this.PACKQUANTITY1.Name = "PACKQUANTITY1";
            this.PACKQUANTITY1.ReadOnly = true;
            this.PACKQUANTITY1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PACKQUANTITY1.Visible = false;
            this.PACKQUANTITY1.Width = 113;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetail.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SORTNO,
            this.ORDERID,
            this.CHANNELNAME,
            this.CHANNELTYPE,
            this.CIGARETTECODE,
            this.CIGARETTENAME,
            this.QUANTITY,
            this.CHANNELLINE});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersWidth = 30;
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(1044, 210);
            this.dgvDetail.TabIndex = 0;
            // 
            // SORTNO
            // 
            this.SORTNO.DataPropertyName = "SORTNO";
            this.SORTNO.HeaderText = "流水号";
            this.SORTNO.Name = "SORTNO";
            this.SORTNO.ReadOnly = true;
            this.SORTNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SORTNO.Width = 70;
            // 
            // ORDERID
            // 
            this.ORDERID.DataPropertyName = "ORDERID";
            this.ORDERID.HeaderText = "订单号";
            this.ORDERID.Name = "ORDERID";
            this.ORDERID.ReadOnly = true;
            this.ORDERID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CHANNELNAME
            // 
            this.CHANNELNAME.DataPropertyName = "CHANNELNAME";
            this.CHANNELNAME.HeaderText = "烟道名称";
            this.CHANNELNAME.Name = "CHANNELNAME";
            this.CHANNELNAME.ReadOnly = true;
            this.CHANNELNAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CHANNELNAME.Width = 80;
            // 
            // CHANNELTYPE
            // 
            this.CHANNELTYPE.DataPropertyName = "CHANNELTYPE";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CHANNELTYPE.DefaultCellStyle = dataGridViewCellStyle7;
            this.CHANNELTYPE.HeaderText = "烟道类型";
            this.CHANNELTYPE.Name = "CHANNELTYPE";
            this.CHANNELTYPE.ReadOnly = true;
            this.CHANNELTYPE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CHANNELTYPE.Width = 80;
            // 
            // CIGARETTECODE
            // 
            this.CIGARETTECODE.DataPropertyName = "CIGARETTECODE";
            this.CIGARETTECODE.HeaderText = "卷烟代码";
            this.CIGARETTECODE.Name = "CIGARETTECODE";
            this.CIGARETTECODE.ReadOnly = true;
            this.CIGARETTECODE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CIGARETTENAME
            // 
            this.CIGARETTENAME.DataPropertyName = "CIGARETTENAME";
            this.CIGARETTENAME.HeaderText = "卷烟名称";
            this.CIGARETTENAME.Name = "CIGARETTENAME";
            this.CIGARETTENAME.ReadOnly = true;
            this.CIGARETTENAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CIGARETTENAME.Width = 200;
            // 
            // QUANTITY
            // 
            this.QUANTITY.DataPropertyName = "QUANTITY";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.QUANTITY.DefaultCellStyle = dataGridViewCellStyle8;
            this.QUANTITY.HeaderText = "数量(件)";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            this.QUANTITY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.QUANTITY.Width = 80;
            // 
            // CHANNELLINE
            // 
            this.CHANNELLINE.DataPropertyName = "CHANNELLINE";
            this.CHANNELLINE.HeaderText = "线组";
            this.CHANNELLINE.Name = "CHANNELLINE";
            this.CHANNELLINE.ReadOnly = true;
            this.CHANNELLINE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.Image = global::THOK.AS.Boxing.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(48, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 51);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "退出";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Image = global::THOK.AS.Boxing.Properties.Resources.Chart;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(48, 51);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "总件数：";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Location = new System.Drawing.Point(696, 35);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(47, 12);
            this.lblTotalQty.TabIndex = 18;
            this.lblTotalQty.Text = "0000000";
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDownLoad.Image = global::THOK.AS.Boxing.Properties.Resources.Chart;
            this.btnDownLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDownLoad.Location = new System.Drawing.Point(96, 0);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(48, 51);
            this.btnDownLoad.TabIndex = 19;
            this.btnDownLoad.Text = "下载";
            this.btnDownLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // OrderQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1044, 458);
            this.Name = "OrderQueryForm";
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.DataGridView dgvMaster;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.BindingSource bsMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BATCHNO;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Column1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Column2;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Column5;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Column6;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Column7;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Column8;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Column9;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn STATUS1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Column10;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn PACKQUANTITY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SORTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHANNELNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHANNELTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIGARETTECODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIGARETTENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHANNELLINE;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownLoad;
    }
}
