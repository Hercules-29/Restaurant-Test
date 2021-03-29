
namespace Restaurant {
    partial class frmReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartReport = new LiveCharts.WinForms.CartesianChart();
            this.cboReportType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picCus = new System.Windows.Forms.PictureBox();
            this.picProfit = new System.Windows.Forms.PictureBox();
            this.picRevenue = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.reportIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seperator3 = new Restaurant.Seperator();
            this.seperator2 = new Restaurant.Seperator();
            this.seperator1 = new Restaurant.Seperator();
            ((System.ComponentModel.ISupportInitialize)(this.picCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenue)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // chartReport
            // 
            this.chartReport.Location = new System.Drawing.Point(282, 431);
            this.chartReport.Name = "chartReport";
            this.chartReport.Size = new System.Drawing.Size(967, 368);
            this.chartReport.TabIndex = 0;
            this.chartReport.Text = "cartesianChart1";
            // 
            // cboReportType
            // 
            this.cboReportType.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cboReportType.Font = new System.Drawing.Font("Valeria Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReportType.ForeColor = System.Drawing.Color.Honeydew;
            this.cboReportType.FormattingEnabled = true;
            this.cboReportType.Items.AddRange(new object[] {
            "Daily Report",
            "Weekly Report",
            "Monthly Report",
            "Yearly Report"});
            this.cboReportType.Location = new System.Drawing.Point(12, 452);
            this.cboReportType.Name = "cboReportType";
            this.cboReportType.Size = new System.Drawing.Size(213, 28);
            this.cboReportType.TabIndex = 2;
            this.cboReportType.SelectedIndexChanged += new System.EventHandler(this.cboReportType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Valeria Medium", 13F);
            this.label7.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label7.Location = new System.Drawing.Point(64, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Report Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Valeria Medium", 13F);
            this.label8.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label8.Location = new System.Drawing.Point(278, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Report";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Valeria Medium", 13F);
            this.label10.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label10.Location = new System.Drawing.Point(6, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Average Customer Spent";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label11.Font = new System.Drawing.Font("Valeria Medium", 20F);
            this.label11.ForeColor = System.Drawing.Color.Honeydew;
            this.label11.Location = new System.Drawing.Point(11, 564);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 40);
            this.label11.TabIndex = 12;
            this.label11.Text = "753,25 $";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCus
            // 
            this.picCus.Image = ((System.Drawing.Image)(resources.GetObject("picCus.Image")));
            this.picCus.Location = new System.Drawing.Point(3, 3);
            this.picCus.Name = "picCus";
            this.picCus.Size = new System.Drawing.Size(77, 76);
            this.picCus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCus.TabIndex = 0;
            this.picCus.TabStop = false;
            // 
            // picProfit
            // 
            this.picProfit.Image = ((System.Drawing.Image)(resources.GetObject("picProfit.Image")));
            this.picProfit.Location = new System.Drawing.Point(3, 297);
            this.picProfit.Name = "picProfit";
            this.picProfit.Size = new System.Drawing.Size(77, 76);
            this.picProfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfit.TabIndex = 1;
            this.picProfit.TabStop = false;
            // 
            // picRevenue
            // 
            this.picRevenue.Image = ((System.Drawing.Image)(resources.GetObject("picRevenue.Image")));
            this.picRevenue.Location = new System.Drawing.Point(3, 150);
            this.picRevenue.Name = "picRevenue";
            this.picRevenue.Size = new System.Drawing.Size(77, 76);
            this.picRevenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRevenue.TabIndex = 2;
            this.picRevenue.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Valeria Medium", 13F);
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(86, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Customer | YTD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Valeria Medium", 13F);
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(86, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sale Revenue | YTD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Valeria Medium", 13F);
            this.label3.ForeColor = System.Drawing.Color.LightYellow;
            this.label3.Location = new System.Drawing.Point(86, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Profit | YTD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Valeria Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightYellow;
            this.label4.Location = new System.Drawing.Point(86, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "589";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Valeria Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightYellow;
            this.label5.Location = new System.Drawing.Point(86, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "78452,25 $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Valeria Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightYellow;
            this.label6.Location = new System.Drawing.Point(86, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "200 $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Valeria Medium", 13F);
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(367, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Report";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel.Controls.Add(this.dgvReport);
            this.panel.Controls.Add(this.seperator3);
            this.panel.Controls.Add(this.seperator2);
            this.panel.Controls.Add(this.seperator1);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.picRevenue);
            this.panel.Controls.Add(this.picProfit);
            this.panel.Controls.Add(this.picCus);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1240, 377);
            this.panel.TabIndex = 1;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeColumns = false;
            this.dgvReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Valeria Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Honeydew;
            this.dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Valeria Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportIdCol,
            this.dateCol,
            this.totalAmountCol});
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.Location = new System.Drawing.Point(371, 38);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.ShowEditingIcon = false;
            this.dgvReport.Size = new System.Drawing.Size(866, 332);
            this.dgvReport.TabIndex = 16;
            // 
            // reportIdCol
            // 
            this.reportIdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Valeria Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Honeydew;
            this.reportIdCol.DefaultCellStyle = dataGridViewCellStyle8;
            this.reportIdCol.HeaderText = "Report ID";
            this.reportIdCol.Name = "reportIdCol";
            this.reportIdCol.ReadOnly = true;
            this.reportIdCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dateCol
            // 
            this.dateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Valeria Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle9.Format = "dd/MM/yyyy";
            this.dateCol.DefaultCellStyle = dataGridViewCellStyle9;
            this.dateCol.HeaderText = "Date";
            this.dateCol.Name = "dateCol";
            this.dateCol.ReadOnly = true;
            this.dateCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // totalAmountCol
            // 
            this.totalAmountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Valeria Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.totalAmountCol.DefaultCellStyle = dataGridViewCellStyle10;
            this.totalAmountCol.HeaderText = "Total Amount";
            this.totalAmountCol.Name = "totalAmountCol";
            this.totalAmountCol.ReadOnly = true;
            this.totalAmountCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // seperator3
            // 
            this.seperator3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.seperator3.isVertical = true;
            this.seperator3.Location = new System.Drawing.Point(328, 3);
            this.seperator3.Name = "seperator3";
            this.seperator3.Size = new System.Drawing.Size(10, 367);
            this.seperator3.TabIndex = 15;
            this.seperator3.Thickness = 2;
            // 
            // seperator2
            // 
            this.seperator2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.seperator2.isVertical = false;
            this.seperator2.Location = new System.Drawing.Point(18, 118);
            this.seperator2.Name = "seperator2";
            this.seperator2.Size = new System.Drawing.Size(282, 2);
            this.seperator2.TabIndex = 14;
            this.seperator2.Thickness = 2;
            // 
            // seperator1
            // 
            this.seperator1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.seperator1.isVertical = false;
            this.seperator1.Location = new System.Drawing.Point(18, 261);
            this.seperator1.Name = "seperator1";
            this.seperator1.Size = new System.Drawing.Size(282, 2);
            this.seperator1.TabIndex = 13;
            this.seperator1.Thickness = 2;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1264, 811);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboReportType);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.chartReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenue)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart chartReport;
        private System.Windows.Forms.ComboBox cboReportType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picCus;
        private System.Windows.Forms.PictureBox picProfit;
        private System.Windows.Forms.PictureBox picRevenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel;
        private Seperator seperator3;
        private Seperator seperator2;
        private Seperator seperator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountCol;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}

