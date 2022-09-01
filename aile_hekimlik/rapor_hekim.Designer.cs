namespace aile_hekimlik
{
    partial class rapor_hekim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rapor_hekim));
            this.tbl_hekimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ailehekimlikDataSet = new aile_hekimlik.ailehekimlikDataSet();
            this.rapor_hekimkayit = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_hekimTableAdapter = new aile_hekimlik.ailehekimlikDataSetTableAdapters.tbl_hekimTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hekimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ailehekimlikDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_hekimBindingSource
            // 
            this.tbl_hekimBindingSource.DataMember = "tbl_hekim";
            this.tbl_hekimBindingSource.DataSource = this.ailehekimlikDataSet;
            // 
            // ailehekimlikDataSet
            // 
            this.ailehekimlikDataSet.DataSetName = "ailehekimlikDataSet";
            this.ailehekimlikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapor_hekimkayit
            // 
            this.rapor_hekimkayit.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.tbl_hekimBindingSource;
            this.rapor_hekimkayit.LocalReport.DataSources.Add(reportDataSource1);
            this.rapor_hekimkayit.LocalReport.ReportEmbeddedResource = "aile_hekimlik.rapor_hekim.rdlc";
            this.rapor_hekimkayit.Location = new System.Drawing.Point(0, 0);
            this.rapor_hekimkayit.Name = "rapor_hekimkayit";
            this.rapor_hekimkayit.Size = new System.Drawing.Size(857, 475);
            this.rapor_hekimkayit.TabIndex = 0;
            // 
            // tbl_hekimTableAdapter
            // 
            this.tbl_hekimTableAdapter.ClearBeforeFill = true;
            // 
            // rapor_hekim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 475);
            this.Controls.Add(this.rapor_hekimkayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rapor_hekim";
            this.Text = "HEKİM KAYIT RAPORU AL";
            this.Load += new System.EventHandler(this.rapor_hekim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hekimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ailehekimlikDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rapor_hekimkayit;
        private System.Windows.Forms.BindingSource tbl_hekimBindingSource;
        private ailehekimlikDataSet ailehekimlikDataSet;
        private ailehekimlikDataSetTableAdapters.tbl_hekimTableAdapter tbl_hekimTableAdapter;
    }
}