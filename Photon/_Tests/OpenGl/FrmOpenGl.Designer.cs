namespace Photon.TestOpenGl
{
    partial class FrmOpenGl
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
            Flp6 = new FlowLayoutPanel();
            ChbPointSize = new CheckBox();
            BtnSaveScene = new Button();
            Flp5 = new FlowLayoutPanel();
            ChbCircle3 = new CheckBox();
            Flp4 = new FlowLayoutPanel();
            ChbSphere = new CheckBox();
            ChbSphericalShell = new CheckBox();
            ChbSpheroid = new CheckBox();
            ChbSpheroidicalShell = new CheckBox();
            ChbEllipsoid = new CheckBox();
            ChbEllipsoidalShell = new CheckBox();
            Flp3 = new FlowLayoutPanel();
            ChbCircle = new CheckBox();
            ChbDisc = new CheckBox();
            ChbCylinder = new CheckBox();
            ChbCylindricalShell = new CheckBox();
            Flp2 = new FlowLayoutPanel();
            ChbLine = new CheckBox();
            ChbRectangle = new CheckBox();
            ChbRectangularArea = new CheckBox();
            ChbQuadrangular = new CheckBox();
            BtnStart = new Button();
            Flp1 = new FlowLayoutPanel();
            ChbUcs = new CheckBox();
            ChbCube = new CheckBox();
            ChbPoint = new CheckBox();
            Sfd = new SaveFileDialog();
            Mns = new MenuStrip();
            SmiFileMenu = new ToolStripMenuItem();
            SmiSave = new ToolStripMenuItem();
            SmiLoad = new ToolStripMenuItem();
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
            PnlFill.SuspendLayout();
            Flp6.SuspendLayout();
            Flp5.SuspendLayout();
            Flp4.SuspendLayout();
            Flp3.SuspendLayout();
            Flp2.SuspendLayout();
            Flp1.SuspendLayout();
            Mns.SuspendLayout();
            SuspendLayout();
            // 
            // PnlFill
            // 
            PnlFill.BackColor = Color.LightGray;
            PnlFill.Controls.Add(Flp6);
            PnlFill.Controls.Add(BtnSaveScene);
            PnlFill.Controls.Add(Flp5);
            PnlFill.Controls.Add(Flp4);
            PnlFill.Controls.Add(Flp3);
            PnlFill.Controls.Add(Flp2);
            PnlFill.Controls.Add(BtnStart);
            PnlFill.Dock = DockStyle.Fill;
            PnlFill.Location = new System.Drawing.Point(0, 52);
            PnlFill.Name = "PnlFill";
            PnlFill.Size = new Size(1184, 501);
            PnlFill.TabIndex = 4;
            // 
            // Flp6
            // 
            Flp6.AutoSize = true;
            Flp6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Flp6.Controls.Add(ChbPointSize);
            Flp6.Dock = DockStyle.Top;
            Flp6.Location = new System.Drawing.Point(0, 112);
            Flp6.Name = "Flp6";
            Flp6.Size = new Size(1184, 28);
            Flp6.TabIndex = 48;
            // 
            // ChbPointSize
            // 
            ChbPointSize.AutoSize = true;
            ChbPointSize.Checked = true;
            ChbPointSize.CheckState = CheckState.Checked;
            ChbPointSize.Location = new System.Drawing.Point(3, 6);
            ChbPointSize.Margin = new Padding(3, 6, 3, 3);
            ChbPointSize.Name = "ChbPointSize";
            ChbPointSize.Size = new Size(74, 19);
            ChbPointSize.TabIndex = 51;
            ChbPointSize.Text = "PointSize";
            ChbPointSize.UseVisualStyleBackColor = true;
            // 
            // BtnSaveScene
            // 
            BtnSaveScene.FlatStyle = FlatStyle.Flat;
            BtnSaveScene.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSaveScene.Location = new System.Drawing.Point(71, 159);
            BtnSaveScene.Margin = new Padding(10, 1, 1, 1);
            BtnSaveScene.Name = "BtnSaveScene";
            BtnSaveScene.Size = new Size(76, 26);
            BtnSaveScene.TabIndex = 46;
            BtnSaveScene.Text = "Save scene";
            BtnSaveScene.UseVisualStyleBackColor = true;
            BtnSaveScene.Click += BtnSaveScene_Click;
            // 
            // Flp5
            // 
            Flp5.AutoSize = true;
            Flp5.Controls.Add(ChbCircle3);
            Flp5.Dock = DockStyle.Top;
            Flp5.Location = new System.Drawing.Point(0, 84);
            Flp5.Name = "Flp5";
            Flp5.Size = new Size(1184, 28);
            Flp5.TabIndex = 45;
            // 
            // ChbCircle3
            // 
            ChbCircle3.AutoSize = true;
            ChbCircle3.Location = new System.Drawing.Point(3, 6);
            ChbCircle3.Margin = new Padding(3, 6, 3, 3);
            ChbCircle3.Name = "ChbCircle3";
            ChbCircle3.Size = new Size(62, 19);
            ChbCircle3.TabIndex = 50;
            ChbCircle3.Text = "Circle3";
            ChbCircle3.UseVisualStyleBackColor = true;
            // 
            // Flp4
            // 
            Flp4.AutoSize = true;
            Flp4.Controls.Add(ChbSphere);
            Flp4.Controls.Add(ChbSphericalShell);
            Flp4.Controls.Add(ChbSpheroid);
            Flp4.Controls.Add(ChbSpheroidicalShell);
            Flp4.Controls.Add(ChbEllipsoid);
            Flp4.Controls.Add(ChbEllipsoidalShell);
            Flp4.Dock = DockStyle.Top;
            Flp4.Location = new System.Drawing.Point(0, 56);
            Flp4.Name = "Flp4";
            Flp4.Size = new Size(1184, 28);
            Flp4.TabIndex = 44;
            // 
            // ChbSphere
            // 
            ChbSphere.AutoSize = true;
            ChbSphere.Location = new System.Drawing.Point(3, 6);
            ChbSphere.Margin = new Padding(3, 6, 3, 3);
            ChbSphere.Name = "ChbSphere";
            ChbSphere.Size = new Size(62, 19);
            ChbSphere.TabIndex = 53;
            ChbSphere.Text = "Sphere";
            ChbSphere.UseVisualStyleBackColor = true;
            // 
            // ChbSphericalShell
            // 
            ChbSphericalShell.AutoSize = true;
            ChbSphericalShell.Location = new System.Drawing.Point(71, 6);
            ChbSphericalShell.Margin = new Padding(3, 6, 3, 3);
            ChbSphericalShell.Name = "ChbSphericalShell";
            ChbSphericalShell.Size = new Size(99, 19);
            ChbSphericalShell.TabIndex = 54;
            ChbSphericalShell.Text = "SphericalShell";
            ChbSphericalShell.UseVisualStyleBackColor = true;
            // 
            // ChbSpheroid
            // 
            ChbSpheroid.AutoSize = true;
            ChbSpheroid.Location = new System.Drawing.Point(176, 6);
            ChbSpheroid.Margin = new Padding(3, 6, 3, 3);
            ChbSpheroid.Name = "ChbSpheroid";
            ChbSpheroid.Size = new Size(73, 19);
            ChbSpheroid.TabIndex = 55;
            ChbSpheroid.Text = "Spheroid";
            ChbSpheroid.UseVisualStyleBackColor = true;
            // 
            // ChbSpheroidicalShell
            // 
            ChbSpheroidicalShell.AutoSize = true;
            ChbSpheroidicalShell.Location = new System.Drawing.Point(255, 6);
            ChbSpheroidicalShell.Margin = new Padding(3, 6, 3, 3);
            ChbSpheroidicalShell.Name = "ChbSpheroidicalShell";
            ChbSpheroidicalShell.Size = new Size(116, 19);
            ChbSpheroidicalShell.TabIndex = 56;
            ChbSpheroidicalShell.Text = "SpheroidicalShell";
            ChbSpheroidicalShell.UseVisualStyleBackColor = true;
            // 
            // ChbEllipsoid
            // 
            ChbEllipsoid.AutoSize = true;
            ChbEllipsoid.Location = new System.Drawing.Point(377, 6);
            ChbEllipsoid.Margin = new Padding(3, 6, 3, 3);
            ChbEllipsoid.Name = "ChbEllipsoid";
            ChbEllipsoid.Size = new Size(70, 19);
            ChbEllipsoid.TabIndex = 57;
            ChbEllipsoid.Text = "Ellipsoid";
            ChbEllipsoid.UseVisualStyleBackColor = true;
            // 
            // ChbEllipsoidalShell
            // 
            ChbEllipsoidalShell.AutoSize = true;
            ChbEllipsoidalShell.Location = new System.Drawing.Point(453, 6);
            ChbEllipsoidalShell.Margin = new Padding(3, 6, 3, 3);
            ChbEllipsoidalShell.Name = "ChbEllipsoidalShell";
            ChbEllipsoidalShell.Size = new Size(104, 19);
            ChbEllipsoidalShell.TabIndex = 58;
            ChbEllipsoidalShell.Text = "EllipsoidalShell";
            ChbEllipsoidalShell.UseVisualStyleBackColor = true;
            // 
            // Flp3
            // 
            Flp3.AutoSize = true;
            Flp3.Controls.Add(ChbCircle);
            Flp3.Controls.Add(ChbDisc);
            Flp3.Controls.Add(ChbCylinder);
            Flp3.Controls.Add(ChbCylindricalShell);
            Flp3.Dock = DockStyle.Top;
            Flp3.Location = new System.Drawing.Point(0, 28);
            Flp3.Name = "Flp3";
            Flp3.Size = new Size(1184, 28);
            Flp3.TabIndex = 43;
            // 
            // ChbCircle
            // 
            ChbCircle.AutoSize = true;
            ChbCircle.Location = new System.Drawing.Point(3, 6);
            ChbCircle.Margin = new Padding(3, 6, 3, 3);
            ChbCircle.Name = "ChbCircle";
            ChbCircle.Size = new Size(56, 19);
            ChbCircle.TabIndex = 49;
            ChbCircle.Text = "Circle";
            ChbCircle.UseVisualStyleBackColor = true;
            // 
            // ChbDisc
            // 
            ChbDisc.AutoSize = true;
            ChbDisc.Location = new System.Drawing.Point(65, 6);
            ChbDisc.Margin = new Padding(3, 6, 3, 3);
            ChbDisc.Name = "ChbDisc";
            ChbDisc.Size = new Size(48, 19);
            ChbDisc.TabIndex = 50;
            ChbDisc.Text = "Disc";
            ChbDisc.UseVisualStyleBackColor = true;
            // 
            // ChbCylinder
            // 
            ChbCylinder.AutoSize = true;
            ChbCylinder.Location = new System.Drawing.Point(119, 6);
            ChbCylinder.Margin = new Padding(3, 6, 3, 3);
            ChbCylinder.Name = "ChbCylinder";
            ChbCylinder.Size = new Size(70, 19);
            ChbCylinder.TabIndex = 51;
            ChbCylinder.Text = "Cylinder";
            ChbCylinder.UseVisualStyleBackColor = true;
            // 
            // ChbCylindricalShell
            // 
            ChbCylindricalShell.AutoSize = true;
            ChbCylindricalShell.Location = new System.Drawing.Point(195, 6);
            ChbCylindricalShell.Margin = new Padding(3, 6, 3, 3);
            ChbCylindricalShell.Name = "ChbCylindricalShell";
            ChbCylindricalShell.Size = new Size(107, 19);
            ChbCylindricalShell.TabIndex = 52;
            ChbCylindricalShell.Text = "CylindricalShell";
            ChbCylindricalShell.UseVisualStyleBackColor = true;
            // 
            // Flp2
            // 
            Flp2.AutoSize = true;
            Flp2.Controls.Add(ChbLine);
            Flp2.Controls.Add(ChbRectangle);
            Flp2.Controls.Add(ChbRectangularArea);
            Flp2.Controls.Add(ChbQuadrangular);
            Flp2.Dock = DockStyle.Top;
            Flp2.Location = new System.Drawing.Point(0, 0);
            Flp2.Name = "Flp2";
            Flp2.Size = new Size(1184, 28);
            Flp2.TabIndex = 0;
            // 
            // ChbLine
            // 
            ChbLine.AutoSize = true;
            ChbLine.Location = new System.Drawing.Point(3, 6);
            ChbLine.Margin = new Padding(3, 6, 3, 3);
            ChbLine.Name = "ChbLine";
            ChbLine.Size = new Size(48, 19);
            ChbLine.TabIndex = 45;
            ChbLine.Text = "Line";
            ChbLine.UseVisualStyleBackColor = true;
            // 
            // ChbRectangle
            // 
            ChbRectangle.AutoSize = true;
            ChbRectangle.Location = new System.Drawing.Point(57, 6);
            ChbRectangle.Margin = new Padding(3, 6, 3, 3);
            ChbRectangle.Name = "ChbRectangle";
            ChbRectangle.Size = new Size(78, 19);
            ChbRectangle.TabIndex = 46;
            ChbRectangle.Text = "Rectangle";
            ChbRectangle.UseVisualStyleBackColor = true;
            // 
            // ChbRectangularArea
            // 
            ChbRectangularArea.AutoSize = true;
            ChbRectangularArea.Location = new System.Drawing.Point(141, 6);
            ChbRectangularArea.Margin = new Padding(3, 6, 3, 3);
            ChbRectangularArea.Name = "ChbRectangularArea";
            ChbRectangularArea.Size = new Size(113, 19);
            ChbRectangularArea.TabIndex = 47;
            ChbRectangularArea.Text = "RectangularArea";
            ChbRectangularArea.UseVisualStyleBackColor = true;
            // 
            // ChbQuadrangular
            // 
            ChbQuadrangular.AutoSize = true;
            ChbQuadrangular.Location = new System.Drawing.Point(260, 6);
            ChbQuadrangular.Margin = new Padding(3, 6, 3, 3);
            ChbQuadrangular.Name = "ChbQuadrangular";
            ChbQuadrangular.Size = new Size(99, 19);
            ChbQuadrangular.TabIndex = 48;
            ChbQuadrangular.Text = "Quadrangular";
            ChbQuadrangular.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            BtnStart.FlatStyle = FlatStyle.Flat;
            BtnStart.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnStart.Location = new System.Drawing.Point(9, 159);
            BtnStart.Margin = new Padding(10, 1, 1, 1);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(50, 26);
            BtnStart.TabIndex = 42;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // Flp1
            // 
            Flp1.AutoSize = true;
            Flp1.BackColor = Color.LightGray;
            Flp1.Controls.Add(ChbUcs);
            Flp1.Controls.Add(ChbCube);
            Flp1.Controls.Add(ChbPoint);
            Flp1.Dock = DockStyle.Top;
            Flp1.Location = new System.Drawing.Point(0, 24);
            Flp1.Name = "Flp1";
            Flp1.Size = new Size(1184, 28);
            Flp1.TabIndex = 21;
            // 
            // ChbUcs
            // 
            ChbUcs.AutoSize = true;
            ChbUcs.Location = new System.Drawing.Point(3, 6);
            ChbUcs.Margin = new Padding(3, 6, 3, 3);
            ChbUcs.Name = "ChbUcs";
            ChbUcs.Size = new Size(45, 19);
            ChbUcs.TabIndex = 33;
            ChbUcs.Text = "Ucs";
            ChbUcs.UseVisualStyleBackColor = true;
            // 
            // ChbCube
            // 
            ChbCube.AutoSize = true;
            ChbCube.Location = new System.Drawing.Point(54, 6);
            ChbCube.Margin = new Padding(3, 6, 3, 3);
            ChbCube.Name = "ChbCube";
            ChbCube.Size = new Size(54, 19);
            ChbCube.TabIndex = 43;
            ChbCube.Text = "Cube";
            ChbCube.UseVisualStyleBackColor = true;
            // 
            // ChbPoint
            // 
            ChbPoint.AutoSize = true;
            ChbPoint.Location = new System.Drawing.Point(114, 6);
            ChbPoint.Margin = new Padding(3, 6, 3, 3);
            ChbPoint.Name = "ChbPoint";
            ChbPoint.Size = new Size(54, 19);
            ChbPoint.TabIndex = 44;
            ChbPoint.Text = "Point";
            ChbPoint.UseVisualStyleBackColor = true;
            // 
            // Sfd
            // 
            Sfd.Filter = "Photon pattern files|.pho";
            // 
            // Mns
            // 
            Mns.Items.AddRange(new ToolStripItem[] { SmiFileMenu, SmiPackingMenu, SmiAlgebraMenu, SmiSegmentMenu, SmiCircleMenu, SmiEllipseMenu, SmiOpenGlMenu, SmiOrbitMenu });
            Mns.Location = new System.Drawing.Point(0, 0);
            Mns.Name = "Mns";
            Mns.Size = new Size(1184, 24);
            Mns.TabIndex = 42;
            Mns.Text = "menuStrip1";
            // 
            // SmiFileMenu
            // 
            SmiFileMenu.DropDownItems.AddRange(new ToolStripItem[] { SmiSave, SmiLoad });
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
            // FrmOpenGl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 553);
            Controls.Add(PnlFill);
            Controls.Add(Flp1);
            Controls.Add(Mns);
            Name = "FrmOpenGl";
            Text = "OpenGL";
            WindowState = FormWindowState.Maximized;
            Load += FrmOpenGl_Load;
            PnlFill.ResumeLayout(false);
            PnlFill.PerformLayout();
            Flp6.ResumeLayout(false);
            Flp6.PerformLayout();
            Flp5.ResumeLayout(false);
            Flp5.PerformLayout();
            Flp4.ResumeLayout(false);
            Flp4.PerformLayout();
            Flp3.ResumeLayout(false);
            Flp3.PerformLayout();
            Flp2.ResumeLayout(false);
            Flp2.PerformLayout();
            Flp1.ResumeLayout(false);
            Flp1.PerformLayout();
            Mns.ResumeLayout(false);
            Mns.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PnlFill;
        private FlowLayoutPanel Flp1;
        private Button BtnStart;
        private FlowLayoutPanel Flp2;
        private FlowLayoutPanel Flp3;
        private FlowLayoutPanel Flp4;
        private FlowLayoutPanel Flp5;
        private Button BtnSaveScene;
        private SaveFileDialog Sfd;
        public CheckBox ChbUcs;
        public CheckBox ChbCube;
        public CheckBox ChbPoint;
        public CheckBox ChbLine;
        public CheckBox ChbRectangle;
        public CheckBox ChbRectangularArea;
        public CheckBox ChbQuadrangular;
        public CheckBox ChbCircle;
        public CheckBox ChbDisc;
        public CheckBox ChbCylinder;
        public CheckBox ChbCylindricalShell;
        public CheckBox ChbSphere;
        public CheckBox ChbSphericalShell;
        public CheckBox ChbSpheroid;
        public CheckBox ChbSpheroidicalShell;
        public CheckBox ChbCircle3;
        public CheckBox ChbEllipsoid;
        public CheckBox ChbEllipsoidalShell;
        private FlowLayoutPanel Flp6;
        public CheckBox ChbPointSize;
        private MenuStrip Mns;
        private ToolStripMenuItem SmiFileMenu;
        private ToolStripMenuItem SmiSave;
        private ToolStripMenuItem SmiLoad;
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