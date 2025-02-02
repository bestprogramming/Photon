﻿namespace Photon.OpenGl
{
    partial class UctDisc
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
            components = new System.ComponentModel.Container();
            Tlp = new TableLayoutPanel();
            NudR = new NumericUpDown();
            label5 = new Label();
            CmbCount = new ComboBox();
            LblCount = new Label();
            FlpRotateVibrate = new FlowLayoutPanel();
            ChbRotate = new CheckBox();
            ChbCloneVibrate = new CheckBox();
            ChbOrbitVibrate = new CheckBox();
            panel1 = new Panel();
            LblWeight = new Label();
            PnlWeight = new Panel();
            BtnShow = new Button();
            label3 = new Label();
            label2 = new Label();
            NudZ = new NumericUpDown();
            label9 = new Label();
            NudX = new NumericUpDown();
            label1 = new Label();
            NudY = new NumericUpDown();
            label4 = new Label();
            Flp = new FlowLayoutPanel();
            Tlt = new ToolTip(components);
            Tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudR).BeginInit();
            FlpRotateVibrate.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudY).BeginInit();
            Flp.SuspendLayout();
            SuspendLayout();
            // 
            // Tlp
            // 
            Tlp.AutoSize = true;
            Tlp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Tlp.ColumnCount = 2;
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            Tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            Tlp.Controls.Add(NudR, 1, 4);
            Tlp.Controls.Add(label5, 0, 4);
            Tlp.Controls.Add(CmbCount, 1, 5);
            Tlp.Controls.Add(LblCount, 0, 5);
            Tlp.Controls.Add(FlpRotateVibrate, 0, 7);
            Tlp.Controls.Add(panel1, 1, 6);
            Tlp.Controls.Add(BtnShow, 1, 8);
            Tlp.Controls.Add(label3, 0, 6);
            Tlp.Controls.Add(label2, 0, 3);
            Tlp.Controls.Add(NudZ, 1, 3);
            Tlp.Controls.Add(label9, 0, 1);
            Tlp.Controls.Add(NudX, 1, 1);
            Tlp.Controls.Add(label1, 0, 2);
            Tlp.Controls.Add(NudY, 1, 2);
            Tlp.Controls.Add(label4, 0, 0);
            Tlp.Location = new System.Drawing.Point(3, 3);
            Tlp.Name = "Tlp";
            Tlp.RowCount = 9;
            Tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            Tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tlp.Size = new Size(303, 256);
            Tlp.TabIndex = 0;
            // 
            // NudR
            // 
            NudR.BackColor = Color.WhiteSmoke;
            NudR.BorderStyle = BorderStyle.FixedSingle;
            NudR.DecimalPlaces = 14;
            NudR.Dock = DockStyle.Top;
            NudR.Location = new System.Drawing.Point(105, 114);
            NudR.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudR.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudR.Name = "NudR";
            NudR.Size = new Size(194, 23);
            NudR.TabIndex = 76;
            NudR.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new System.Drawing.Point(4, 117);
            label5.Margin = new Padding(3, 6, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 75;
            label5.Text = "r";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CmbCount
            // 
            CmbCount.Dock = DockStyle.Top;
            CmbCount.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCount.FormattingEnabled = true;
            CmbCount.Location = new System.Drawing.Point(105, 143);
            CmbCount.Name = "CmbCount";
            CmbCount.Size = new Size(194, 23);
            CmbCount.TabIndex = 74;
            // 
            // LblCount
            // 
            LblCount.AutoSize = true;
            LblCount.Dock = DockStyle.Top;
            LblCount.Location = new System.Drawing.Point(4, 146);
            LblCount.Margin = new Padding(3, 6, 3, 0);
            LblCount.Name = "LblCount";
            LblCount.Size = new Size(94, 15);
            LblCount.TabIndex = 73;
            LblCount.Text = "count";
            LblCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FlpRotateVibrate
            // 
            FlpRotateVibrate.AutoSize = true;
            FlpRotateVibrate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tlp.SetColumnSpan(FlpRotateVibrate, 2);
            FlpRotateVibrate.Controls.Add(ChbRotate);
            FlpRotateVibrate.Controls.Add(ChbCloneVibrate);
            FlpRotateVibrate.Controls.Add(ChbOrbitVibrate);
            FlpRotateVibrate.Dock = DockStyle.Fill;
            FlpRotateVibrate.Location = new System.Drawing.Point(1, 198);
            FlpRotateVibrate.Margin = new Padding(0);
            FlpRotateVibrate.Name = "FlpRotateVibrate";
            FlpRotateVibrate.Size = new Size(301, 28);
            FlpRotateVibrate.TabIndex = 71;
            // 
            // ChbRotate
            // 
            ChbRotate.AutoSize = true;
            ChbRotate.Location = new System.Drawing.Point(20, 4);
            ChbRotate.Margin = new Padding(20, 4, 3, 2);
            ChbRotate.Name = "ChbRotate";
            ChbRotate.Size = new Size(60, 19);
            ChbRotate.TabIndex = 69;
            ChbRotate.Text = "Rotate";
            ChbRotate.UseVisualStyleBackColor = true;
            ChbRotate.CheckedChanged += ChbRotate_CheckedChanged;
            // 
            // ChbCloneVibrate
            // 
            ChbCloneVibrate.AutoSize = true;
            ChbCloneVibrate.Location = new System.Drawing.Point(88, 4);
            ChbCloneVibrate.Margin = new Padding(5, 4, 3, 2);
            ChbCloneVibrate.Name = "ChbCloneVibrate";
            ChbCloneVibrate.Size = new Size(96, 19);
            ChbCloneVibrate.TabIndex = 70;
            ChbCloneVibrate.Text = "Clone vibrate";
            ChbCloneVibrate.UseVisualStyleBackColor = true;
            ChbCloneVibrate.CheckedChanged += ChbCloneVibrate_CheckedChanged;
            // 
            // ChbOrbitVibrate
            // 
            ChbOrbitVibrate.AutoSize = true;
            ChbOrbitVibrate.Location = new System.Drawing.Point(192, 4);
            ChbOrbitVibrate.Margin = new Padding(5, 4, 3, 2);
            ChbOrbitVibrate.Name = "ChbOrbitVibrate";
            ChbOrbitVibrate.Size = new Size(92, 19);
            ChbOrbitVibrate.TabIndex = 72;
            ChbOrbitVibrate.Text = "Orbit vibrate";
            ChbOrbitVibrate.UseVisualStyleBackColor = true;
            ChbOrbitVibrate.CheckedChanged += ChbOrbitVibrate_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(LblWeight);
            panel1.Controls.Add(PnlWeight);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(105, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 22);
            panel1.TabIndex = 49;
            // 
            // LblWeight
            // 
            LblWeight.AutoSize = true;
            LblWeight.Location = new System.Drawing.Point(25, 3);
            LblWeight.Name = "LblWeight";
            LblWeight.Size = new Size(13, 15);
            LblWeight.TabIndex = 2;
            LblWeight.Text = "1";
            // 
            // PnlWeight
            // 
            PnlWeight.BackColor = Color.White;
            PnlWeight.Cursor = Cursors.Hand;
            PnlWeight.Location = new System.Drawing.Point(0, 0);
            PnlWeight.Name = "PnlWeight";
            PnlWeight.Size = new Size(20, 20);
            PnlWeight.TabIndex = 48;
            PnlWeight.Tag = "";
            PnlWeight.Click += PnlWeight_Click;
            // 
            // BtnShow
            // 
            BtnShow.AutoSize = true;
            BtnShow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnShow.Location = new System.Drawing.Point(105, 228);
            BtnShow.Margin = new Padding(3, 1, 3, 1);
            BtnShow.Name = "BtnShow";
            BtnShow.Size = new Size(121, 25);
            BtnShow.TabIndex = 1;
            BtnShow.Text = "Show (vertices: 127)";
            BtnShow.UseVisualStyleBackColor = true;
            BtnShow.Click += BtnShow_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new System.Drawing.Point(4, 175);
            label3.Margin = new Padding(3, 6, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 49;
            label3.Text = "weight";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new System.Drawing.Point(4, 88);
            label2.Margin = new Padding(3, 6, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 44;
            label2.Text = "z";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NudZ
            // 
            NudZ.BackColor = Color.WhiteSmoke;
            NudZ.BorderStyle = BorderStyle.FixedSingle;
            NudZ.DecimalPlaces = 14;
            NudZ.Dock = DockStyle.Top;
            NudZ.Location = new System.Drawing.Point(105, 85);
            NudZ.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudZ.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudZ.Name = "NudZ";
            NudZ.Size = new Size(194, 23);
            NudZ.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Location = new System.Drawing.Point(4, 30);
            label9.Margin = new Padding(3, 6, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 39;
            label9.Text = "x";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NudX
            // 
            NudX.BackColor = Color.WhiteSmoke;
            NudX.BorderStyle = BorderStyle.FixedSingle;
            NudX.DecimalPlaces = 14;
            NudX.Dock = DockStyle.Top;
            NudX.Location = new System.Drawing.Point(105, 27);
            NudX.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudX.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudX.Name = "NudX";
            NudX.Size = new Size(194, 23);
            NudX.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new System.Drawing.Point(4, 59);
            label1.Margin = new Padding(3, 6, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 41;
            label1.Text = "y";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NudY
            // 
            NudY.BackColor = Color.WhiteSmoke;
            NudY.BorderStyle = BorderStyle.FixedSingle;
            NudY.DecimalPlaces = 14;
            NudY.Dock = DockStyle.Top;
            NudY.Location = new System.Drawing.Point(105, 56);
            NudY.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudY.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudY.Name = "NudY";
            NudY.Size = new Size(194, 23);
            NudY.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            Tlp.SetColumnSpan(label4, 2);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(4, 1);
            label4.Name = "label4";
            label4.Size = new Size(295, 22);
            label4.TabIndex = 72;
            label4.Text = "Disc";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Flp
            // 
            Flp.AutoSize = true;
            Flp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Flp.Controls.Add(Tlp);
            Flp.Location = new System.Drawing.Point(0, 0);
            Flp.Margin = new Padding(0);
            Flp.Name = "Flp";
            Flp.Size = new Size(309, 262);
            Flp.TabIndex = 1;
            // 
            // UctDisc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(Flp);
            Margin = new Padding(0);
            Name = "UctDisc";
            Size = new Size(309, 262);
            Tlp.ResumeLayout(false);
            Tlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudR).EndInit();
            FlpRotateVibrate.ResumeLayout(false);
            FlpRotateVibrate.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudX).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudY).EndInit();
            Flp.ResumeLayout(false);
            Flp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        public NumericUpDown NudR;
        private Label label5;
        public ComboBox CmbCount;
        private Label LblCount;
        private ToolTip Tlt;
    }
}
