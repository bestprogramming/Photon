namespace Photon.OpenGl
{
    partial class UctPoint
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
            this.FlpRotateVibrate = new System.Windows.Forms.FlowLayoutPanel();
            this.ChbRotate = new System.Windows.Forms.CheckBox();
            this.ChbCloneVibrate = new System.Windows.Forms.CheckBox();
            this.ChbOrbitVibrate = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblWeight = new System.Windows.Forms.Label();
            this.PnlWeight = new System.Windows.Forms.Panel();
            this.BtnShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NudZ = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.NudX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NudY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.Tlp.SuspendLayout();
            this.FlpRotateVibrate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).BeginInit();
            this.Flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp
            // 
            this.Tlp.AutoSize = true;
            this.Tlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tlp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Tlp.ColumnCount = 2;
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.Tlp.Controls.Add(this.FlpRotateVibrate, 0, 5);
            this.Tlp.Controls.Add(this.panel1, 1, 4);
            this.Tlp.Controls.Add(this.BtnShow, 1, 6);
            this.Tlp.Controls.Add(this.label3, 0, 4);
            this.Tlp.Controls.Add(this.label2, 0, 3);
            this.Tlp.Controls.Add(this.NudZ, 1, 3);
            this.Tlp.Controls.Add(this.label9, 0, 1);
            this.Tlp.Controls.Add(this.NudX, 1, 1);
            this.Tlp.Controls.Add(this.label1, 0, 2);
            this.Tlp.Controls.Add(this.NudY, 1, 2);
            this.Tlp.Controls.Add(this.label4, 0, 0);
            this.Tlp.Location = new System.Drawing.Point(3, 3);
            this.Tlp.Name = "Tlp";
            this.Tlp.RowCount = 7;
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Tlp.Size = new System.Drawing.Size(303, 198);
            this.Tlp.TabIndex = 0;
            // 
            // FlpRotateVibrate
            // 
            this.FlpRotateVibrate.AutoSize = true;
            this.FlpRotateVibrate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tlp.SetColumnSpan(this.FlpRotateVibrate, 2);
            this.FlpRotateVibrate.Controls.Add(this.ChbRotate);
            this.FlpRotateVibrate.Controls.Add(this.ChbCloneVibrate);
            this.FlpRotateVibrate.Controls.Add(this.ChbOrbitVibrate);
            this.FlpRotateVibrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpRotateVibrate.Location = new System.Drawing.Point(1, 140);
            this.FlpRotateVibrate.Margin = new System.Windows.Forms.Padding(0);
            this.FlpRotateVibrate.Name = "FlpRotateVibrate";
            this.FlpRotateVibrate.Size = new System.Drawing.Size(301, 28);
            this.FlpRotateVibrate.TabIndex = 71;
            // 
            // ChbRotate
            // 
            this.ChbRotate.AutoSize = true;
            this.ChbRotate.Location = new System.Drawing.Point(20, 4);
            this.ChbRotate.Margin = new System.Windows.Forms.Padding(20, 4, 3, 2);
            this.ChbRotate.Name = "ChbRotate";
            this.ChbRotate.Size = new System.Drawing.Size(60, 19);
            this.ChbRotate.TabIndex = 69;
            this.ChbRotate.Text = "Rotate";
            this.ChbRotate.UseVisualStyleBackColor = true;
            this.ChbRotate.CheckedChanged += new System.EventHandler(this.ChbRotate_CheckedChanged);
            // 
            // ChbCloneVibrate
            // 
            this.ChbCloneVibrate.AutoSize = true;
            this.ChbCloneVibrate.Location = new System.Drawing.Point(88, 4);
            this.ChbCloneVibrate.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.ChbCloneVibrate.Name = "ChbCloneVibrate";
            this.ChbCloneVibrate.Size = new System.Drawing.Size(96, 19);
            this.ChbCloneVibrate.TabIndex = 70;
            this.ChbCloneVibrate.Text = "Clone vibrate";
            this.ChbCloneVibrate.UseVisualStyleBackColor = true;
            this.ChbCloneVibrate.CheckedChanged += new System.EventHandler(this.ChbCloneVibrate_CheckedChanged);
            // 
            // ChbOrbitVibrate
            // 
            this.ChbOrbitVibrate.AutoSize = true;
            this.ChbOrbitVibrate.Location = new System.Drawing.Point(192, 4);
            this.ChbOrbitVibrate.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.ChbOrbitVibrate.Name = "ChbOrbitVibrate";
            this.ChbOrbitVibrate.Size = new System.Drawing.Size(92, 19);
            this.ChbOrbitVibrate.TabIndex = 72;
            this.ChbOrbitVibrate.Text = "Orbit vibrate";
            this.ChbOrbitVibrate.UseVisualStyleBackColor = true;
            this.ChbOrbitVibrate.CheckedChanged += new System.EventHandler(this.ChbOrbitVibrate_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblWeight);
            this.panel1.Controls.Add(this.PnlWeight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(105, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 22);
            this.panel1.TabIndex = 49;
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Location = new System.Drawing.Point(25, 3);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(13, 15);
            this.LblWeight.TabIndex = 2;
            this.LblWeight.Text = "1";
            // 
            // PnlWeight
            // 
            this.PnlWeight.BackColor = System.Drawing.Color.White;
            this.PnlWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlWeight.Location = new System.Drawing.Point(0, 0);
            this.PnlWeight.Name = "PnlWeight";
            this.PnlWeight.Size = new System.Drawing.Size(20, 20);
            this.PnlWeight.TabIndex = 48;
            this.PnlWeight.Tag = "";
            this.PnlWeight.Click += new System.EventHandler(this.PnlWeight_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.AutoSize = true;
            this.BtnShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnShow.Location = new System.Drawing.Point(105, 170);
            this.BtnShow.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(109, 25);
            this.BtnShow.TabIndex = 1;
            this.BtnShow.Text = "Show (vertices: 1)";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "weight";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "z";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NudZ
            // 
            this.NudZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NudZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudZ.DecimalPlaces = 14;
            this.NudZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.NudZ.Location = new System.Drawing.Point(105, 85);
            this.NudZ.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudZ.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.NudZ.Name = "NudZ";
            this.NudZ.Size = new System.Drawing.Size(194, 23);
            this.NudZ.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(4, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "x";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NudX
            // 
            this.NudX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NudX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudX.DecimalPlaces = 14;
            this.NudX.Dock = System.Windows.Forms.DockStyle.Top;
            this.NudX.Location = new System.Drawing.Point(105, 27);
            this.NudX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.NudX.Name = "NudX";
            this.NudX.Size = new System.Drawing.Size(194, 23);
            this.NudX.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "y";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NudY
            // 
            this.NudY.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NudY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudY.DecimalPlaces = 14;
            this.NudY.Dock = System.Windows.Forms.DockStyle.Top;
            this.NudY.Location = new System.Drawing.Point(105, 56);
            this.NudY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.NudY.Name = "NudY";
            this.NudY.Size = new System.Drawing.Size(194, 23);
            this.NudY.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.Tlp.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 22);
            this.label4.TabIndex = 72;
            this.label4.Text = "Point";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Flp
            // 
            this.Flp.AutoSize = true;
            this.Flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Flp.Controls.Add(this.Tlp);
            this.Flp.Location = new System.Drawing.Point(0, 0);
            this.Flp.Margin = new System.Windows.Forms.Padding(0);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(309, 204);
            this.Flp.TabIndex = 1;
            // 
            // UctPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.Flp);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UctPoint";
            this.Size = new System.Drawing.Size(309, 204);
            this.Tlp.ResumeLayout(false);
            this.Tlp.PerformLayout();
            this.FlpRotateVibrate.ResumeLayout(false);
            this.FlpRotateVibrate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).EndInit();
            this.Flp.ResumeLayout(false);
            this.Flp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel Tlp;
        private Label label9;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button BtnShow;
        private Label LblWeight;
        private Panel panel1;
        public NumericUpDown NudZ;
        public NumericUpDown NudX;
        public NumericUpDown NudY;
        public Panel PnlWeight;
        public CheckBox ChbRotate;
        private FlowLayoutPanel FlpRotateVibrate;
        public CheckBox ChbCloneVibrate;
        private FlowLayoutPanel Flp;
        public CheckBox ChbOrbitVibrate;
        private Label label4;
    }
}
