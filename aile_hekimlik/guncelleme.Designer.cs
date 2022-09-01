namespace aile_hekimlik
{
    partial class guncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guncelleme));
            this.sayac = new System.Windows.Forms.Timer(this.components);
            this.kontrol = new System.Windows.Forms.ProgressBar();
            this.tebrikler = new System.Windows.Forms.Label();
            this.belge = new System.Windows.Forms.PictureBox();
            this.mercek = new System.Windows.Forms.PictureBox();
            this.smile = new System.Windows.Forms.PictureBox();
            this.like = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.belge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.like)).BeginInit();
            this.SuspendLayout();
            // 
            // sayac
            // 
            this.sayac.Interval = 2999;
            this.sayac.Tick += new System.EventHandler(this.sayac_Tick);
            // 
            // kontrol
            // 
            this.kontrol.Location = new System.Drawing.Point(24, 64);
            this.kontrol.Name = "kontrol";
            this.kontrol.Size = new System.Drawing.Size(254, 23);
            this.kontrol.Step = 30;
            this.kontrol.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.kontrol.TabIndex = 0;
            // 
            // tebrikler
            // 
            this.tebrikler.AutoSize = true;
            this.tebrikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tebrikler.Location = new System.Drawing.Point(21, 103);
            this.tebrikler.Name = "tebrikler";
            this.tebrikler.Size = new System.Drawing.Size(257, 13);
            this.tebrikler.TabIndex = 1;
            this.tebrikler.Text = "Tebrikler! En güncel sürümü kullanıyorsunuz";
            this.tebrikler.Visible = false;
            // 
            // belge
            // 
            this.belge.Image = global::aile_hekimlik.Properties.Resources.odt_sözlesme_310x3101;
            this.belge.Location = new System.Drawing.Point(92, 8);
            this.belge.Name = "belge";
            this.belge.Size = new System.Drawing.Size(100, 50);
            this.belge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.belge.TabIndex = 5;
            this.belge.TabStop = false;
            // 
            // mercek
            // 
            this.mercek.Image = global::aile_hekimlik.Properties.Resources.buyutec_ve_soru_isareti1;
            this.mercek.Location = new System.Drawing.Point(24, 130);
            this.mercek.Name = "mercek";
            this.mercek.Size = new System.Drawing.Size(254, 139);
            this.mercek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mercek.TabIndex = 4;
            this.mercek.TabStop = false;
            // 
            // smile
            // 
            this.smile.Image = global::aile_hekimlik.Properties.Resources.smileys_001_01;
            this.smile.Location = new System.Drawing.Point(92, 8);
            this.smile.Name = "smile";
            this.smile.Size = new System.Drawing.Size(100, 50);
            this.smile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smile.TabIndex = 3;
            this.smile.TabStop = false;
            this.smile.Visible = false;
            // 
            // like
            // 
            this.like.Image = global::aile_hekimlik.Properties.Resources.like_icons_png_7;
            this.like.Location = new System.Drawing.Point(24, 130);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(254, 139);
            this.like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.like.TabIndex = 2;
            this.like.TabStop = false;
            this.like.Visible = false;
            // 
            // guncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(323, 273);
            this.Controls.Add(this.belge);
            this.Controls.Add(this.mercek);
            this.Controls.Add(this.smile);
            this.Controls.Add(this.like);
            this.Controls.Add(this.tebrikler);
            this.Controls.Add(this.kontrol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guncelleme";
            this.Text = "Güncelleme Kontrol";
            this.Load += new System.EventHandler(this.guncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.belge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.like)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer sayac;
        private System.Windows.Forms.ProgressBar kontrol;
        private System.Windows.Forms.Label tebrikler;
        private System.Windows.Forms.PictureBox like;
        private System.Windows.Forms.PictureBox smile;
        private System.Windows.Forms.PictureBox mercek;
        private System.Windows.Forms.PictureBox belge;
    }
}