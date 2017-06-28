namespace Minesweeper
{
    partial class WinnerForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbTime = new DevExpress.XtraEditors.LabelControl();
            this.btPlay = new DevExpress.XtraEditors.SimpleButton();
            this.btExit = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gold;
            this.labelControl1.Location = new System.Drawing.Point(127, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(247, 35);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "You are Winner !";
            // 
            // lbTime
            // 
            this.lbTime.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Appearance.ForeColor = System.Drawing.Color.Gold;
            this.lbTime.Location = new System.Drawing.Point(148, 150);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(204, 35);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Time: 0:00:00";
            // 
            // btPlay
            // 
            this.btPlay.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btPlay.Appearance.Options.UseFont = true;
            this.btPlay.Location = new System.Drawing.Point(63, 205);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(174, 33);
            this.btPlay.TabIndex = 4;
            this.btPlay.Text = "Play again";
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btExit
            // 
            this.btExit.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExit.Appearance.Options.UseFont = true;
            this.btExit.Location = new System.Drawing.Point(263, 205);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(174, 33);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Minesweeper.Properties.Resources.congratulation;
            this.pictureBox2.Location = new System.Drawing.Point(84, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(443, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Minesweeper.Properties.Resources.win;
            this.pictureBox1.Location = new System.Drawing.Point(0, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 267);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinnerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinnerForm";
            this.Load += new System.EventHandler(this.WinnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl lbTime;
        private DevExpress.XtraEditors.SimpleButton btPlay;
        private DevExpress.XtraEditors.SimpleButton btExit;
    }
}