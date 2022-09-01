namespace aile_hekimlik
{
    partial class rapor_randevu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rapor_randevu));
            this.tbl_randevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ailehekimlikDataSet = new aile_hekimlik.ailehekimlikDataSet();
            this.rapor_randevukayit = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_randevuTableAdapter = new aile_hekimlik.ailehekimlikDataSetTableAdapters.tbl_randevuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_randevuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ailehekimlikDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_randevuBindingSource
            // 
            this.tbl_randevuBindingSource.DataMember = "tbl_randevu";
            this.tbl_randevuBindingSource.DataSource = this.ailehekimlikDataSet;
            // 
            // ailehekimlikDataSet
            // 
            this.ailehekimlikDataSet.DataSetName = "ailehekimlikDataSet";
            this.ailehekimlikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapor_randevukayit
            // 
            this.rapor_randevukayit.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.tbl_randevuBindingSource;
            this.rapor_randevukayit.LocalReport.DataSources.Add(reportDataSource1);
            this.rapor_randevukayit.LocalReport.ReportEmbeddedResource = "aile_hekimlik.rapor_randevu.rdlc";
            this.rapor_randevukayit.Location = new System.Drawing.Point(0, 0);
            this.rapor_randevukayit.Name = "rapor_randevukayit";
            this.rapor_randevukayit.Size = new System.Drawing.Size(482, 427);
            this.rapor_randevukayit.TabIndex = 0;
            // 
            // tbl_randevuTableAdapter
            // 
            this.tbl_randevuTableAdapter.ClearBeforeFill = true;
            // 
            // rapor_randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 427);
            this.Controls.Add(this.rapor_randevukayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rapor_randevu";
            this.Text = "RANDEVULAR RAPORU AL";
            this.Load += new System.EventHandler(this.rapor_randevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_randevuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ailehekimlikDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rapor_randevukayit;
        private System.Windows.Forms.BindingSource tbl_randevuBindingSource;
        private ailehekimlikDataSet ailehekimlikDataSet;
        private ailehekimlikDataSetTableAdapters.tbl_randevuTableAdapter tbl_randevuTableAdapter;
    }
}