namespace Minesweeper
{
    partial class OptionForm
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.selectMode = new DevExpress.XtraEditors.TrackBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.numWidth = new DevExpress.XtraEditors.SpinEdit();
            this.numHeight = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btOK = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.selectMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // selectMode
            // 
            this.selectMode.EditValue = 20;
            this.selectMode.Location = new System.Drawing.Point(12, 31);
            this.selectMode.Name = "selectMode";
            this.selectMode.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.selectMode.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "Easy";
            trackBarLabel1.Value = 10;
            trackBarLabel2.Label = "Medium";
            trackBarLabel2.Value = 45;
            trackBarLabel3.Label = "Hard";
            trackBarLabel3.Value = 80;
            this.selectMode.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3});
            this.selectMode.Properties.Maximum = 80;
            this.selectMode.Properties.Minimum = 10;
            this.selectMode.Properties.ShowLabels = true;
            this.selectMode.Size = new System.Drawing.Size(492, 72);
            this.selectMode.TabIndex = 0;
            this.selectMode.Value = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Location = new System.Drawing.Point(10, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Width:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Location = new System.Drawing.Point(204, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Height:";
            // 
            // numWidth
            // 
            this.numWidth.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWidth.Location = new System.Drawing.Point(59, 86);
            this.numWidth.Name = "numWidth";
            this.numWidth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numWidth.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWidth.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWidth.Size = new System.Drawing.Size(100, 20);
            this.numWidth.TabIndex = 4;
            // 
            // numHeight
            // 
            this.numHeight.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHeight.Location = new System.Drawing.Point(257, 87);
            this.numHeight.Name = "numHeight";
            this.numHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numHeight.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeight.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHeight.Size = new System.Drawing.Size(100, 20);
            this.numHeight.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Location = new System.Drawing.Point(12, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Mode:";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(176, 135);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 7;
            this.btOK.Text = "OK";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(257, 136);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 171);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.selectMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Option";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TrackBarControl selectMode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit numWidth;
        private DevExpress.XtraEditors.SpinEdit numHeight;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btOK;
        private DevExpress.XtraEditors.SimpleButton btCancel;
    }
}