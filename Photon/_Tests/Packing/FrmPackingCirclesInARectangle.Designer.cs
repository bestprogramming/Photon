namespace Photon.TestPacking
{
    partial class FrmPackingCirclesInARectangle
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
            PnlFill = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label9 = new Label();
            NudX = new NumericUpDown();
            label8 = new Label();
            NudY = new NumericUpDown();
            label6 = new Label();
            NudWidth = new NumericUpDown();
            label1 = new Label();
            NudHeight = new NumericUpDown();
            label5 = new Label();
            NudCount = new NumericUpDown();
            ChbAxis = new CheckBox();
            ChbPixels = new CheckBox();
            ChbBounding = new CheckBox();
            ChbFromCenter = new CheckBox();
            ChbArea = new CheckBox();
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
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudCount).BeginInit();
            Mns.SuspendLayout();
            SuspendLayout();
            // 
            // PnlFill
            // 
            PnlFill.BackColor = Color.LightGray;
            PnlFill.Dock = DockStyle.Fill;
            PnlFill.Location = new System.Drawing.Point(0, 53);
            PnlFill.Name = "PnlFill";
            PnlFill.Size = new Size(1779, 500);
            PnlFill.TabIndex = 4;
            PnlFill.Paint += PnlFill_Paint;
            PnlFill.MouseDown += PnlFill_MouseDown;
            PnlFill.MouseMove += PnlFill_MouseMove;
            PnlFill.PreviewKeyDown += PnlFill_PreviewKeyDown;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(NudX);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(NudY);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(NudWidth);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(NudHeight);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(NudCount);
            flowLayoutPanel1.Controls.Add(ChbAxis);
            flowLayoutPanel1.Controls.Add(ChbPixels);
            flowLayoutPanel1.Controls.Add(ChbBounding);
            flowLayoutPanel1.Controls.Add(ChbFromCenter);
            flowLayoutPanel1.Controls.Add(ChbArea);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1779, 29);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(3, 6);
            label9.Margin = new Padding(3, 6, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 34;
            label9.Text = "x";
            // 
            // NudX
            // 
            NudX.BackColor = Color.WhiteSmoke;
            NudX.DecimalPlaces = 14;
            NudX.Location = new System.Drawing.Point(22, 3);
            NudX.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudX.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudX.Name = "NudX";
            NudX.Size = new Size(100, 23);
            NudX.TabIndex = 35;
            NudX.ValueChanged += FormSetting_Changed;
            NudX.Click += NudInc_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(128, 6);
            label8.Margin = new Padding(3, 6, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 36;
            label8.Text = "y";
            // 
            // NudY
            // 
            NudY.BackColor = Color.WhiteSmoke;
            NudY.DecimalPlaces = 14;
            NudY.Location = new System.Drawing.Point(147, 3);
            NudY.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudY.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudY.Name = "NudY";
            NudY.Size = new Size(100, 23);
            NudY.TabIndex = 37;
            NudY.ValueChanged += FormSetting_Changed;
            NudY.Click += NudInc_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(253, 6);
            label6.Margin = new Padding(3, 6, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 38;
            label6.Text = "width";
            // 
            // NudWidth
            // 
            NudWidth.BackColor = Color.WhiteSmoke;
            NudWidth.DecimalPlaces = 14;
            NudWidth.Location = new System.Drawing.Point(296, 3);
            NudWidth.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudWidth.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudWidth.Name = "NudWidth";
            NudWidth.Size = new Size(100, 23);
            NudWidth.TabIndex = 39;
            NudWidth.Value = new decimal(new int[] { 400, 0, 0, 0 });
            NudWidth.ValueChanged += FormSetting_Changed;
            NudWidth.Click += NudInc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(402, 6);
            label1.Margin = new Padding(3, 6, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 45;
            label1.Text = "height";
            // 
            // NudHeight
            // 
            NudHeight.BackColor = Color.WhiteSmoke;
            NudHeight.DecimalPlaces = 14;
            NudHeight.Enabled = false;
            NudHeight.Location = new System.Drawing.Point(449, 3);
            NudHeight.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudHeight.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudHeight.Name = "NudHeight";
            NudHeight.Size = new Size(100, 23);
            NudHeight.TabIndex = 46;
            NudHeight.Value = new decimal(new int[] { 400, 0, 0, 0 });
            NudHeight.Click += NudInc_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(555, 6);
            label5.Margin = new Padding(3, 6, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 40;
            label5.Text = "count";
            // 
            // NudCount
            // 
            NudCount.BackColor = Color.WhiteSmoke;
            NudCount.Location = new System.Drawing.Point(599, 3);
            NudCount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NudCount.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            NudCount.Name = "NudCount";
            NudCount.Size = new Size(60, 23);
            NudCount.TabIndex = 41;
            NudCount.Value = new decimal(new int[] { 500, 0, 0, 0 });
            NudCount.ValueChanged += FormSetting_Changed;
            NudCount.Click += NudInc_Click;
            // 
            // ChbAxis
            // 
            ChbAxis.AutoSize = true;
            ChbAxis.Location = new System.Drawing.Point(665, 6);
            ChbAxis.Margin = new Padding(3, 6, 3, 3);
            ChbAxis.Name = "ChbAxis";
            ChbAxis.Size = new Size(46, 19);
            ChbAxis.TabIndex = 44;
            ChbAxis.Text = "axis";
            ChbAxis.UseVisualStyleBackColor = true;
            ChbAxis.CheckedChanged += FormSetting_Changed;
            // 
            // ChbPixels
            // 
            ChbPixels.AutoSize = true;
            ChbPixels.Location = new System.Drawing.Point(717, 6);
            ChbPixels.Margin = new Padding(3, 6, 3, 3);
            ChbPixels.Name = "ChbPixels";
            ChbPixels.Size = new Size(56, 19);
            ChbPixels.TabIndex = 42;
            ChbPixels.Text = "pixels";
            ChbPixels.UseVisualStyleBackColor = true;
            ChbPixels.CheckedChanged += FormSetting_Changed;
            // 
            // ChbBounding
            // 
            ChbBounding.AutoSize = true;
            ChbBounding.Checked = true;
            ChbBounding.CheckState = CheckState.Checked;
            ChbBounding.Location = new System.Drawing.Point(779, 6);
            ChbBounding.Margin = new Padding(3, 6, 3, 3);
            ChbBounding.Name = "ChbBounding";
            ChbBounding.Size = new Size(78, 19);
            ChbBounding.TabIndex = 43;
            ChbBounding.Text = "bounding";
            ChbBounding.UseVisualStyleBackColor = true;
            ChbBounding.CheckedChanged += FormSetting_Changed;
            // 
            // ChbFromCenter
            // 
            ChbFromCenter.AutoSize = true;
            ChbFromCenter.Location = new System.Drawing.Point(863, 6);
            ChbFromCenter.Margin = new Padding(3, 6, 3, 3);
            ChbFromCenter.Name = "ChbFromCenter";
            ChbFromCenter.Size = new Size(88, 19);
            ChbFromCenter.TabIndex = 33;
            ChbFromCenter.Text = "from center";
            ChbFromCenter.UseVisualStyleBackColor = true;
            ChbFromCenter.CheckedChanged += FormSetting_Changed;
            // 
            // ChbArea
            // 
            ChbArea.AutoSize = true;
            ChbArea.Checked = true;
            ChbArea.CheckState = CheckState.Checked;
            ChbArea.Location = new System.Drawing.Point(957, 6);
            ChbArea.Margin = new Padding(3, 6, 3, 3);
            ChbArea.Name = "ChbArea";
            ChbArea.Size = new Size(48, 19);
            ChbArea.TabIndex = 47;
            ChbArea.Text = "area";
            ChbArea.UseVisualStyleBackColor = true;
            ChbArea.CheckedChanged += FormSetting_Changed;
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
            SmiTwoSegments.Size = new Size(149, 22);
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
            SmiCircleAndSegment.Size = new Size(176, 22);
            SmiCircleAndSegment.Text = "Circle and segment";
            SmiCircleAndSegment.Click += Smi_Click;
            // 
            // SmiTwoCircles
            // 
            SmiTwoCircles.Name = "SmiTwoCircles";
            SmiTwoCircles.Size = new Size(176, 22);
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
            // FrmPackingCirclesInARectangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1779, 553);
            Controls.Add(PnlFill);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Mns);
            Name = "FrmPackingCirclesInARectangle";
            Text = "Packing circles in a rectangle";
            WindowState = FormWindowState.Maximized;
            Load += FrmPackingCirclesInARectangle_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudX).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudY).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudCount).EndInit();
            Mns.ResumeLayout(false);
            Mns.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PnlFill;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox ChbFromCenter;
        private Label label9;
        private NumericUpDown NudCount;
        private Label label5;
        private Label label8;
        private NumericUpDown NudWidth;
        private Label label6;
        private NumericUpDown NudY;
        private NumericUpDown NudX;
        private CheckBox ChbPixels;
        private CheckBox ChbBounding;
        private CheckBox ChbAxis;
        private Label label1;
        private NumericUpDown NudHeight;
        private CheckBox ChbArea;
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