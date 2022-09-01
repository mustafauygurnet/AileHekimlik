namespace aile_hekimlik
{
    partial class hastalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastalar));
            this.label1 = new System.Windows.Forms.Label();
            this.listview_hastakayit = new System.Windows.Forms.ListView();
            this.btn_hastakayit_sorgula = new System.Windows.Forms.Button();
            this.btn_hastakayit_cikis = new System.Windows.Forms.Button();
            this.btn_hastakayit_guncelle = new System.Windows.Forms.Button();
            this.btn_hastakayit_sil = new System.Windows.Forms.Button();
            this.btn_hastakayit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_hastakayit_rapor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(364, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "AİLE HEKİMLİĞİ HASTA KAYIT";
            // 
            // listview_hastakayit
            // 
            this.listview_hastakayit.Location = new System.Drawing.Point(-2, 70);
            this.listview_hastakayit.Name = "listview_hastakayit";
            this.listview_hastakayit.Size = new System.Drawing.Size(1126, 306);
            this.listview_hastakayit.TabIndex = 99;
            this.listview_hastakayit.UseCompatibleStateImageBehavior = false;
            // 
            // btn_hastakayit_sorgula
            // 
            this.btn_hastakayit_sorgula.BackgroundImage = global::aile_hekimlik.Properties.Resources.Search_Male_User;
            this.btn_hastakayit_sorgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastakayit_sorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastakayit_sorgula.Location = new System.Drawing.Point(436, 391);
            this.btn_hastakayit_sorgula.Name = "btn_hastakayit_sorgula";
            this.btn_hastakayit_sorgula.Size = new System.Drawing.Size(83, 58);
            this.btn_hastakayit_sorgula.TabIndex = 5;
            this.btn_hastakayit_sorgula.UseVisualStyleBackColor = true;
            this.btn_hastakayit_sorgula.Click += new System.EventHandler(this.btn_hastakayit_sorgula_Click);
            // 
            // btn_hastakayit_cikis
            // 
            this.btn_hastakayit_cikis.BackgroundImage = global::aile_hekimlik.Properties.Resources.exit_fw;
            this.btn_hastakayit_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastakayit_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_hastakayit_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastakayit_cikis.Location = new System.Drawing.Point(689, 391);
            this.btn_hastakayit_cikis.Name = "btn_hastakayit_cikis";
            this.btn_hastakayit_cikis.Size = new System.Drawing.Size(74, 58);
            this.btn_hastakayit_cikis.TabIndex = 7;
            this.btn_hastakayit_cikis.UseVisualStyleBackColor = true;
            this.btn_hastakayit_cikis.Click += new System.EventHandler(this.btn_hastakayit_cikis_Click);
            // 
            // btn_hastakayit_guncelle
            // 
            this.btn_hastakayit_guncelle.BackgroundImage = global::aile_hekimlik.Properties.Resources.update;
            this.btn_hastakayit_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastakayit_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastakayit_guncelle.Location = new System.Drawing.Point(300, 391);
            this.btn_hastakayit_guncelle.Name = "btn_hastakayit_guncelle";
            this.btn_hastakayit_guncelle.Size = new System.Drawing.Size(83, 58);
            this.btn_hastakayit_guncelle.TabIndex = 4;
            this.btn_hastakayit_guncelle.UseVisualStyleBackColor = true;
            this.btn_hastakayit_guncelle.Click += new System.EventHandler(this.btn_hastakayit_guncelle_Click);
            // 
            // btn_hastakayit_sil
            // 
            this.btn_hastakayit_sil.BackgroundImage = global::aile_hekimlik.Properties.Resources.delete;
            this.btn_hastakayit_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastakayit_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastakayit_sil.Location = new System.Drawing.Point(155, 391);
            this.btn_hastakayit_sil.Name = "btn_hastakayit_sil";
            this.btn_hastakayit_sil.Size = new System.Drawing.Size(83, 58);
            this.btn_hastakayit_sil.TabIndex = 3;
            this.btn_hastakayit_sil.UseVisualStyleBackColor = true;
            this.btn_hastakayit_sil.Click += new System.EventHandler(this.btn_hastakayit_sil_Click);
            // 
            // btn_hastakayit
            // 
            this.btn_hastakayit.BackgroundImage = global::aile_hekimlik.Properties.Resources.user;
            this.btn_hastakayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastakayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastakayit.Location = new System.Drawing.Point(32, 391);
            this.btn_hastakayit.Name = "btn_hastakayit";
            this.btn_hastakayit.Size = new System.Drawing.Size(83, 58);
            this.btn_hastakayit.TabIndex = 2;
            this.btn_hastakayit.UseVisualStyleBackColor = true;
            this.btn_hastakayit.Click += new System.EventHandler(this.btn_hastakayit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::aile_hekimlik.Properties.Resources.atatürk_imzası_1230616;
            this.pictureBox3.Location = new System.Drawing.Point(992, 436);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::aile_hekimlik.Properties.Resources.ataturk_fontu;
            this.pictureBox2.Location = new System.Drawing.Point(1035, 391);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(827, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Emanet Ediniz...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(827, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "Beni Türk Hekimlerine";
            // 
            // btn_hastakayit_rapor
            // 
            this.btn_hastakayit_rapor.BackgroundImage = global::aile_hekimlik.Properties.Resources.excel_11;
            this.btn_hastakayit_rapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastakayit_rapor.Location = new System.Drawing.Point(565, 391);
            this.btn_hastakayit_rapor.Name = "btn_hastakayit_rapor";
            this.btn_hastakayit_rapor.Size = new System.Drawing.Size(78, 58);
            this.btn_hastakayit_rapor.TabIndex = 6;
            this.btn_hastakayit_rapor.UseVisualStyleBackColor = true;
            this.btn_hastakayit_rapor.Click += new System.EventHandler(this.btn_hastakayit_rapor_Click);
            // 
            // hastalar
            // 
            this.AcceptButton = this.btn_hastakayit_cikis;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CancelButton = this.btn_hastakayit_cikis;
            this.ClientSize = new System.Drawing.Size(1125, 471);
            this.Controls.Add(this.btn_hastakayit_rapor);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_hastakayit_sorgula);
            this.Controls.Add(this.listview_hastakayit);
            this.Controls.Add(this.btn_hastakayit_cikis);
            this.Controls.Add(this.btn_hastakayit_guncelle);
            this.Controls.Add(this.btn_hastakayit_sil);
            this.Controls.Add(this.btn_hastakayit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "hastalar";
            this.Text = "HASTA KAYIT";
            this.Load += new System.EventHandler(this.hastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hastakayit;
        private System.Windows.Forms.Button btn_hastakayit_sil;
        private System.Windows.Forms.Button btn_hastakayit_guncelle;
        private System.Windows.Forms.Button btn_hastakayit_cikis;
        private System.Windows.Forms.ListView listview_hastakayit;
        private System.Windows.Forms.Button btn_hastakayit_sorgula;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_hastakayit_rapor;
    }
}