namespace Photon.TestIntersection
{
    partial class FrmEllipseAndTangentEllipse
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
            NudEa1 = new NumericUpDown();
            label3 = new Label();
            NudEx1 = new NumericUpDown();
            label2 = new Label();
            NudEy1 = new NumericUpDown();
            label1 = new Label();
            PnlFill = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label5 = new Label();
            NudEx2 = new NumericUpDown();
            label6 = new Label();
            NudEy2 = new NumericUpDown();
            label7 = new Label();
            NudEa2 = new NumericUpDown();
            label8 = new Label();
            NudEb2 = new NumericUpDown();
            label11 = new Label();
            NudRotate2 = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label9 = new Label();
            NudEb1 = new NumericUpDown();
            label10 = new Label();
            NudRotate1 = new NumericUpDown();
            ChbNearest = new CheckBox();
            Mns = new MenuStrip();
            SmiFileMenu = new ToolStripMenuItem();
            SmiSave = new ToolStripMenuItem();
            SmiLoad = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            SmiInc = new ToolStripMenuItem();
            SmiPackingMenu = new ToolStripMenuItem();
            SmiPackingCirclesInACircle = new ToolStripMenuItem();
            SmiPackingCirclesInASquare = new ToolStripMenuItem();
            SmiPackingCirclesInARectangle = new ToolStripMenuItem();
            SmiAlgebraMenu = new ToolStripMenuItem();
            SmiQuadratic = new ToolStripMenuItem();
            SmiCubic = new ToolStripMenuItem();
            SmiQuartic = new ToolStripMenuItem();
            SmiSegmentMenu = new ToolStripMenuItem();
            SmiTwoSegments = new ToolStripMenuItem();
            SmiCircleMenu = new ToolStripMenuItem();
            SmiCircleAndSegment = new ToolStripMenuItem();
            SmiTwoCircles = new ToolStripMenuItem();
            SmiEllipseMenu = new ToolStripMenuItem();
            SmiEllipseAndTangentLine = new ToolStripMenuItem();
            SmiEllipseAndSegment = new ToolStripMenuItem();
            SmiEllipseAndTangentCircle = new ToolStripMenuItem();
            SmiEllipseAndCircle = new ToolStripMenuItem();
            SmiEllipseAndTangentEllipse = new ToolStripMenuItem();
            SmiTwoEllipses = new ToolStripMenuItem();
            SmiOpenGlMenu = new ToolStripMenuItem();
            SmiOpenGl = new ToolStripMenuItem();
            SmiTwoCircle3Projections = new ToolStripMenuItem();
            SmiOrbitMenu = new ToolStripMenuItem();
            SmiFlatScreen = new ToolStripMenuItem();
            SmiFlatScreenVector = new ToolStripMenuItem();
            SmiSphericalScreen = new ToolStripMenuItem();
            SmiSphericalScreenVector = new ToolStripMenuItem();
            SmiSpace = new ToolStripMenuItem();
            SmiSpaceVector = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)NudEa1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudEx1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudEy1).BeginInit();
            PnlFill.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudEx2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudEy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudEa2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudEb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudRotate2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudEb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudRotate1).BeginInit();
            Mns.SuspendLayout();
            SuspendLayout();
            // 
            // NudEa1
            // 
            NudEa1.BackColor = Color.WhiteSmoke;
            NudEa1.DecimalPlaces = 14;
            NudEa1.Location = new System.Drawing.Point(388, 3);
            NudEa1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudEa1.Name = "NudEa1";
            NudEa1.Size = new Size(140, 23);
            NudEa1.TabIndex = 16;
            NudEa1.Value = new decimal(new int[] { 300, 0, 0, 0 });
            NudEa1.ValueChanged += FormSetting_Changed;
            NudEa1.Click += NudInc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(357, 6);
            label3.Margin = new Padding(3, 6, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 15;
            label3.Text = "ea1";
            // 
            // NudEx1
            // 
            NudEx1.BackColor = Color.WhiteSmoke;
            NudEx1.DecimalPlaces = 14;
            NudEx1.Location = new System.Drawing.Point(34, 3);
            NudEx1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudEx1.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudEx1.Name = "NudEx1";
            NudEx1.Size = new Size(140, 23);
            NudEx1.TabIndex = 14;
            NudEx1.ValueChanged += FormSetting_Changed;
            NudEx1.Click += NudInc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(180, 6);
            label2.Margin = new Padding(3, 6, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 13;
            label2.Text = "ey1";
            // 
            // NudEy1
            // 
            NudEy1.BackColor = Color.WhiteSmoke;
            NudEy1.DecimalPlaces = 14;
            NudEy1.Location = new System.Drawing.Point(211, 3);
            NudEy1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudEy1.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudEy1.Name = "NudEy1";
            NudEy1.Size = new Size(140, 23);
            NudEy1.TabIndex = 12;
            NudEy1.ValueChanged += FormSetting_Changed;
            NudEy1.Click += NudInc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 6);
            label1.Margin = new Padding(3, 6, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 4;
            label1.Text = "ex1";
            // 
            // PnlFill
            // 
            PnlFill.BackColor = Color.LightGray;
            PnlFill.Controls.Add(flowLayoutPanel2);
            PnlFill.Controls.Add(flowLayoutPanel1);
            PnlFill.Controls.Add(Mns);
            PnlFill.Dock = DockStyle.Fill;
            PnlFill.Location = new System.Drawing.Point(0, 0);
            PnlFill.Name = "PnlFill";
            PnlFill.Size = new Size(1278, 553);
            PnlFill.TabIndex = 4;
            PnlFill.Paint += PnlFill_Paint;
            PnlFill.MouseDown += PnlFill_MouseDown;
            PnlFill.MouseMove += PnlFill_MouseMove;
            PnlFill.MouseUp += PnlFill_MouseUp;
            PnlFill.PreviewKeyDown += PnlFill_PreviewKeyDown;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(NudEx2);
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(NudEy2);
            flowLayoutPanel2.Controls.Add(label7);
            flowLayoutPanel2.Controls.Add(NudEa2);
            flowLayoutPanel2.Controls.Add(label8);
            flowLayoutPanel2.Controls.Add(NudEb2);
            flowLayoutPanel2.Controls.Add(label11);
            flowLayoutPanel2.Controls.Add(NudRotate2);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 53);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1278, 29);
            flowLayoutPanel2.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 6);
            label5.Margin = new Padding(3, 6, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 21;
            label5.Text = "ex2";
            // 
            // NudEx2
            // 
            NudEx2.BackColor = Color.WhiteSmoke;
            NudEx2.DecimalPlaces = 14;
            NudEx2.Location = new System.Drawing.Point(34, 3);
            NudEx2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudEx2.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudEx2.Name = "NudEx2";
            NudEx2.Size = new Size(140, 23);
            NudEx2.TabIndex = 24;
            NudEx2.ValueChanged += FormSetting_Changed;
            NudEx2.Click += NudInc_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(180, 6);
            label6.Margin = new Padding(3, 6, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 23;
            label6.Text = "ey2";
            // 
            // NudEy2
            // 
            NudEy2.BackColor = Color.WhiteSmoke;
            NudEy2.DecimalPlaces = 14;
            NudEy2.Location = new System.Drawing.Point(211, 3);
            NudEy2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudEy2.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudEy2.Name = "NudEy2";
            NudEy2.Size = new Size(140, 23);
            NudEy2.TabIndex = 22;
            NudEy2.ValueChanged += FormSetting_Changed;
            NudEy2.Click += NudInc_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(357, 6);
            label7.Margin = new Padding(3, 6, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 42;
            label7.Text = "ea2";
            // 
            // NudEa2
            // 
            NudEa2.BackColor = Color.WhiteSmoke;
            NudEa2.DecimalPlaces = 14;
            NudEa2.Location = new System.Drawing.Point(388, 3);
            NudEa2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudEa2.Name = "NudEa2";
            NudEa2.Size = new Size(140, 23);
            NudEa2.TabIndex = 43;
            NudEa2.Value = new decimal(new int[] { 100, 0, 0, 0 });
            NudEa2.ValueChanged += FormSetting_Changed;
            NudEa2.Click += NudInc_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(534, 6);
            label8.Margin = new Padding(3, 6, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 44;
            label8.Text = "eb2";
            // 
            // NudEb2
            // 
            NudEb2.BackColor = Color.WhiteSmoke;
            NudEb2.DecimalPlaces = 14;
            NudEb2.Location = new System.Drawing.Point(566, 3);
            NudEb2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudEb2.Name = "NudEb2";
            NudEb2.Size = new Size(140, 23);
            NudEb2.TabIndex = 45;
            NudEb2.Value = new decimal(new int[] { 50, 0, 0, 0 });
            NudEb2.ValueChanged += FormSetting_Changed;
            NudEb2.Click += NudInc_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(712, 6);
            label11.Margin = new Padding(3, 6, 3, 0);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 46;
            label11.Text = "rotate2";
            // 
            // NudRotate2
            // 
            NudRotate2.BackColor = Color.WhiteSmoke;
            NudRotate2.DecimalPlaces = 14;
            NudRotate2.Location = new System.Drawing.Point(762, 3);
            NudRotate2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudRotate2.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudRotate2.Name = "NudRotate2";
            NudRotate2.Size = new Size(140, 23);
            NudRotate2.TabIndex = 47;
            NudRotate2.ValueChanged += FormSetting_Changed;
            NudRotate2.Click += NudInc_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(NudEx1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(NudEy1);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(NudEa1);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(NudEb1);
            flowLayoutPanel1.Controls.Add(label10);
            flowLayoutPanel1.Controls.Add(NudRotate1);
            flowLayoutPanel1.Controls.Add(ChbNearest);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1278, 29);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(534, 6);
            label9.Margin = new Padding(3, 6, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 37;
            label9.Text = "eb1";
            // 
            // NudEb1
            // 
            NudEb1.BackColor = Color.WhiteSmoke;
            NudEb1.DecimalPlaces = 14;
            NudEb1.Location = new System.Drawing.Point(566, 3);
            NudEb1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudEb1.Name = "NudEb1";
            NudEb1.Size = new Size(140, 23);
            NudEb1.TabIndex = 39;
            NudEb1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            NudEb1.ValueChanged += FormSetting_Changed;
            NudEb1.Click += NudInc_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(712, 6);
            label10.Margin = new Padding(3, 6, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 38;
            label10.Text = "rotate1";
            // 
            // NudRotate1
            // 
            NudRotate1.BackColor = Color.WhiteSmoke;
            NudRotate1.DecimalPlaces = 14;
            NudRotate1.Location = new System.Drawing.Point(762, 3);
            NudRotate1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudRotate1.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudRotate1.Name = "NudRotate1";
            NudRotate1.Size = new Size(140, 23);
            NudRotate1.TabIndex = 40;
            NudRotate1.ValueChanged += FormSetting_Changed;
            NudRotate1.Click += NudInc_Click;
            // 
            // ChbNearest
            // 
            ChbNearest.AutoSize = true;
            ChbNearest.Location = new System.Drawing.Point(908, 6);
            ChbNearest.Margin = new Padding(3, 6, 3, 0);
            ChbNearest.Name = "ChbNearest";
            ChbNearest.Size = new Size(66, 19);
            ChbNearest.TabIndex = 41;
            ChbNearest.Text = "Nearest";
            ChbNearest.UseVisualStyleBackColor = true;
            ChbNearest.CheckedChanged += FormSetting_Changed;
            // 
            // Mns
            // 
            Mns.Items.AddRange(new ToolStripItem[] { SmiFileMenu, SmiPackingMenu, SmiAlgebraMenu, SmiSegmentMenu, SmiCircleMenu, SmiEllipseMenu, SmiOpenGlMenu, SmiOrbitMenu });
            Mns.Location = new System.Drawing.Point(0, 0);
            Mns.Name = "Mns";
            Mns.Size = new Size(1278, 24);
            Mns.TabIndex = 47;
            Mns.Text = "menuStrip1";
            // 
            // SmiFileMenu
            // 
            SmiFileMenu.DropDownItems.AddRange(new ToolStripItem[] { SmiSave, SmiLoad, toolStripMenuItem1, SmiInc });
            SmiFileMenu.Name = "SmiFileMenu";
            SmiFileMenu.Size = new Size(37, 20);
            SmiFileMenu.Text = "File";
            // 
            // SmiSave
            // 
            SmiSave.Name = "SmiSave";
            SmiSave.Size = new Size(180, 22);
            SmiSave.Text = "Save";
            SmiSave.Click += Smi_Click;
            // 
            // SmiLoad
            // 
            SmiLoad.Name = "SmiLoad";
            SmiLoad.Size = new Size(180, 22);
            SmiLoad.Text = "Load";
            SmiLoad.Click += Smi_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // SmiInc
            // 
            SmiInc.Name = "SmiInc";
            SmiInc.Size = new Size(180, 22);
            SmiInc.Text = "Inc";
            SmiInc.Click += Smi_Click;
            // 
            // SmiPackingMenu
            // 
            SmiPackingMenu.DropDownItems.AddRange(new ToolStripItem[] { SmiPackingCirclesInACircle, SmiPackingCirclesInASquare, SmiPackingCirclesInARectangle });
            SmiPackingMenu.Name = "SmiPackingMenu";
            SmiPackingMenu.Size = new Size(61, 20);
            SmiPackingMenu.Text = "Packing";
            // 
            // SmiPackingCirclesInACircle
            // 
            SmiPackingCirclesInACircle.Name = "SmiPackingCirclesInACircle";
            SmiPackingCirclesInACircle.Size = new Size(183, 22);
            SmiPackingCirclesInACircle.Tag = "";
            SmiPackingCirclesInACircle.Text = "Circles in a circle";
            SmiPackingCirclesInACircle.Click += Smi_Click;
            // 
            // SmiPackingCirclesInASquare
            // 
            SmiPackingCirclesInASquare.Name = "SmiPackingCirclesInASquare";
            SmiPackingCirclesInASquare.Size = new Size(183, 22);
            SmiPackingCirclesInASquare.Text = "Circles in a square";
            SmiPackingCirclesInASquare.Click += Smi_Click;
            // 
            // SmiPackingCirclesInARectangle
            // 
            SmiPackingCirclesInARectangle.Name = "SmiPackingCirclesInARectangle";
            SmiPackingCirclesInARectangle.Size = new Size(183, 22);
            SmiPackingCirclesInARectangle.Text = "Circles in a rectangle";
            SmiPackingCirclesInARectangle.Click += Smi_Click;
            // 
            // SmiAlgebraMenu
            // 
            SmiAlgebraMenu.DropDownItems.AddRange(new ToolStripItem[] { SmiQuadratic, SmiCubic, SmiQuartic });
            SmiAlgebraMenu.Name = "SmiAlgebraMenu";
            SmiAlgebraMenu.Size = new Size(60, 20);
            SmiAlgebraMenu.Text = "Algebra";
            // 
            // SmiQuadratic
            // 
            SmiQuadratic.Name = "SmiQuadratic";
            SmiQuadratic.Size = new Size(126, 22);
            SmiQuadratic.Text = "Quadratic";
            SmiQuadratic.Click += Smi_Click;
            // 
            // SmiCubic
            // 
            SmiCubic.Name = "SmiCubic";
            SmiCubic.Size = new Size(126, 22);
            SmiCubic.Text = "Cubic";
            SmiCubic.Click += Smi_Click;
            // 
            // SmiQuartic
            // 
            SmiQuartic.Name = "SmiQuartic";
            SmiQuartic.Size = new Size(126, 22);
            SmiQuartic.Text = "Quartic";
            SmiQuartic.Click += Smi_Click;
            // 
            // SmiSegmentMenu
            // 
            SmiSegmentMenu.DropDownItems.AddRange(new ToolStripItem[] { SmiTwoSegments });
            SmiSegmentMenu.Name = "SmiSegmentMenu";
            SmiSegmentMenu.Size = new Size(66, 20);
            SmiSegmentMenu.Text = "Segment";
            // 
            // SmiTwoSegments
            // 
            SmiTwoSegments.Name = "SmiTwoSegments";
            SmiTwoSegments.Size = new Size(180, 22);
            SmiTwoSegments.Text = "Two segments";
            SmiTwoSegments.Click += Smi_Click;
            // 
            // SmiCircleMenu
            // 
            SmiCircleMenu.DropDownItems.AddRange(new ToolStripItem[] { SmiCircleAndSegment, SmiTwoCircles });
            SmiCircleMenu.Name = "SmiCircleMenu";
            SmiCircleMenu.Size = new Size(49, 20);
            SmiCircleMenu.Text = "Circle";
            // 
            // SmiCircleAndSegment
            // 
            SmiCircleAndSegment.Name = "SmiCircleAndSegment";
            SmiCircleAndSegment.Size = new Size(180, 22);
            SmiCircleAndSegment.Text = "Circle and segment";
            SmiCircleAndSegment.Click += Smi_Click;
            // 
            // SmiTwoCircles
            // 
            SmiTwoCircles.Name = "SmiTwoCircles";
            SmiTwoCircles.Size = new Size(180, 22);
            SmiTwoCircles.Text = "Two circles";
            SmiTwoCircles.Click += Smi_Click;
            // 
            // SmiEllipseMenu
            // 
            SmiEllipseMenu.DropDownItems.AddRange(new ToolStripItem[] { SmiEllipseAndTangentLine, SmiEllipseAndSegment, SmiEllipseAndTangentCircle, SmiEllipseAndCircle, SmiEllipseAndTangentEllipse, SmiTwoEllipses });
            SmiEllipseMenu.Name = "SmiEllipseMenu";
            SmiEllipseMenu.Size = new Size(52, 20);
            SmiEllipseMenu.Text = "Ellipse";
            // 
            // SmiEllipseAndTangentLine
            // 
            SmiEllipseAndTangentLine.Name = "SmiEllipseAndTangentLine";
            SmiEllipseAndTangentLine.Size = new Size(210, 22);
            SmiEllipseAndTangentLine.Text = "Ellipse and tangent line";
            SmiEllipseAndTangentLine.Click += Smi_Click;
            // 
            // SmiEllipseAndSegment
            // 
            SmiEllipseAndSegment.Name = "SmiEllipseAndSegment";
            SmiEllipseAndSegment.Size = new Size(210, 22);
            SmiEllipseAndSegment.Text = "Ellipse and segment";
            SmiEllipseAndSegment.Click += Smi_Click;
            // 
            // SmiEllipseAndTangentCircle
            // 
            SmiEllipseAndTangentCircle.Name = "SmiEllipseAndTangentCircle";
            SmiEllipseAndTangentCircle.Size = new Size(210, 22);
            SmiEllipseAndTangentCircle.Text = "Ellipse and tangent circle";
            SmiEllipseAndTangentCircle.Click += Smi_Click;
            // 
            // SmiEllipseAndCircle
            // 
            SmiEllipseAndCircle.Name = "SmiEllipseAndCircle";
            SmiEllipseAndCircle.Size = new Size(210, 22);
            SmiEllipseAndCircle.Text = "Ellipse and circle";
            SmiEllipseAndCircle.Click += Smi_Click;
            // 
            // SmiEllipseAndTangentEllipse
            // 
            SmiEllipseAndTangentEllipse.Name = "SmiEllipseAndTangentEllipse";
            SmiEllipseAndTangentEllipse.Size = new Size(210, 22);
            SmiEllipseAndTangentEllipse.Text = "Ellipse and tangent ellipse";
            SmiEllipseAndTangentEllipse.Click += Smi_Click;
            // 
            // SmiTwoEllipses
            // 
            SmiTwoEllipses.Name = "SmiTwoEllipses";
            SmiTwoEllipses.Size = new Size(210, 22);
            SmiTwoEllipses.Text = "Two ellipses";
            SmiTwoEllipses.Click += Smi_Click;
            // 
            // SmiOpenGlMenu
            // 
            SmiOpenGlMenu.DropDownItems.AddRange(new ToolStripItem[] { SmiOpenGl, SmiTwoCircle3Projections });
            SmiOpenGlMenu.Name = "SmiOpenGlMenu";
            SmiOpenGlMenu.Size = new Size(62, 20);
            SmiOpenGlMenu.Text = "OpenGL";
            // 
            // SmiOpenGl
            // 
            SmiOpenGl.Name = "SmiOpenGl";
            SmiOpenGl.Size = new Size(194, 22);
            SmiOpenGl.Text = "OpenGL";
            SmiOpenGl.Click += Smi_Click;
            // 
            // SmiTwoCircle3Projections
            // 
            SmiTwoCircle3Projections.Name = "SmiTwoCircle3Projections";
            SmiTwoCircle3Projections.Size = new Size(194, 22);
            SmiTwoCircle3Projections.Text = "Two circle3 projections";
            SmiTwoCircle3Projections.Click += Smi_Click;
            // 
            // SmiOrbitMenu
            // 
            SmiOrbitMenu.DropDownItems.AddRange(new ToolStripItem[] { SmiFlatScreen, SmiFlatScreenVector, SmiSphericalScreen, SmiSphericalScreenVector, SmiSpace, SmiSpaceVector });
            SmiOrbitMenu.Name = "SmiOrbitMenu";
            SmiOrbitMenu.Size = new Size(46, 20);
            SmiOrbitMenu.Text = "Orbit";
            // 
            // SmiFlatScreen
            // 
            SmiFlatScreen.Name = "SmiFlatScreen";
            SmiFlatScreen.Size = new Size(195, 22);
            SmiFlatScreen.Text = "Flat screen";
            SmiFlatScreen.Click += Smi_Click;
            // 
            // SmiFlatScreenVector
            // 
            SmiFlatScreenVector.Name = "SmiFlatScreenVector";
            SmiFlatScreenVector.Size = new Size(195, 22);
            SmiFlatScreenVector.Text = "Flat screen vector";
            SmiFlatScreenVector.Click += Smi_Click;
            // 
            // SmiSphericalScreen
            // 
            SmiSphericalScreen.Name = "SmiSphericalScreen";
            SmiSphericalScreen.Size = new Size(195, 22);
            SmiSphericalScreen.Text = "Spherical screen";
            SmiSphericalScreen.Click += Smi_Click;
            // 
            // SmiSphericalScreenVector
            // 
            SmiSphericalScreenVector.Name = "SmiSphericalScreenVector";
            SmiSphericalScreenVector.Size = new Size(195, 22);
            SmiSphericalScreenVector.Text = "Spherical screen vector";
            SmiSphericalScreenVector.Click += Smi_Click;
            // 
            // SmiSpace
            // 
            SmiSpace.Name = "SmiSpace";
            SmiSpace.Size = new Size(195, 22);
            SmiSpace.Text = "Space";
            SmiSpace.Click += Smi_Click;
            // 
            // SmiSpaceVector
            // 
            SmiSpaceVector.Name = "SmiSpaceVector";
            SmiSpaceVector.Size = new Size(195, 22);
            SmiSpaceVector.Text = "Space vector";
            SmiSpaceVector.Click += Smi_Click;
            // 
            // FrmEllipseAndTangentEllipse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 553);
            Controls.Add(PnlFill);
            Name = "FrmEllipseAndTangentEllipse";
            Text = "Intersection (EllipseAndTangentEllipse)";
            WindowState = FormWindowState.Maximized;
            Load += FrmEllipseAndTangentEllipse_Load;
            ((System.ComponentModel.ISupportInitialize)NudEa1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudEx1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudEy1).EndInit();
            PnlFill.ResumeLayout(false);
            PnlFill.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudEx2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudEy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudEa2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudEb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudRotate2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudEb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudRotate1).EndInit();
            Mns.ResumeLayout(false);
            Mns.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PnlFill;
        private Label label1;
        private NumericUpDown NudEa1;
        private Label label3;
        private NumericUpDown NudEx1;
        private Label label2;
        private NumericUpDown NudEy1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label5;
        private NumericUpDown NudEx2;
        private Label label6;
        private NumericUpDown NudEy2;
        private Label label9;
        private NumericUpDown NudEb1;
        private Label label10;
        private NumericUpDown NudRotate1;
        private CheckBox ChbNearest;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label7;
        private NumericUpDown NudEa2;
        private Label label8;
        private NumericUpDown NudEb2;
        private Label label11;
        private NumericUpDown NudRotate2;
        private MenuStrip Mns;
        private ToolStripMenuItem SmiFileMenu;
        private ToolStripMenuItem SmiSave;
        private ToolStripMenuItem SmiLoad;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem SmiInc;
        private ToolStripMenuItem SmiPackingMenu;
        private ToolStripMenuItem SmiPackingCirclesInACircle;
        private ToolStripMenuItem SmiPackingCirclesInASquare;
        private ToolStripMenuItem SmiPackingCirclesInARectangle;
        private ToolStripMenuItem SmiAlgebraMenu;
        private ToolStripMenuItem SmiQuadratic;
        private ToolStripMenuItem SmiCubic;
        private ToolStripMenuItem SmiQuartic;
        private ToolStripMenuItem SmiSegmentMenu;
        private ToolStripMenuItem SmiTwoSegments;
        private ToolStripMenuItem SmiCircleMenu;
        private ToolStripMenuItem SmiCircleAndSegment;
        private ToolStripMenuItem SmiTwoCircles;
        private ToolStripMenuItem SmiEllipseMenu;
        private ToolStripMenuItem SmiEllipseAndTangentLine;
        private ToolStripMenuItem SmiEllipseAndSegment;
        private ToolStripMenuItem SmiEllipseAndTangentCircle;
        private ToolStripMenuItem SmiEllipseAndCircle;
        private ToolStripMenuItem SmiEllipseAndTangentEllipse;
        private ToolStripMenuItem SmiTwoEllipses;
        private ToolStripMenuItem SmiOpenGlMenu;
        private ToolStripMenuItem SmiOpenGl;
        private ToolStripMenuItem SmiTwoCircle3Projections;
        private ToolStripMenuItem SmiOrbitMenu;
        private ToolStripMenuItem SmiFlatScreen;
        private ToolStripMenuItem SmiFlatScreenVector;
        private ToolStripMenuItem SmiSphericalScreen;
        private ToolStripMenuItem SmiSphericalScreenVector;
        private ToolStripMenuItem SmiSpace;
        private ToolStripMenuItem SmiSpaceVector;
    }
}