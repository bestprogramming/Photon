namespace Photon.TestIntersection
{
    partial class FrmTwoSegments
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
            NudX2 = new NumericUpDown();
            label3 = new Label();
            NudX1 = new NumericUpDown();
            label2 = new Label();
            NudY1 = new NumericUpDown();
            label1 = new Label();
            PnlFill = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label7 = new Label();
            NudY2 = new NumericUpDown();
            label5 = new Label();
            NudX3 = new NumericUpDown();
            label6 = new Label();
            NudY3 = new NumericUpDown();
            label8 = new Label();
            NudX4 = new NumericUpDown();
            label9 = new Label();
            NudY4 = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)NudX2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudX1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudY1).BeginInit();
            PnlFill.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudY2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudX3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudY3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudX4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudY4).BeginInit();
            Mns.SuspendLayout();
            SuspendLayout();
            // 
            // NudX2
            // 
            NudX2.BackColor = Color.WhiteSmoke;
            NudX2.DecimalPlaces = 14;
            NudX2.Location = new System.Drawing.Point(370, 3);
            NudX2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudX2.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudX2.Name = "NudX2";
            NudX2.Size = new Size(140, 23);
            NudX2.TabIndex = 16;
            NudX2.Value = new decimal(new int[] { 300, 0, 0, 0 });
            NudX2.ValueChanged += FormSetting_Changed;
            NudX2.Click += NudInc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(345, 6);
            label3.Margin = new Padding(3, 6, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 15;
            label3.Text = "x2";
            // 
            // NudX1
            // 
            NudX1.BackColor = Color.WhiteSmoke;
            NudX1.DecimalPlaces = 14;
            NudX1.Location = new System.Drawing.Point(28, 3);
            NudX1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudX1.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudX1.Name = "NudX1";
            NudX1.Size = new Size(140, 23);
            NudX1.TabIndex = 14;
            NudX1.Value = new decimal(new int[] { 200, 0, 0, int.MinValue });
            NudX1.ValueChanged += FormSetting_Changed;
            NudX1.Click += NudInc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(174, 6);
            label2.Margin = new Padding(3, 6, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 13;
            label2.Text = "y1";
            // 
            // NudY1
            // 
            NudY1.BackColor = Color.WhiteSmoke;
            NudY1.DecimalPlaces = 14;
            NudY1.Location = new System.Drawing.Point(199, 3);
            NudY1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudY1.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudY1.Name = "NudY1";
            NudY1.Size = new Size(140, 23);
            NudY1.TabIndex = 12;
            NudY1.ValueChanged += FormSetting_Changed;
            NudY1.Click += NudInc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 6);
            label1.Margin = new Padding(3, 6, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 4;
            label1.Text = "x1";
            // 
            // PnlFill
            // 
            PnlFill.BackColor = Color.LightGray;
            PnlFill.Controls.Add(flowLayoutPanel1);
            PnlFill.Controls.Add(Mns);
            PnlFill.Dock = DockStyle.Fill;
            PnlFill.Location = new System.Drawing.Point(0, 0);
            PnlFill.Name = "PnlFill";
            PnlFill.Size = new Size(1779, 553);
            PnlFill.TabIndex = 4;
            PnlFill.Paint += PnlFill_Paint;
            PnlFill.MouseDown += PnlFill_MouseDown;
            PnlFill.MouseMove += PnlFill_MouseMove;
            PnlFill.MouseUp += PnlFill_MouseUp;
            PnlFill.PreviewKeyDown += PnlFill_PreviewKeyDown;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(NudX1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(NudY1);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(NudX2);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(NudY2);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(NudX3);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(NudY3);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(NudX4);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(NudY4);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1779, 29);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(516, 6);
            label7.Margin = new Padding(3, 6, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 35;
            label7.Text = "y2";
            // 
            // NudY2
            // 
            NudY2.BackColor = Color.WhiteSmoke;
            NudY2.DecimalPlaces = 14;
            NudY2.Location = new System.Drawing.Point(541, 3);
            NudY2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudY2.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudY2.Name = "NudY2";
            NudY2.Size = new Size(140, 23);
            NudY2.TabIndex = 36;
            NudY2.Value = new decimal(new int[] { 300, 0, 0, 0 });
            NudY2.Click += NudInc_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(724, 6);
            label5.Margin = new Padding(40, 6, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 21;
            label5.Text = "x3";
            // 
            // NudX3
            // 
            NudX3.BackColor = Color.WhiteSmoke;
            NudX3.DecimalPlaces = 14;
            NudX3.Location = new System.Drawing.Point(749, 3);
            NudX3.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudX3.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudX3.Name = "NudX3";
            NudX3.Size = new Size(140, 23);
            NudX3.TabIndex = 24;
            NudX3.Value = new decimal(new int[] { 200, 0, 0, 0 });
            NudX3.ValueChanged += FormSetting_Changed;
            NudX3.Click += NudInc_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(895, 6);
            label6.Margin = new Padding(3, 6, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 23;
            label6.Text = "y3";
            // 
            // NudY3
            // 
            NudY3.BackColor = Color.WhiteSmoke;
            NudY3.DecimalPlaces = 14;
            NudY3.Location = new System.Drawing.Point(920, 3);
            NudY3.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudY3.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudY3.Name = "NudY3";
            NudY3.Size = new Size(140, 23);
            NudY3.TabIndex = 22;
            NudY3.ValueChanged += FormSetting_Changed;
            NudY3.Click += NudInc_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(1066, 6);
            label8.Margin = new Padding(3, 6, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 25;
            label8.Text = "x4";
            // 
            // NudX4
            // 
            NudX4.BackColor = Color.WhiteSmoke;
            NudX4.DecimalPlaces = 14;
            NudX4.Location = new System.Drawing.Point(1091, 3);
            NudX4.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudX4.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudX4.Name = "NudX4";
            NudX4.Size = new Size(140, 23);
            NudX4.TabIndex = 26;
            NudX4.Value = new decimal(new int[] { 300, 0, 0, 0 });
            NudX4.ValueChanged += FormSetting_Changed;
            NudX4.Click += NudInc_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(1237, 6);
            label9.Margin = new Padding(3, 6, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 37;
            label9.Text = "y4";
            // 
            // NudY4
            // 
            NudY4.BackColor = Color.WhiteSmoke;
            NudY4.DecimalPlaces = 14;
            NudY4.Location = new System.Drawing.Point(1262, 3);
            NudY4.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudY4.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudY4.Name = "NudY4";
            NudY4.Size = new Size(140, 23);
            NudY4.TabIndex = 38;
            NudY4.Value = new decimal(new int[] { 300, 0, 0, 0 });
            NudY4.Click += NudInc_Click;
            // 
            // Mns
            // 
            Mns.Items.AddRange(new ToolStripItem[] { SmiFileMenu, SmiPackingMenu, SmiAlgebraMenu, SmiSegmentMenu, SmiCircleMenu, SmiEllipseMenu, SmiOpenGlMenu, SmiOrbitMenu });
            Mns.Location = new System.Drawing.Point(0, 0);
            Mns.Name = "Mns";
            Mns.Size = new Size(1779, 24);
            Mns.TabIndex = 42;
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
            SmiSave.Size = new Size(100, 22);
            SmiSave.Text = "Save";
            SmiSave.Click += Smi_Click;
            // 
            // SmiLoad
            // 
            SmiLoad.Name = "SmiLoad";
            SmiLoad.Size = new Size(100, 22);
            SmiLoad.Text = "Load";
            SmiLoad.Click += Smi_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(97, 6);
            // 
            // SmiInc
            // 
            SmiInc.Name = "SmiInc";
            SmiInc.Size = new Size(100, 22);
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
            // FrmTwoSegments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1779, 553);
            Controls.Add(PnlFill);
            Name = "FrmTwoSegments";
            Text = "Intersection (TwoSegments)";
            WindowState = FormWindowState.Maximized;
            Load += FrmTwoSegments_Load;
            ((System.ComponentModel.ISupportInitialize)NudX2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudX1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudY1).EndInit();
            PnlFill.ResumeLayout(false);
            PnlFill.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudY2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudX3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudY3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudX4).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudY4).EndInit();
            Mns.ResumeLayout(false);
            Mns.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PnlFill;
        private Label label1;
        private NumericUpDown NudX2;
        private Label label3;
        private NumericUpDown NudX1;
        private Label label2;
        private NumericUpDown NudY1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label5;
        private NumericUpDown NudX3;
        private Label label6;
        private NumericUpDown NudY3;
        private Label label8;
        private NumericUpDown NudX4;
        private Label label7;
        private NumericUpDown NudY2;
        private Label label9;
        private NumericUpDown NudY4;
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