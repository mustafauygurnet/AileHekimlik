namespace aile_hekimlik
{
    partial class rapor_yetkili
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rapor_yetkili));
            this.tbl_yetkiliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ailehekimlikDataSet = new aile_hekimlik.ailehekimlikDataSet();
            this.rapor_yetkilikayit = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_yetkiliTableAdapter = new aile_hekimlik.ailehekimlikDataSetTableAdapters.tbl_yetkiliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_yetkiliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ailehekimlikDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_yetkiliBindingSource
            // 
            this.tbl_yetkiliBindingSource.DataMember = "tbl_yetkili";
            this.tbl_yetkiliBindingSource.DataSource = this.ailehekimlikDataSet;
            // 
            // ailehekimlikDataSet
            // 
            this.ailehekimlikDataSet.DataSetName = "ailehekimlikDataSet";
            this.ailehekimlikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapor_yetkilikayit
            // 
            this.rapor_yetkilikayit.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet4";
            reportDataSource1.Value = this.tbl_yetkiliBindingSource;
            this.rapor_yetkilikayit.LocalReport.DataSources.Add(reportDataSource1);
            this.rapor_yetkilikayit.LocalReport.ReportEmbeddedResource = "aile_hekimlik.rapor_yetkili.rdlc";
            this.rapor_yetkilikayit.Location = new System.Drawing.Point(0, 0);
            this.rapor_yetkilikayit.Name = "rapor_yetkilikayit";
            this.rapor_yetkilikayit.Size = new System.Drawing.Size(577, 431);
            this.rapor_yetkilikayit.TabIndex = 0;
            // 
            // tbl_yetkiliTableAdapter
            // 
            this.tbl_yetkiliTableAdapter.ClearBeforeFill = true;
            // 
            // rapor_yetkili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 431);
            this.Controls.Add(this.rapor_yetkilikayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rapor_yetkili";
            this.Text = "YETKİLİ RAPORU AL";
            this.Load += new System.EventHandler(this.rapor_yetkili_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_yetkiliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ailehekimlikDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rapor_yetkilikayit;
        private System.Windows.Forms.BindingSource tbl_yetkiliBindingSource;
        private ailehekimlikDataSet ailehekimlikDataSet;
        private ailehekimlikDataSetTableAdapters.tbl_yetkiliTableAdapter tbl_yetkiliTableAdapter;
    }
}