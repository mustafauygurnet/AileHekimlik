namespace aile_hekimlik
{
    partial class rapor_hasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rapor_hasta));
            this.tbl_hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ailehekimlikDataSet = new aile_hekimlik.ailehekimlikDataSet();
            this.rapor_hastakayit = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_hastaTableAdapter = new aile_hekimlik.ailehekimlikDataSetTableAdapters.tbl_hastaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ailehekimlikDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_hastaBindingSource
            // 
            this.tbl_hastaBindingSource.DataMember = "tbl_hasta";
            this.tbl_hastaBindingSource.DataSource = this.ailehekimlikDataSet;
            // 
            // ailehekimlikDataSet
            // 
            this.ailehekimlikDataSet.DataSetName = "ailehekimlikDataSet";
            this.ailehekimlikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapor_hastakayit
            // 
            this.rapor_hastakayit.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_hastaBindingSource;
            this.rapor_hastakayit.LocalReport.DataSources.Add(reportDataSource1);
            this.rapor_hastakayit.LocalReport.ReportEmbeddedResource = "aile_hekimlik.rapor_hasta.rdlc";
            this.rapor_hastakayit.Location = new System.Drawing.Point(0, 0);
            this.rapor_hastakayit.Name = "rapor_hastakayit";
            this.rapor_hastakayit.Size = new System.Drawing.Size(1045, 476);
            this.rapor_hastakayit.TabIndex = 0;
            // 
            // tbl_hastaTableAdapter
            // 
            this.tbl_hastaTableAdapter.ClearBeforeFill = true;
            // 
            // rapor_hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 476);
            this.Controls.Add(this.rapor_hastakayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rapor_hasta";
            this.Text = "HASTA KAYIT RAPORU AL";
            this.Load += new System.EventHandler(this.rapor_hasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ailehekimlikDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rapor_hastakayit;
        private System.Windows.Forms.BindingSource tbl_hastaBindingSource;
        private ailehekimlikDataSet ailehekimlikDataSet;
        private ailehekimlikDataSetTableAdapters.tbl_hastaTableAdapter tbl_hastaTableAdapter;
    }
}