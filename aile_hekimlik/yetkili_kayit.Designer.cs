namespace aile_hekimlik
{
    partial class yetkili_kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yetkili_kayit));
            this.label1 = new System.Windows.Forms.Label();
            this.listview_yetkilikayit = new System.Windows.Forms.ListView();
            this.btn_yetkilikisi_kayit = new System.Windows.Forms.Button();
            this.btn_yetkilikisi_cikis = new System.Windows.Forms.Button();
            this.btn_yetkilikayit_rapor = new System.Windows.Forms.Button();
            this.btn_yetkilikisi_guncelle = new System.Windows.Forms.Button();
            this.btn_yetkilikisi_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "YETKİLİ KİŞİ KAYIT";
            // 
            // listview_yetkilikayit
            // 
            this.listview_yetkilikayit.Location = new System.Drawing.Point(-6, 52);
            this.listview_yetkilikayit.Name = "listview_yetkilikayit";
            this.listview_yetkilikayit.Size = new System.Drawing.Size(517, 210);
            this.listview_yetkilikayit.TabIndex = 99;
            this.listview_yetkilikayit.UseCompatibleStateImageBehavior = false;
            // 
            // btn_yetkilikisi_kayit
            // 
            this.btn_yetkilikisi_kayit.BackgroundImage = global::aile_hekimlik.Properties.Resources.user;
            this.btn_yetkilikisi_kayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yetkilikisi_kayit.FlatAppearance.BorderSize = 0;
            this.btn_yetkilikisi_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkilikisi_kayit.Location = new System.Drawing.Point(12, 278);
            this.btn_yetkilikisi_kayit.Name = "btn_yetkilikisi_kayit";
            this.btn_yetkilikisi_kayit.Size = new System.Drawing.Size(88, 61);
            this.btn_yetkilikisi_kayit.TabIndex = 1;
            this.btn_yetkilikisi_kayit.UseVisualStyleBackColor = true;
            this.btn_yetkilikisi_kayit.Click += new System.EventHandler(this.btn_yetkilikisi_kayit_Click);
            // 
            // btn_yetkilikisi_cikis
            // 
            this.btn_yetkilikisi_cikis.BackgroundImage = global::aile_hekimlik.Properties.Resources.exit_fw;
            this.btn_yetkilikisi_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yetkilikisi_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_yetkilikisi_cikis.FlatAppearance.BorderSize = 0;
            this.btn_yetkilikisi_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkilikisi_cikis.Location = new System.Drawing.Point(420, 278);
            this.btn_yetkilikisi_cikis.Name = "btn_yetkilikisi_cikis";
            this.btn_yetkilikisi_cikis.Size = new System.Drawing.Size(76, 61);
            this.btn_yetkilikisi_cikis.TabIndex = 5;
            this.btn_yetkilikisi_cikis.UseVisualStyleBackColor = true;
            this.btn_yetkilikisi_cikis.Click += new System.EventHandler(this.btn_yetkilikisi_cikis_Click);
            // 
            // btn_yetkilikayit_rapor
            // 
            this.btn_yetkilikayit_rapor.BackgroundImage = global::aile_hekimlik.Properties.Resources.excel_11;
            this.btn_yetkilikayit_rapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yetkilikayit_rapor.Location = new System.Drawing.Point(327, 280);
            this.btn_yetkilikayit_rapor.Name = "btn_yetkilikayit_rapor";
            this.btn_yetkilikayit_rapor.Size = new System.Drawing.Size(78, 58);
            this.btn_yetkilikayit_rapor.TabIndex = 4;
            this.btn_yetkilikayit_rapor.UseVisualStyleBackColor = true;
            this.btn_yetkilikayit_rapor.Click += new System.EventHandler(this.btn_yetkilikayit_rapor_Click);
            // 
            // btn_yetkilikisi_guncelle
            // 
            this.btn_yetkilikisi_guncelle.BackgroundImage = global::aile_hekimlik.Properties.Resources.update;
            this.btn_yetkilikisi_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yetkilikisi_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_yetkilikisi_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkilikisi_guncelle.Location = new System.Drawing.Point(226, 278);
            this.btn_yetkilikisi_guncelle.Name = "btn_yetkilikisi_guncelle";
            this.btn_yetkilikisi_guncelle.Size = new System.Drawing.Size(88, 61);
            this.btn_yetkilikisi_guncelle.TabIndex = 3;
            this.btn_yetkilikisi_guncelle.UseVisualStyleBackColor = true;
            this.btn_yetkilikisi_guncelle.Click += new System.EventHandler(this.btn_yetkilikisi_guncelle_Click);
            // 
            // btn_yetkilikisi_sil
            // 
            this.btn_yetkilikisi_sil.BackgroundImage = global::aile_hekimlik.Properties.Resources.delete;
            this.btn_yetkilikisi_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yetkilikisi_sil.FlatAppearance.BorderSize = 0;
            this.btn_yetkilikisi_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkilikisi_sil.Location = new System.Drawing.Point(120, 278);
            this.btn_yetkilikisi_sil.Name = "btn_yetkilikisi_sil";
            this.btn_yetkilikisi_sil.Size = new System.Drawing.Size(88, 61);
            this.btn_yetkilikisi_sil.TabIndex = 2;
            this.btn_yetkilikisi_sil.UseVisualStyleBackColor = true;
            this.btn_yetkilikisi_sil.Click += new System.EventHandler(this.btn_yetkilikisi_sil_Click);
            // 
            // yetkili_kayit
            // 
            this.AcceptButton = this.btn_yetkilikisi_kayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CancelButton = this.btn_yetkilikisi_cikis;
            this.ClientSize = new System.Drawing.Size(509, 352);
            this.Controls.Add(this.btn_yetkilikayit_rapor);
            this.Controls.Add(this.btn_yetkilikisi_cikis);
            this.Controls.Add(this.btn_yetkilikisi_guncelle);
            this.Controls.Add(this.btn_yetkilikisi_sil);
            this.Controls.Add(this.btn_yetkilikisi_kayit);
            this.Controls.Add(this.listview_yetkilikayit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "yetkili_kayit";
            this.Text = "YETKİLİ KAYIT";
            this.Load += new System.EventHandler(this.yetkili_kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listview_yetkilikayit;
        private System.Windows.Forms.Button btn_yetkilikisi_kayit;
        private System.Windows.Forms.Button btn_yetkilikisi_sil;
        private System.Windows.Forms.Button btn_yetkilikisi_guncelle;
        private System.Windows.Forms.Button btn_yetkilikisi_cikis;
        private System.Windows.Forms.Button btn_yetkilikayit_rapor;
    }
}