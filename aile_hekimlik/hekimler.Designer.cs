namespace aile_hekimlik
{
    partial class hekimler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hekimler));
            this.label1 = new System.Windows.Forms.Label();
            this.listview_hekimkayit = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_hekimkayit = new System.Windows.Forms.Button();
            this.btn_hekimkayit_cikis = new System.Windows.Forms.Button();
            this.btn_hekimkayit_rapor = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_hekimkayit_sorgula = new System.Windows.Forms.Button();
            this.btn_hekimkayit_güncelle = new System.Windows.Forms.Button();
            this.btn_hekimkayit_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "AİLE HEKİMLİĞİ HEKİM KAYIT";
            // 
            // listview_hekimkayit
            // 
            this.listview_hekimkayit.Location = new System.Drawing.Point(-1, 57);
            this.listview_hekimkayit.Name = "listview_hekimkayit";
            this.listview_hekimkayit.Size = new System.Drawing.Size(1044, 257);
            this.listview_hekimkayit.TabIndex = 1;
            this.listview_hekimkayit.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(600, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 54;
            this.label5.Text = "Emanet Ediniz...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Beni Türk Hekimlerine";
            // 
            // btn_hekimkayit
            // 
            this.btn_hekimkayit.BackgroundImage = global::aile_hekimlik.Properties.Resources.user;
            this.btn_hekimkayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hekimkayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hekimkayit.Location = new System.Drawing.Point(12, 353);
            this.btn_hekimkayit.Name = "btn_hekimkayit";
            this.btn_hekimkayit.Size = new System.Drawing.Size(83, 58);
            this.btn_hekimkayit.TabIndex = 2;
            this.btn_hekimkayit.UseVisualStyleBackColor = true;
            this.btn_hekimkayit.Click += new System.EventHandler(this.btn_hekimkayit_Click);
            // 
            // btn_hekimkayit_cikis
            // 
            this.btn_hekimkayit_cikis.BackgroundImage = global::aile_hekimlik.Properties.Resources.cikis_fw;
            this.btn_hekimkayit_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hekimkayit_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_hekimkayit_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hekimkayit_cikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_hekimkayit_cikis.Location = new System.Drawing.Point(520, 353);
            this.btn_hekimkayit_cikis.Name = "btn_hekimkayit_cikis";
            this.btn_hekimkayit_cikis.Size = new System.Drawing.Size(74, 58);
            this.btn_hekimkayit_cikis.TabIndex = 6;
            this.btn_hekimkayit_cikis.UseVisualStyleBackColor = true;
            this.btn_hekimkayit_cikis.Click += new System.EventHandler(this.btn_hekimkayit_cikis_Click);
            // 
            // btn_hekimkayit_rapor
            // 
            this.btn_hekimkayit_rapor.BackgroundImage = global::aile_hekimlik.Properties.Resources.excel_11;
            this.btn_hekimkayit_rapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hekimkayit_rapor.Location = new System.Drawing.Point(423, 353);
            this.btn_hekimkayit_rapor.Name = "btn_hekimkayit_rapor";
            this.btn_hekimkayit_rapor.Size = new System.Drawing.Size(78, 58);
            this.btn_hekimkayit_rapor.TabIndex = 5;
            this.btn_hekimkayit_rapor.UseVisualStyleBackColor = true;
            this.btn_hekimkayit_rapor.Click += new System.EventHandler(this.btn_hekimkayit_rapor_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::aile_hekimlik.Properties.Resources.atatürk_imzası_1230616;
            this.pictureBox3.Location = new System.Drawing.Point(728, 398);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 57;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::aile_hekimlik.Properties.Resources.ataturk_fontu;
            this.pictureBox2.Location = new System.Drawing.Point(771, 353);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // btn_hekimkayit_sorgula
            // 
            this.btn_hekimkayit_sorgula.BackgroundImage = global::aile_hekimlik.Properties.Resources.Search_Male_User;
            this.btn_hekimkayit_sorgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hekimkayit_sorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hekimkayit_sorgula.Location = new System.Drawing.Point(320, 353);
            this.btn_hekimkayit_sorgula.Name = "btn_hekimkayit_sorgula";
            this.btn_hekimkayit_sorgula.Size = new System.Drawing.Size(83, 58);
            this.btn_hekimkayit_sorgula.TabIndex = 6;
            this.btn_hekimkayit_sorgula.UseVisualStyleBackColor = true;
            this.btn_hekimkayit_sorgula.Click += new System.EventHandler(this.btn_hekimkayit_sorgula_Click);
            // 
            // btn_hekimkayit_güncelle
            // 
            this.btn_hekimkayit_güncelle.BackgroundImage = global::aile_hekimlik.Properties.Resources.update;
            this.btn_hekimkayit_güncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hekimkayit_güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hekimkayit_güncelle.Location = new System.Drawing.Point(215, 353);
            this.btn_hekimkayit_güncelle.Name = "btn_hekimkayit_güncelle";
            this.btn_hekimkayit_güncelle.Size = new System.Drawing.Size(83, 58);
            this.btn_hekimkayit_güncelle.TabIndex = 4;
            this.btn_hekimkayit_güncelle.UseVisualStyleBackColor = true;
            this.btn_hekimkayit_güncelle.Click += new System.EventHandler(this.btn_hekimkayit_güncelle_Click);
            // 
            // btn_hekimkayit_sil
            // 
            this.btn_hekimkayit_sil.BackgroundImage = global::aile_hekimlik.Properties.Resources.delete;
            this.btn_hekimkayit_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hekimkayit_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hekimkayit_sil.Location = new System.Drawing.Point(114, 353);
            this.btn_hekimkayit_sil.Name = "btn_hekimkayit_sil";
            this.btn_hekimkayit_sil.Size = new System.Drawing.Size(83, 58);
            this.btn_hekimkayit_sil.TabIndex = 3;
            this.btn_hekimkayit_sil.UseVisualStyleBackColor = true;
            this.btn_hekimkayit_sil.Click += new System.EventHandler(this.btn_hekimkayit_sil_Click);
            // 
            // hekimler
            // 
            this.AcceptButton = this.btn_hekimkayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CancelButton = this.btn_hekimkayit_cikis;
            this.ClientSize = new System.Drawing.Size(859, 436);
            this.Controls.Add(this.btn_hekimkayit_rapor);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_hekimkayit_sorgula);
            this.Controls.Add(this.btn_hekimkayit_cikis);
            this.Controls.Add(this.btn_hekimkayit_güncelle);
            this.Controls.Add(this.btn_hekimkayit_sil);
            this.Controls.Add(this.btn_hekimkayit);
            this.Controls.Add(this.listview_hekimkayit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hekimler";
            this.Text = "HEKİM KAYIT";
            this.Load += new System.EventHandler(this.hekimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listview_hekimkayit;
        private System.Windows.Forms.Button btn_hekimkayit;
        private System.Windows.Forms.Button btn_hekimkayit_sil;
        private System.Windows.Forms.Button btn_hekimkayit_güncelle;
        private System.Windows.Forms.Button btn_hekimkayit_cikis;
        private System.Windows.Forms.Button btn_hekimkayit_sorgula;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_hekimkayit_rapor;
    }
}