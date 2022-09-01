namespace aile_hekimlik
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.saatim = new System.Windows.Forms.Timer(this.components);
            this.say = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sayin = new System.Windows.Forms.Label();
            this.hakkinda = new System.Windows.Forms.MenuStrip();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanımŞartlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncellemeKontrolüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_yetkiliekle = new System.Windows.Forms.Button();
            this.btn_randevukayit = new System.Windows.Forms.Button();
            this.btn_hekimkayit = new System.Windows.Forms.Button();
            this.btn_hastakayit = new System.Windows.Forms.Button();
            this.anasayfa_picbox = new System.Windows.Forms.PictureBox();
            this.hakkinda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anasayfa_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(152, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "AİLE HEKİMLİĞİ MERKEZÎ BİRİM";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(633, 396);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(0, 16);
            this.lbl_saat.TabIndex = 10;
            // 
            // saatim
            // 
            this.saatim.Tick += new System.EventHandler(this.saatim_Tick);
            // 
            // say
            // 
            this.say.Interval = 1000;
            this.say.Tick += new System.EventHandler(this.say_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "HEKİM KAYIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "RANDEVU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "YÖNETİCİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ÇIKIŞ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "HASTA KAYIT";
            // 
            // sayin
            // 
            this.sayin.AutoSize = true;
            this.sayin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayin.Location = new System.Drawing.Point(12, 397);
            this.sayin.Name = "sayin";
            this.sayin.Size = new System.Drawing.Size(0, 15);
            this.sayin.TabIndex = 9;
            // 
            // hakkinda
            // 
            this.hakkinda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem,
            this.kullanımŞartlarıToolStripMenuItem,
            this.güncellemeKontrolüToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.hakkinda.Location = new System.Drawing.Point(0, 0);
            this.hakkinda.Name = "hakkinda";
            this.hakkinda.Size = new System.Drawing.Size(792, 24);
            this.hakkinda.TabIndex = 17;
            this.hakkinda.Text = "menuStrip1";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında ";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // kullanımŞartlarıToolStripMenuItem
            // 
            this.kullanımŞartlarıToolStripMenuItem.Name = "kullanımŞartlarıToolStripMenuItem";
            this.kullanımŞartlarıToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.kullanımŞartlarıToolStripMenuItem.Text = "Kullanım Şartları";
            this.kullanımŞartlarıToolStripMenuItem.Click += new System.EventHandler(this.kullanımŞartlarıToolStripMenuItem_Click);
            // 
            // güncellemeKontrolüToolStripMenuItem
            // 
            this.güncellemeKontrolüToolStripMenuItem.Name = "güncellemeKontrolüToolStripMenuItem";
            this.güncellemeKontrolüToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.güncellemeKontrolüToolStripMenuItem.Text = "Güncelleme Kontrolü";
            this.güncellemeKontrolüToolStripMenuItem.Click += new System.EventHandler(this.güncellemeKontrolüToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackgroundImage = global::aile_hekimlik.Properties.Resources.cikis_fw;
            this.btn_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cikis.FlatAppearance.BorderSize = 0;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(636, 423);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(77, 58);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_yetkiliekle
            // 
            this.btn_yetkiliekle.BackgroundImage = global::aile_hekimlik.Properties.Resources.image_gallery;
            this.btn_yetkiliekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yetkiliekle.FlatAppearance.BorderSize = 0;
            this.btn_yetkiliekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkiliekle.Location = new System.Drawing.Point(486, 423);
            this.btn_yetkiliekle.Name = "btn_yetkiliekle";
            this.btn_yetkiliekle.Size = new System.Drawing.Size(77, 58);
            this.btn_yetkiliekle.TabIndex = 5;
            this.btn_yetkiliekle.UseVisualStyleBackColor = true;
            this.btn_yetkiliekle.Click += new System.EventHandler(this.btn_yetkiliekle_Click);
            // 
            // btn_randevukayit
            // 
            this.btn_randevukayit.BackgroundImage = global::aile_hekimlik.Properties.Resources.images__2_;
            this.btn_randevukayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_randevukayit.FlatAppearance.BorderSize = 0;
            this.btn_randevukayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevukayit.Location = new System.Drawing.Point(333, 423);
            this.btn_randevukayit.Name = "btn_randevukayit";
            this.btn_randevukayit.Size = new System.Drawing.Size(77, 58);
            this.btn_randevukayit.TabIndex = 3;
            this.btn_randevukayit.UseVisualStyleBackColor = true;
            this.btn_randevukayit.Click += new System.EventHandler(this.btn_randevukayit_Click);
            // 
            // btn_hekimkayit
            // 
            this.btn_hekimkayit.BackgroundImage = global::aile_hekimlik.Properties.Resources.hekimim_fw;
            this.btn_hekimkayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hekimkayit.FlatAppearance.BorderSize = 0;
            this.btn_hekimkayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hekimkayit.ForeColor = System.Drawing.Color.Green;
            this.btn_hekimkayit.Location = new System.Drawing.Point(189, 423);
            this.btn_hekimkayit.Name = "btn_hekimkayit";
            this.btn_hekimkayit.Size = new System.Drawing.Size(77, 58);
            this.btn_hekimkayit.TabIndex = 2;
            this.btn_hekimkayit.UseVisualStyleBackColor = true;
            this.btn_hekimkayit.Click += new System.EventHandler(this.btn_hekimkayit_Click);
            // 
            // btn_hastakayit
            // 
            this.btn_hastakayit.BackgroundImage = global::aile_hekimlik.Properties.Resources.hastam_fw;
            this.btn_hastakayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastakayit.FlatAppearance.BorderSize = 0;
            this.btn_hastakayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastakayit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_hastakayit.Location = new System.Drawing.Point(51, 423);
            this.btn_hastakayit.Name = "btn_hastakayit";
            this.btn_hastakayit.Size = new System.Drawing.Size(77, 58);
            this.btn_hastakayit.TabIndex = 1;
            this.btn_hastakayit.UseVisualStyleBackColor = true;
            this.btn_hastakayit.Click += new System.EventHandler(this.btn_hastakayit_Click);
            // 
            // anasayfa_picbox
            // 
            this.anasayfa_picbox.Image = global::aile_hekimlik.Properties.Resources.anasayfa_logo;
            this.anasayfa_picbox.Location = new System.Drawing.Point(0, 90);
            this.anasayfa_picbox.Name = "anasayfa_picbox";
            this.anasayfa_picbox.Size = new System.Drawing.Size(791, 292);
            this.anasayfa_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anasayfa_picbox.TabIndex = 0;
            this.anasayfa_picbox.TabStop = false;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CancelButton = this.btn_cikis;
            this.ClientSize = new System.Drawing.Size(792, 523);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.sayin);
            this.Controls.Add(this.btn_yetkiliekle);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_randevukayit);
            this.Controls.Add(this.btn_hekimkayit);
            this.Controls.Add(this.btn_hastakayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anasayfa_picbox);
            this.Controls.Add(this.hakkinda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.hakkinda;
            this.Name = "anasayfa";
            this.Text = "AİLE HEKİMLİĞİ MERKEZÎ BİRİM";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.MouseLeave += new System.EventHandler(this.anasayfa_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.anasayfa_MouseMove);
            this.hakkinda.ResumeLayout(false);
            this.hakkinda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anasayfa_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox anasayfa_picbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hastakayit;
        private System.Windows.Forms.Button btn_hekimkayit;
        private System.Windows.Forms.Button btn_randevukayit;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_yetkiliekle;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Timer saatim;
        private System.Windows.Forms.Timer say;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sayin;
        private System.Windows.Forms.MenuStrip hakkinda;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanımŞartlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncellemeKontrolüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
    }
}

