namespace Photon.FlatScreen
{
    partial class FrmFlatScreen
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
            components = new System.ComponentModel.Container();
            Cdi = new ColorDialog();
            Tlt = new ToolTip(components);
            FlpContent = new FlowLayoutPanel();
            PnlBottom = new Panel();
            BtnRenderFolderAndSubfolders = new Button();
            BtnLoadList = new Button();
            BtnToGeogebraCurrentShape = new Button();
            Tlp1 = new TableLayoutPanel();
            NudRenderClusterSize = new NumericUpDown();
            label6 = new Label();
            FlpScreenPlane = new FlowLayoutPanel();
            RdbScreenPlaneXy = new RadioButton();
            RdbScreenPlaneXz = new RadioButton();
            RdbScreenPlaneYz = new RadioButton();
            NudScreenDistance = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label13 = new Label();
            label12 = new Label();
            NudScreenZ = new NumericUpDown();
            NudScreenY = new NumericUpDown();
            NudScreenX = new NumericUpDown();
            label10 = new Label();
            NudRenderPointSize = new NumericUpDown();
            label11 = new Label();
            NudScreenHeight = new NumericUpDown();
            NudPatternRatio = new NumericUpDown();
            NudScreenWidth = new NumericUpDown();
            NudParticleRadius = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            BtnShowList = new Button();
            BtnClearList = new Button();
            BtnRemoveSelected = new Button();
            BtnAddToList = new Button();
            Lsb = new ListBox();
            BtnRenderCurrentShape = new Button();
            BtnRenderList = new Button();
            BtnSaveList = new Button();
            BtnRenderFolder = new Button();
            Fbd = new FolderBrowserDialog();
            Ofd = new OpenFileDialog();
            Sfd = new SaveFileDialog();
            Mns = new MenuStrip();
            SmiFileMenu = new ToolStripMenuItem();
            SmiSave = new ToolStripMenuItem();
            SmiLoad = new ToolStripMenuItem();
            SmiDrawMenu = new ToolStripMenuItem();
            SmiPoint = new ToolStripMenuItem();
            SmiLine = new ToolStripMenuItem();
            SmiRectangle = new ToolStripMenuItem();
            SmiRectangularArea = new ToolStripMenuItem();
            SmiQuadrangular = new ToolStripMenuItem();
            SmiCircle = new ToolStripMenuItem();
            SmiDisc = new ToolStripMenuItem();
            SmiCylinder = new ToolStripMenuItem();
            SmiCylindricalShell = new ToolStripMenuItem();
            SmiSphere = new ToolStripMenuItem();
            SmiSphericalShell = new ToolStripMenuItem();
            SmiSpheroid = new ToolStripMenuItem();
            SmiSpheroidicalShell = new ToolStripMenuItem();
            SmiEllipsoid = new ToolStripMenuItem();
            SmiEllipsoidalShell = new ToolStripMenuItem();
            SmiPolygon = new ToolStripMenuItem();
            SmiPolygonArea = new ToolStripMenuItem();
            SmiPolygonPrism = new ToolStripMenuItem();
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
            PnlBottom.SuspendLayout();
            Tlp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudRenderClusterSize).BeginInit();
            FlpScreenPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudScreenDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudScreenZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudScreenY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudScreenX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudRenderPointSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudScreenHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudPatternRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudScreenWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudParticleRadius).BeginInit();
            Mns.SuspendLayout();
            SuspendLayout();
            // 
            // FlpContent
            // 
            FlpContent.AutoSize = true;
            FlpContent.Dock = DockStyle.Top;
            FlpContent.Location = new System.Drawing.Point(0, 24);
            FlpContent.Name = "FlpContent";
            FlpContent.Size = new Size(1491, 0);
            FlpContent.TabIndex = 37;
            // 
            // PnlBottom
            // 
            PnlBottom.Controls.Add(BtnRenderFolderAndSubfolders);
            PnlBottom.Controls.Add(BtnLoadList);
            PnlBottom.Controls.Add(BtnToGeogebraCurrentShape);
            PnlBottom.Controls.Add(Tlp1);
            PnlBottom.Controls.Add(BtnShowList);
            PnlBottom.Controls.Add(BtnClearList);
            PnlBottom.Controls.Add(BtnRemoveSelected);
            PnlBottom.Controls.Add(BtnAddToList);
            PnlBottom.Controls.Add(Lsb);
            PnlBottom.Controls.Add(BtnRenderCurrentShape);
            PnlBottom.Controls.Add(BtnRenderList);
            PnlBottom.Controls.Add(BtnSaveList);
            PnlBottom.Controls.Add(BtnRenderFolder);
            PnlBottom.Dock = DockStyle.Bottom;
            PnlBottom.Location = new System.Drawing.Point(0, 585);
            PnlBottom.Name = "PnlBottom";
            PnlBottom.Size = new Size(1491, 400);
            PnlBottom.TabIndex = 38;
            // 
            // BtnRenderFolderAndSubfolders
            // 
            BtnRenderFolderAndSubfolders.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRenderFolderAndSubfolders.Location = new System.Drawing.Point(1081, 158);
            BtnRenderFolderAndSubfolders.Name = "BtnRenderFolderAndSubfolders";
            BtnRenderFolderAndSubfolders.Size = new Size(180, 25);
            BtnRenderFolderAndSubfolders.TabIndex = 88;
            BtnRenderFolderAndSubfolders.Text = "Render folder and subfolders";
            BtnRenderFolderAndSubfolders.UseVisualStyleBackColor = true;
            BtnRenderFolderAndSubfolders.Click += BtnRenderFolderAndSubfolders_Click;
            // 
            // BtnLoadList
            // 
            BtnLoadList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnLoadList.Location = new System.Drawing.Point(1081, 96);
            BtnLoadList.Name = "BtnLoadList";
            BtnLoadList.Size = new Size(180, 25);
            BtnLoadList.TabIndex = 86;
            BtnLoadList.Text = "Load list";
            BtnLoadList.UseVisualStyleBackColor = true;
            BtnLoadList.Click += BtnLoadList_Click;
            // 
            // BtnToGeogebraCurrentShape
            // 
            BtnToGeogebraCurrentShape.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnToGeogebraCurrentShape.Location = new System.Drawing.Point(1267, 5);
            BtnToGeogebraCurrentShape.Name = "BtnToGeogebraCurrentShape";
            BtnToGeogebraCurrentShape.Size = new Size(105, 25);
            BtnToGeogebraCurrentShape.TabIndex = 84;
            BtnToGeogebraCurrentShape.Text = "To Geogebra";
            BtnToGeogebraCurrentShape.UseVisualStyleBackColor = true;
            BtnToGeogebraCurrentShape.Click += BtnToGeogebraCurrentShape_Click;
            // 
            // Tlp1
            // 
            Tlp1.AutoSize = true;
            Tlp1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tlp1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Tlp1.ColumnCount = 2;
            Tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            Tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlp1.Controls.Add(NudRenderClusterSize, 1, 10);
            Tlp1.Controls.Add(label6, 0, 10);
            Tlp1.Controls.Add(FlpScreenPlane, 1, 7);
            Tlp1.Controls.Add(NudScreenDistance, 1, 8);
            Tlp1.Controls.Add(label5, 0, 8);
            Tlp1.Controls.Add(label4, 0, 7);
            Tlp1.Controls.Add(label13, 0, 4);
            Tlp1.Controls.Add(label12, 0, 3);
            Tlp1.Controls.Add(NudScreenZ, 1, 4);
            Tlp1.Controls.Add(NudScreenY, 1, 3);
            Tlp1.Controls.Add(NudScreenX, 1, 2);
            Tlp1.Controls.Add(label10, 0, 2);
            Tlp1.Controls.Add(NudRenderPointSize, 1, 9);
            Tlp1.Controls.Add(label11, 0, 9);
            Tlp1.Controls.Add(NudScreenHeight, 1, 6);
            Tlp1.Controls.Add(NudPatternRatio, 1, 1);
            Tlp1.Controls.Add(NudScreenWidth, 1, 5);
            Tlp1.Controls.Add(NudParticleRadius, 1, 0);
            Tlp1.Controls.Add(label3, 0, 6);
            Tlp1.Controls.Add(label2, 0, 1);
            Tlp1.Controls.Add(label1, 0, 5);
            Tlp1.Controls.Add(label9, 0, 0);
            Tlp1.Location = new System.Drawing.Point(718, 3);
            Tlp1.Name = "Tlp1";
            Tlp1.RowCount = 11;
            Tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Tlp1.Size = new Size(357, 320);
            Tlp1.TabIndex = 37;
            // 
            // NudRenderClusterSize
            // 
            NudRenderClusterSize.BackColor = Color.WhiteSmoke;
            NudRenderClusterSize.BorderStyle = BorderStyle.FixedSingle;
            NudRenderClusterSize.DecimalPlaces = 14;
            NudRenderClusterSize.Dock = DockStyle.Top;
            NudRenderClusterSize.Location = new System.Drawing.Point(185, 294);
            NudRenderClusterSize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NudRenderClusterSize.Minimum = new decimal(new int[] { 1, 0, 0, 917504 });
            NudRenderClusterSize.Name = "NudRenderClusterSize";
            NudRenderClusterSize.Size = new Size(168, 23);
            NudRenderClusterSize.TabIndex = 98;
            NudRenderClusterSize.Value = new decimal(new int[] { 1, 0, 0, 393216 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new System.Drawing.Point(4, 297);
            label6.Margin = new Padding(3, 6, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(174, 15);
            label6.TabIndex = 97;
            label6.Text = "Render cluster size";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FlpScreenPlane
            // 
            FlpScreenPlane.AutoSize = true;
            FlpScreenPlane.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlpScreenPlane.Controls.Add(RdbScreenPlaneXy);
            FlpScreenPlane.Controls.Add(RdbScreenPlaneXz);
            FlpScreenPlane.Controls.Add(RdbScreenPlaneYz);
            FlpScreenPlane.Location = new System.Drawing.Point(185, 207);
            FlpScreenPlane.Name = "FlpScreenPlane";
            FlpScreenPlane.Size = new Size(135, 22);
            FlpScreenPlane.TabIndex = 90;
            FlpScreenPlane.Tag = "Xy";
            // 
            // RdbScreenPlaneXy
            // 
            RdbScreenPlaneXy.AutoSize = true;
            RdbScreenPlaneXy.Checked = true;
            RdbScreenPlaneXy.Location = new System.Drawing.Point(3, 3);
            RdbScreenPlaneXy.Name = "RdbScreenPlaneXy";
            RdbScreenPlaneXy.Size = new Size(39, 19);
            RdbScreenPlaneXy.TabIndex = 87;
            RdbScreenPlaneXy.TabStop = true;
            RdbScreenPlaneXy.Tag = "Xy";
            RdbScreenPlaneXy.Text = "XY";
            RdbScreenPlaneXy.UseVisualStyleBackColor = true;
            RdbScreenPlaneXy.CheckedChanged += RdbScreenPlane_CheckedChanged;
            // 
            // RdbScreenPlaneXz
            // 
            RdbScreenPlaneXz.AutoSize = true;
            RdbScreenPlaneXz.Location = new System.Drawing.Point(48, 3);
            RdbScreenPlaneXz.Name = "RdbScreenPlaneXz";
            RdbScreenPlaneXz.Size = new Size(39, 19);
            RdbScreenPlaneXz.TabIndex = 88;
            RdbScreenPlaneXz.Tag = "Xz";
            RdbScreenPlaneXz.Text = "XZ";
            RdbScreenPlaneXz.UseVisualStyleBackColor = true;
            RdbScreenPlaneXz.CheckedChanged += RdbScreenPlane_CheckedChanged;
            // 
            // RdbScreenPlaneYz
            // 
            RdbScreenPlaneYz.AutoSize = true;
            RdbScreenPlaneYz.Location = new System.Drawing.Point(93, 3);
            RdbScreenPlaneYz.Name = "RdbScreenPlaneYz";
            RdbScreenPlaneYz.Size = new Size(39, 19);
            RdbScreenPlaneYz.TabIndex = 89;
            RdbScreenPlaneYz.Tag = "Yz";
            RdbScreenPlaneYz.Text = "YZ";
            RdbScreenPlaneYz.UseVisualStyleBackColor = true;
            RdbScreenPlaneYz.CheckedChanged += RdbScreenPlane_CheckedChanged;
            // 
            // NudScreenDistance
            // 
            NudScreenDistance.BackColor = Color.WhiteSmoke;
            NudScreenDistance.BorderStyle = BorderStyle.FixedSingle;
            NudScreenDistance.DecimalPlaces = 14;
            NudScreenDistance.Dock = DockStyle.Top;
            NudScreenDistance.Location = new System.Drawing.Point(185, 236);
            NudScreenDistance.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            NudScreenDistance.Minimum = new decimal(new int[] { 1, 0, 0, 524288 });
            NudScreenDistance.Name = "NudScreenDistance";
            NudScreenDistance.Size = new Size(168, 23);
            NudScreenDistance.TabIndex = 96;
            NudScreenDistance.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new System.Drawing.Point(4, 239);
            label5.Margin = new Padding(3, 6, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(174, 15);
            label5.TabIndex = 95;
            label5.Text = "Screen distance";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new System.Drawing.Point(4, 210);
            label4.Margin = new Padding(3, 6, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 15);
            label4.TabIndex = 94;
            label4.Text = "Screen plane";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Top;
            label13.Location = new System.Drawing.Point(4, 123);
            label13.Margin = new Padding(3, 6, 3, 0);
            label13.Name = "label13";
            label13.Size = new Size(174, 15);
            label13.TabIndex = 89;
            label13.Text = "Screen z";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Top;
            label12.Location = new System.Drawing.Point(4, 94);
            label12.Margin = new Padding(3, 6, 3, 0);
            label12.Name = "label12";
            label12.Size = new Size(174, 15);
            label12.TabIndex = 88;
            label12.Text = "Screen y";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NudScreenZ
            // 
            NudScreenZ.BackColor = Color.WhiteSmoke;
            NudScreenZ.BorderStyle = BorderStyle.FixedSingle;
            NudScreenZ.DecimalPlaces = 14;
            NudScreenZ.Dock = DockStyle.Top;
            NudScreenZ.Location = new System.Drawing.Point(185, 120);
            NudScreenZ.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            NudScreenZ.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            NudScreenZ.Name = "NudScreenZ";
            NudScreenZ.Size = new Size(168, 23);
            NudScreenZ.TabIndex = 87;
            // 
            // NudScreenY
            // 
            NudScreenY.BackColor = Color.WhiteSmoke;
            NudScreenY.BorderStyle = BorderStyle.FixedSingle;
            NudScreenY.DecimalPlaces = 14;
            NudScreenY.Dock = DockStyle.Top;
            NudScreenY.Location = new System.Drawing.Point(185, 91);
            NudScreenY.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            NudScreenY.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            NudScreenY.Name = "NudScreenY";
            NudScreenY.Size = new Size(168, 23);
            NudScreenY.TabIndex = 86;
            NudScreenY.Value = new decimal(new int[] { 5, 0, 0, -2147352576 });
            // 
            // NudScreenX
            // 
            NudScreenX.BackColor = Color.WhiteSmoke;
            NudScreenX.BorderStyle = BorderStyle.FixedSingle;
            NudScreenX.DecimalPlaces = 14;
            NudScreenX.Dock = DockStyle.Top;
            NudScreenX.Location = new System.Drawing.Point(185, 62);
            NudScreenX.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            NudScreenX.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            NudScreenX.Name = "NudScreenX";
            NudScreenX.Size = new Size(168, 23);
            NudScreenX.TabIndex = 85;
            NudScreenX.Value = new decimal(new int[] { 5, 0, 0, -2147352576 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Location = new System.Drawing.Point(4, 65);
            label10.Margin = new Padding(3, 6, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(174, 15);
            label10.TabIndex = 84;
            label10.Text = "Screen x";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NudRenderPointSize
            // 
            NudRenderPointSize.BackColor = Color.WhiteSmoke;
            NudRenderPointSize.BorderStyle = BorderStyle.FixedSingle;
            NudRenderPointSize.DecimalPlaces = 14;
            NudRenderPointSize.Dock = DockStyle.Top;
            NudRenderPointSize.Location = new System.Drawing.Point(185, 265);
            NudRenderPointSize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NudRenderPointSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudRenderPointSize.Name = "NudRenderPointSize";
            NudRenderPointSize.Size = new Size(168, 23);
            NudRenderPointSize.TabIndex = 75;
            NudRenderPointSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Top;
            label11.Location = new System.Drawing.Point(4, 268);
            label11.Margin = new Padding(3, 6, 3, 0);
            label11.Name = "label11";
            label11.Size = new Size(174, 15);
            label11.TabIndex = 44;
            label11.Text = "Render point size";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NudScreenHeight
            // 
            NudScreenHeight.BackColor = Color.WhiteSmoke;
            NudScreenHeight.BorderStyle = BorderStyle.FixedSingle;
            NudScreenHeight.DecimalPlaces = 14;
            NudScreenHeight.Dock = DockStyle.Top;
            NudScreenHeight.Location = new System.Drawing.Point(185, 178);
            NudScreenHeight.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            NudScreenHeight.Minimum = new decimal(new int[] { 1, 0, 0, 524288 });
            NudScreenHeight.Name = "NudScreenHeight";
            NudScreenHeight.Size = new Size(168, 23);
            NudScreenHeight.TabIndex = 74;
            NudScreenHeight.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // NudPatternRatio
            // 
            NudPatternRatio.BackColor = Color.WhiteSmoke;
            NudPatternRatio.BorderStyle = BorderStyle.FixedSingle;
            NudPatternRatio.DecimalPlaces = 14;
            NudPatternRatio.Dock = DockStyle.Top;
            NudPatternRatio.Location = new System.Drawing.Point(185, 33);
            NudPatternRatio.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudPatternRatio.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudPatternRatio.Name = "NudPatternRatio";
            NudPatternRatio.Size = new Size(168, 23);
            NudPatternRatio.TabIndex = 68;
            NudPatternRatio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NudScreenWidth
            // 
            NudScreenWidth.BackColor = Color.WhiteSmoke;
            NudScreenWidth.BorderStyle = BorderStyle.FixedSingle;
            NudScreenWidth.DecimalPlaces = 14;
            NudScreenWidth.Dock = DockStyle.Top;
            NudScreenWidth.Location = new System.Drawing.Point(185, 149);
            NudScreenWidth.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            NudScreenWidth.Minimum = new decimal(new int[] { 1, 0, 0, 524288 });
            NudScreenWidth.Name = "NudScreenWidth";
            NudScreenWidth.Size = new Size(168, 23);
            NudScreenWidth.TabIndex = 67;
            NudScreenWidth.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // NudParticleRadius
            // 
            NudParticleRadius.BackColor = Color.WhiteSmoke;
            NudParticleRadius.BorderStyle = BorderStyle.FixedSingle;
            NudParticleRadius.DecimalPlaces = 14;
            NudParticleRadius.Dock = DockStyle.Top;
            NudParticleRadius.Location = new System.Drawing.Point(185, 4);
            NudParticleRadius.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudParticleRadius.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            NudParticleRadius.Name = "NudParticleRadius";
            NudParticleRadius.Size = new Size(168, 23);
            NudParticleRadius.TabIndex = 44;
            NudParticleRadius.Value = new decimal(new int[] { 1, 0, 0, 262144 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new System.Drawing.Point(4, 181);
            label3.Margin = new Padding(3, 6, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 15);
            label3.TabIndex = 43;
            label3.Text = "Screen height";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new System.Drawing.Point(4, 36);
            label2.Margin = new Padding(3, 6, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 15);
            label2.TabIndex = 42;
            label2.Text = "Pattern ratio";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new System.Drawing.Point(4, 152);
            label1.Margin = new Padding(3, 6, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 41;
            label1.Text = "Screen width";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Location = new System.Drawing.Point(4, 7);
            label9.Margin = new Padding(3, 6, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(174, 15);
            label9.TabIndex = 40;
            label9.Text = "Particle radius";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnShowList
            // 
            BtnShowList.AutoSize = true;
            BtnShowList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnShowList.Enabled = false;
            BtnShowList.FlatStyle = FlatStyle.Flat;
            BtnShowList.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnShowList.Location = new System.Drawing.Point(90, 3);
            BtnShowList.Name = "BtnShowList";
            BtnShowList.Size = new Size(66, 25);
            BtnShowList.TabIndex = 36;
            BtnShowList.Text = "Show list";
            BtnShowList.UseVisualStyleBackColor = true;
            BtnShowList.Click += BtnShowList_Click;
            // 
            // BtnClearList
            // 
            BtnClearList.AutoSize = true;
            BtnClearList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnClearList.Enabled = false;
            BtnClearList.FlatStyle = FlatStyle.Flat;
            BtnClearList.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClearList.Location = new System.Drawing.Point(12, 361);
            BtnClearList.Name = "BtnClearList";
            BtnClearList.Size = new Size(63, 25);
            BtnClearList.TabIndex = 35;
            BtnClearList.Text = "Clear list";
            BtnClearList.UseVisualStyleBackColor = true;
            BtnClearList.Click += BtnClearList_Click;
            // 
            // BtnRemoveSelected
            // 
            BtnRemoveSelected.AutoSize = true;
            BtnRemoveSelected.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRemoveSelected.Enabled = false;
            BtnRemoveSelected.FlatStyle = FlatStyle.Flat;
            BtnRemoveSelected.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRemoveSelected.Location = new System.Drawing.Point(81, 361);
            BtnRemoveSelected.Name = "BtnRemoveSelected";
            BtnRemoveSelected.Size = new Size(104, 25);
            BtnRemoveSelected.TabIndex = 34;
            BtnRemoveSelected.Text = "Remove selected";
            BtnRemoveSelected.UseVisualStyleBackColor = true;
            BtnRemoveSelected.Click += BtnRemoveSelected_Click;
            // 
            // BtnAddToList
            // 
            BtnAddToList.AutoSize = true;
            BtnAddToList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAddToList.FlatStyle = FlatStyle.Flat;
            BtnAddToList.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAddToList.Location = new System.Drawing.Point(12, 3);
            BtnAddToList.Name = "BtnAddToList";
            BtnAddToList.Size = new Size(72, 25);
            BtnAddToList.TabIndex = 33;
            BtnAddToList.Text = "Add to list";
            BtnAddToList.UseVisualStyleBackColor = true;
            BtnAddToList.Click += BtnAddToList_Click;
            // 
            // Lsb
            // 
            Lsb.HorizontalScrollbar = true;
            Lsb.ItemHeight = 15;
            Lsb.Location = new System.Drawing.Point(12, 36);
            Lsb.Name = "Lsb";
            Lsb.Size = new Size(700, 319);
            Lsb.TabIndex = 0;
            Lsb.SelectedIndexChanged += Lsb_SelectedIndexChanged;
            // 
            // BtnRenderCurrentShape
            // 
            BtnRenderCurrentShape.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRenderCurrentShape.Location = new System.Drawing.Point(1081, 5);
            BtnRenderCurrentShape.Name = "BtnRenderCurrentShape";
            BtnRenderCurrentShape.Size = new Size(180, 25);
            BtnRenderCurrentShape.TabIndex = 83;
            BtnRenderCurrentShape.Text = "Render current shape";
            BtnRenderCurrentShape.UseVisualStyleBackColor = true;
            BtnRenderCurrentShape.Click += BtnRenderCurrentShape_Click;
            // 
            // BtnRenderList
            // 
            BtnRenderList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRenderList.Location = new System.Drawing.Point(1081, 34);
            BtnRenderList.Name = "BtnRenderList";
            BtnRenderList.Size = new Size(180, 25);
            BtnRenderList.TabIndex = 80;
            BtnRenderList.Text = "Render list";
            BtnRenderList.UseVisualStyleBackColor = true;
            BtnRenderList.Click += BtnRenderList_Click;
            // 
            // BtnSaveList
            // 
            BtnSaveList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSaveList.Location = new System.Drawing.Point(1081, 65);
            BtnSaveList.Name = "BtnSaveList";
            BtnSaveList.Size = new Size(180, 25);
            BtnSaveList.TabIndex = 81;
            BtnSaveList.Text = "Save list";
            BtnSaveList.UseVisualStyleBackColor = true;
            BtnSaveList.Click += BtnSaveList_Click;
            // 
            // BtnRenderFolder
            // 
            BtnRenderFolder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRenderFolder.Location = new System.Drawing.Point(1081, 127);
            BtnRenderFolder.Name = "BtnRenderFolder";
            BtnRenderFolder.Size = new Size(180, 25);
            BtnRenderFolder.TabIndex = 82;
            BtnRenderFolder.Text = "Render folder";
            BtnRenderFolder.UseVisualStyleBackColor = true;
            BtnRenderFolder.Click += BtnRenderFolder_Click;
            // 
            // Ofd
            // 
            Ofd.Filter = "XML Files | *.xml";
            // 
            // Sfd
            // 
            Sfd.Filter = "XML Files | *.xml";
            // 
            // Mns
            // 
            Mns.Items.AddRange(new ToolStripItem[] { SmiFileMenu, SmiDrawMenu, SmiPackingMenu, SmiAlgebraMenu, SmiSegmentMenu, SmiCircleMenu, SmiEllipseMenu, SmiOpenGlMenu, SmiOrbitMenu });
            Mns.Location = new System.Drawing.Point(0, 0);
            Mns.Name = "Mns";
            Mns.Size = new Size(1491, 24);
            Mns.TabIndex = 41;
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
            // SmiDrawMenu
            // 
            SmiDrawMenu.DropDownItems.AddRange(new ToolStripItem[] { SmiPoint, SmiLine, SmiRectangle, SmiRectangularArea, SmiQuadrangular, SmiCircle, SmiDisc, SmiCylinder, SmiCylindricalShell, SmiSphere, SmiSphericalShell, SmiSpheroid, SmiSpheroidicalShell, SmiEllipsoid, SmiEllipsoidalShell, SmiPolygon, SmiPolygonArea, SmiPolygonPrism });
            SmiDrawMenu.Name = "SmiDrawMenu";
            SmiDrawMenu.Size = new Size(46, 20);
            SmiDrawMenu.Tag = "UctPoint";
            SmiDrawMenu.Text = "Draw";
            // 
            // SmiPoint
            // 
            SmiPoint.Name = "SmiPoint";
            SmiPoint.Size = new Size(166, 22);
            SmiPoint.Tag = "UctPoint";
            SmiPoint.Text = "Point";
            SmiPoint.Click += SmiDrawMenu_Click;
            // 
            // SmiLine
            // 
            SmiLine.Name = "SmiLine";
            SmiLine.Size = new Size(166, 22);
            SmiLine.Tag = "UctLine";
            SmiLine.Text = "Line";
            SmiLine.Click += SmiDrawMenu_Click;
            // 
            // SmiRectangle
            // 
            SmiRectangle.Name = "SmiRectangle";
            SmiRectangle.Size = new Size(166, 22);
            SmiRectangle.Tag = "UctRectangle";
            SmiRectangle.Text = "Rectangle";
            SmiRectangle.Click += SmiDrawMenu_Click;
            // 
            // SmiRectangularArea
            // 
            SmiRectangularArea.Name = "SmiRectangularArea";
            SmiRectangularArea.Size = new Size(166, 22);
            SmiRectangularArea.Tag = "UctRectangularArea";
            SmiRectangularArea.Text = "Rectangular area";
            SmiRectangularArea.Click += SmiDrawMenu_Click;
            // 
            // SmiQuadrangular
            // 
            SmiQuadrangular.Name = "SmiQuadrangular";
            SmiQuadrangular.Size = new Size(166, 22);
            SmiQuadrangular.Tag = "UctQuadrangular";
            SmiQuadrangular.Text = "Quadrangular";
            SmiQuadrangular.Click += SmiDrawMenu_Click;
            // 
            // SmiCircle
            // 
            SmiCircle.Name = "SmiCircle";
            SmiCircle.Size = new Size(166, 22);
            SmiCircle.Tag = "UctCircle";
            SmiCircle.Text = "Circle";
            SmiCircle.Click += SmiDrawMenu_Click;
            // 
            // SmiDisc
            // 
            SmiDisc.Name = "SmiDisc";
            SmiDisc.Size = new Size(166, 22);
            SmiDisc.Tag = "UctDisc";
            SmiDisc.Text = "Disc";
            SmiDisc.Click += SmiDrawMenu_Click;
            // 
            // SmiCylinder
            // 
            SmiCylinder.Name = "SmiCylinder";
            SmiCylinder.Size = new Size(166, 22);
            SmiCylinder.Tag = "UctCylinder";
            SmiCylinder.Text = "Cylinder";
            SmiCylinder.Click += SmiDrawMenu_Click;
            // 
            // SmiCylindricalShell
            // 
            SmiCylindricalShell.Name = "SmiCylindricalShell";
            SmiCylindricalShell.Size = new Size(166, 22);
            SmiCylindricalShell.Tag = "UctCylindricalShell";
            SmiCylindricalShell.Text = "Cylindrical shell";
            SmiCylindricalShell.Click += SmiDrawMenu_Click;
            // 
            // SmiSphere
            // 
            SmiSphere.Name = "SmiSphere";
            SmiSphere.Size = new Size(166, 22);
            SmiSphere.Tag = "UctSphere";
            SmiSphere.Text = "Sphere";
            SmiSphere.Click += SmiDrawMenu_Click;
            // 
            // SmiSphericalShell
            // 
            SmiSphericalShell.Name = "SmiSphericalShell";
            SmiSphericalShell.Size = new Size(166, 22);
            SmiSphericalShell.Tag = "UctSphericalShell";
            SmiSphericalShell.Text = "Spherical shell";
            SmiSphericalShell.Click += SmiDrawMenu_Click;
            // 
            // SmiSpheroid
            // 
            SmiSpheroid.Name = "SmiSpheroid";
            SmiSpheroid.Size = new Size(166, 22);
            SmiSpheroid.Tag = "UctSpheroid";
            SmiSpheroid.Text = "Spheroid";
            SmiSpheroid.Click += SmiDrawMenu_Click;
            // 
            // SmiSpheroidicalShell
            // 
            SmiSpheroidicalShell.Name = "SmiSpheroidicalShell";
            SmiSpheroidicalShell.Size = new Size(166, 22);
            SmiSpheroidicalShell.Tag = "UctSpheroidicalShell";
            SmiSpheroidicalShell.Text = "Spheroidical shell";
            SmiSpheroidicalShell.Click += SmiDrawMenu_Click;
            // 
            // SmiEllipsoid
            // 
            SmiEllipsoid.Name = "SmiEllipsoid";
            SmiEllipsoid.Size = new Size(166, 22);
            SmiEllipsoid.Tag = "UctEllipsoid";
            SmiEllipsoid.Text = "Ellipsoid";
            SmiEllipsoid.Click += SmiDrawMenu_Click;
            // 
            // SmiEllipsoidalShell
            // 
            SmiEllipsoidalShell.Name = "SmiEllipsoidalShell";
            SmiEllipsoidalShell.Size = new Size(166, 22);
            SmiEllipsoidalShell.Tag = "UctEllipsoidalShell";
            SmiEllipsoidalShell.Text = "Ellipsoidal shell";
            SmiEllipsoidalShell.Click += SmiDrawMenu_Click;
            // 
            // SmiPolygon
            // 
            SmiPolygon.Name = "SmiPolygon";
            SmiPolygon.Size = new Size(166, 22);
            SmiPolygon.Tag = "UctPolygon";
            SmiPolygon.Text = "Polygon";
            SmiPolygon.Click += SmiDrawMenu_Click;
            // 
            // SmiPolygonArea
            // 
            SmiPolygonArea.Name = "SmiPolygonArea";
            SmiPolygonArea.Size = new Size(166, 22);
            SmiPolygonArea.Tag = "UctPolygonArea";
            SmiPolygonArea.Text = "Polygon area";
            SmiPolygonArea.Click += SmiDrawMenu_Click;
            // 
            // SmiPolygonPrism
            // 
            SmiPolygonPrism.Name = "SmiPolygonPrism";
            SmiPolygonPrism.Size = new Size(166, 22);
            SmiPolygonPrism.Tag = "UctPolygonPrism";
            SmiPolygonPrism.Text = "Polygon prism";
            SmiPolygonPrism.Click += SmiDrawMenu_Click;
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
            // FrmFlatScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1491, 985);
            Controls.Add(PnlBottom);
            Controls.Add(FlpContent);
            Controls.Add(Mns);
            Name = "FrmFlatScreen";
            Text = "Orbit - Flat screen";
            WindowState = FormWindowState.Maximized;
            Load += FrmFlatScreen_Load;
            PnlBottom.ResumeLayout(false);
            PnlBottom.PerformLayout();
            Tlp1.ResumeLayout(false);
            Tlp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudRenderClusterSize).EndInit();
            FlpScreenPlane.ResumeLayout(false);
            FlpScreenPlane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudScreenDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudScreenZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudScreenY).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudScreenX).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudRenderPointSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudScreenHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudPatternRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudScreenWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudParticleRadius).EndInit();
            Mns.ResumeLayout(false);
            Mns.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog Cdi;
        private ToolTip Tlt;
        private Panel PnlBottom;
        private Button BtnRemoveSelected;
        private Button BtnAddToList;
        private Button BtnClearList;
        private Button BtnShowList;
        private TableLayoutPanel Tlp1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Button BtnRenderFolder;
        private Button BtnSaveList;
        private Button BtnRenderList;
        private Button BtnRenderCurrentShape;
        public NumericUpDown NudParticleRadius;
        public NumericUpDown NudScreenWidth;
        public NumericUpDown NudPatternRatio;
        public NumericUpDown NudScreenHeight;
        public NumericUpDown NudRenderPointSize;
        private Label label11;
        private Label label13;
        private Label label12;
        public NumericUpDown NudScreenZ;
        public NumericUpDown NudScreenY;
        public NumericUpDown NudScreenX;
        private Label label10;
        private Button BtnToGeogebraCurrentShape;
        private Button BtnLoadList;
        public FlowLayoutPanel FlpContent;
        private FolderBrowserDialog Fbd;
        private OpenFileDialog Ofd;
        private SaveFileDialog Sfd;
        public ListBox Lsb;
        private Label label4;
        public NumericUpDown NudScreenDistance;
        private Label label5;
        private RadioButton RdbScreenPlaneXy;
        private RadioButton RdbScreenPlaneXz;
        private RadioButton RdbScreenPlaneYz;
        public FlowLayoutPanel FlpScreenPlane;
        public NumericUpDown NudRenderClusterSize;
        private Label label6;
        private Button BtnRenderFolderAndSubfolders;
        private MenuStrip Mns;
        private ToolStripMenuItem SmiFileMenu;
        private ToolStripMenuItem SmiSave;
        private ToolStripMenuItem SmiLoad;
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
        private ToolStripMenuItem SmiPoint;
        private ToolStripMenuItem SmiLine;
        private ToolStripMenuItem SmiRectangle;
        private ToolStripMenuItem SmiRectangularArea;
        private ToolStripMenuItem SmiQuadrangular;
        private ToolStripMenuItem SmiCircle;
        private ToolStripMenuItem SmiDisc;
        private ToolStripMenuItem SmiCylinder;
        private ToolStripMenuItem SmiCylindricalShell;
        private ToolStripMenuItem SmiSphere;
        private ToolStripMenuItem SmiSphericalShell;
        private ToolStripMenuItem SmiSpheroid;
        private ToolStripMenuItem SmiSpheroidicalShell;
        private ToolStripMenuItem SmiEllipsoid;
        private ToolStripMenuItem SmiEllipsoidalShell;
        public ToolStripMenuItem SmiDrawMenu;
        private ToolStripMenuItem SmiOrbitMenu;
        private ToolStripMenuItem SmiFlatScreen;
        private ToolStripMenuItem SmiFlatScreenVector;
        private ToolStripMenuItem SmiSphericalScreen;
        private ToolStripMenuItem SmiSphericalScreenVector;
        private ToolStripMenuItem SmiSpace;
        private ToolStripMenuItem SmiSpaceVector;
        private ToolStripMenuItem SmiPolygon;
        private ToolStripMenuItem SmiPolygonArea;
        private ToolStripMenuItem SmiPolygonPrism;
        private ToolStripMenuItem SmiPackingMenu;
        private ToolStripMenuItem SmiPackingCirclesInACircle;
        private ToolStripMenuItem SmiPackingCirclesInASquare;
        private ToolStripMenuItem SmiPackingCirclesInARectangle;
        private ToolStripMenuItem SmiOpenGlMenu;
        private ToolStripMenuItem SmiOpenGl;
        private ToolStripMenuItem SmiTwoCircle3Projections;
    }
}