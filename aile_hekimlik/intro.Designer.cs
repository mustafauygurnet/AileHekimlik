namespace aile_hekimlik
{
    partial class intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intro));
            this.yukleniyor = new System.Windows.Forms.ProgressBar();
            this.timer_yukleniyor = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // yukleniyor
            // 
            this.yukleniyor.Location = new System.Drawing.Point(-2, 385);
            this.yukleniyor.Name = "yukleniyor";
            this.yukleniyor.Size = new System.Drawing.Size(751, 16);
            this.yukleniyor.TabIndex = 0;
            // 
            // timer_yukleniyor
            // 
            this.timer_yukleniyor.Enabled = true;
            this.timer_yukleniyor.Tick += new System.EventHandler(this.timer_yukleniyor_Tick);
            // 
            // intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::aile_hekimlik.Properties.Resources.anasayfa_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 400);
            this.Controls.Add(this.yukleniyor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "intro";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_yukleniyor;
        private System.Windows.Forms.ProgressBar yukleniyor;
    }
}