namespace Photon.OpenGl
{
    partial class UctOrbitVibrate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tlp = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Button();
            this.NudRadius = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NudCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbVibrateBy = new System.Windows.Forms.ComboBox();
            this.Cdi = new System.Windows.Forms.ColorDialog();
            this.Tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // Tlp
            // 
            this.Tlp.AutoSize = true;
            this.Tlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tlp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Tlp.ColumnCount = 2;
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Tlp.Controls.Add(this.label4, 0, 0);
            this.Tlp.Controls.Add(this.BtnShow, 1, 4);
            this.Tlp.Controls.Add(this.NudRadius, 1, 1);
            this.Tlp.Controls.Add(this.label3, 0, 1);
            this.Tlp.Controls.Add(this.label9, 0, 2);
            this.Tlp.Controls.Add(this.NudCount, 1, 2);
            this.Tlp.Controls.Add(this.label1, 0, 3);
            this.Tlp.Controls.Add(this.CmbVibrateBy, 1, 3);
            this.Tlp.Location = new System.Drawing.Point(0, 0);
            this.Tlp.Margin = new System.Windows.Forms.Padding(0);
            this.Tlp.Name = "Tlp";
            this.Tlp.RowCount = 5;
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp.Size = new System.Drawing.Size(223, 140);
            this.Tlp.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.Tlp.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 22);
            this.label4.TabIndex = 73;
            this.label4.Text = "Orbit vibrate";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnShow
            // 
            this.BtnShow.AutoSize = true;
            this.BtnShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnShow.Location = new System.Drawing.Point(75, 112);
            this.BtnShow.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(46, 25);
            this.BtnShow.TabIndex = 1;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // NudRadius
            // 
            this.NudRadius.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NudRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudRadius.DecimalPlaces = 14;
            this.NudRadius.Dock = System.Windows.Forms.DockStyle.Top;
            this.NudRadius.Location = new System.Drawing.Point(75, 27);
            this.NudRadius.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            917504});
            this.NudRadius.Name = "NudRadius";
            this.NudRadius.Size = new System.Drawing.Size(144, 23);
            this.NudRadius.TabIndex = 57;
            this.NudRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(4, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "radius";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(4, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "count";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NudCount
            // 
            this.NudCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NudCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.NudCount.Location = new System.Drawing.Point(75, 56);
            this.NudCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCount.Name = "NudCount";
            this.NudCount.Size = new System.Drawing.Size(144, 23);
            this.NudCount.TabIndex = 40;
            this.NudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(4, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "vibrate by";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbVibrateBy
            // 
            this.CmbVibrateBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbVibrateBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVibrateBy.FormattingEnabled = true;
            this.CmbVibrateBy.Items.AddRange(new object[] {
            "Sphere",
            "Random sphere",
            "Spherical shell",
            "Random spherical shell"});
            this.CmbVibrateBy.Location = new System.Drawing.Point(75, 85);
            this.CmbVibrateBy.Name = "CmbVibrateBy";
            this.CmbVibrateBy.Size = new System.Drawing.Size(144, 23);
            this.CmbVibrateBy.TabIndex = 58;
            // 
            // UctOrbitVibrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.Tlp);
            this.Name = "UctOrbitVibrate";
            this.Size = new System.Drawing.Size(223, 140);
            this.Tlp.ResumeLayout(false);
            this.Tlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel Tlp;
        private Label label9;
        private Label label1;
        private Button BtnShow;
        private ColorDialog Cdi;
        private Label label3;
        public NumericUpDown NudCount;
        public NumericUpDown NudRadius;
        public ComboBox CmbVibrateBy;
        private Label label4;
    }
}
