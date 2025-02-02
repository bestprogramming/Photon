namespace Photon.TestIntersection
{
    partial class FrmCubic
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
            NudMaxA = new NumericUpDown();
            label3 = new Label();
            NudMinA = new NumericUpDown();
            label2 = new Label();
            NudA = new NumericUpDown();
            label1 = new Label();
            PnlFill = new Panel();
            Flp2 = new FlowLayoutPanel();
            TrbA = new TrackBar();
            TrbB = new TrackBar();
            TrbC = new TrackBar();
            TrbD = new TrackBar();
            Flp1 = new FlowLayoutPanel();
            label7 = new Label();
            NudMinB = new NumericUpDown();
            label5 = new Label();
            NudB = new NumericUpDown();
            label6 = new Label();
            NudMaxB = new NumericUpDown();
            label8 = new Label();
            NudMinC = new NumericUpDown();
            label9 = new Label();
            NudC = new NumericUpDown();
            label10 = new Label();
            NudMaxC = new NumericUpDown();
            label4 = new Label();
            NudMinD = new NumericUpDown();
            label14 = new Label();
            NudD = new NumericUpDown();
            label15 = new Label();
            NudMaxD = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)NudMaxA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudMinA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudA).BeginInit();
            PnlFill.SuspendLayout();
            Flp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrbB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrbC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrbD).BeginInit();
            Flp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudMinB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudMaxB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudMinC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudMaxC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudMinD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudMaxD).BeginInit();
            Mns.SuspendLayout();
            SuspendLayout();
            // 
            // NudMaxA
            // 
            NudMaxA.BackColor = Color.WhiteSmoke;
            NudMaxA.DecimalPlaces = 4;
            NudMaxA.Location = new System.Drawing.Point(291, 3);
            NudMaxA.Margin = new Padding(0, 3, 0, 3);
            NudMaxA.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NudMaxA.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            NudMaxA.Name = "NudMaxA";
            NudMaxA.Size = new Size(80, 23);
            NudMaxA.TabIndex = 16;
            NudMaxA.Value = new decimal(new int[] { 2, 0, 0, 131072 });
            NudMaxA.ValueChanged += FormSetting_Changed;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(261, 6);
            label3.Margin = new Padding(0, 6, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 15;
            label3.Text = "max";
            // 
            // NudMinA
            // 
            NudMinA.BackColor = Color.WhiteSmoke;
            NudMinA.DecimalPlaces = 4;
            NudMinA.Location = new System.Drawing.Point(28, 3);
            NudMinA.Margin = new Padding(0, 3, 0, 3);
            NudMinA.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NudMinA.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            NudMinA.Name = "NudMinA";
            NudMinA.Size = new Size(80, 23);
            NudMinA.TabIndex = 14;
            NudMinA.Value = new decimal(new int[] { 2, 0, 0, -2147352576 });
            NudMinA.ValueChanged += FormSetting_Changed;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(108, 6);
            label2.Margin = new Padding(0, 6, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 13;
            label2.Text = "a";
            // 
            // NudA
            // 
            NudA.BackColor = Color.WhiteSmoke;
            NudA.DecimalPlaces = 12;
            NudA.Location = new System.Drawing.Point(121, 3);
            NudA.Margin = new Padding(0, 3, 0, 3);
            NudA.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NudA.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            NudA.Name = "NudA";
            NudA.Size = new Size(140, 23);
            NudA.TabIndex = 12;
            NudA.Value = new decimal(new int[] { 4, 0, 0, -2147221504 });
            NudA.ValueChanged += FormSetting_Changed;
            NudA.Click += NudInc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 6);
            label1.Margin = new Padding(0, 6, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "min";
            // 
            // PnlFill
            // 
            PnlFill.BackColor = Color.LightGray;
            PnlFill.Controls.Add(Flp2);
            PnlFill.Controls.Add(Flp1);
            PnlFill.Controls.Add(Mns);
            PnlFill.Dock = DockStyle.Fill;
            PnlFill.Location = new System.Drawing.Point(0, 0);
            PnlFill.Name = "PnlFill";
            PnlFill.Size = new Size(1895, 553);
            PnlFill.TabIndex = 4;
            PnlFill.Paint += PnlFill_Paint;
            PnlFill.MouseDown += PnlFill_MouseDown;
            PnlFill.MouseMove += PnlFill_MouseMove;
            PnlFill.MouseUp += PnlFill_MouseUp;
            PnlFill.PreviewKeyDown += PnlFill_PreviewKeyDown;
            // 
            // Flp2
            // 
            Flp2.AutoSize = true;
            Flp2.Controls.Add(TrbA);
            Flp2.Controls.Add(TrbB);
            Flp2.Controls.Add(TrbC);
            Flp2.Controls.Add(TrbD);
            Flp2.Dock = DockStyle.Top;
            Flp2.Location = new System.Drawing.Point(0, 53);
            Flp2.Name = "Flp2";
            Flp2.Size = new Size(1895, 20);
            Flp2.TabIndex = 25;
            // 
            // TrbA
            // 
            TrbA.AutoSize = false;
            TrbA.Location = new System.Drawing.Point(0, 0);
            TrbA.Margin = new Padding(0);
            TrbA.Maximum = 100000000;
            TrbA.Name = "TrbA";
            TrbA.Size = new Size(371, 20);
            TrbA.TabIndex = 0;
            TrbA.TickStyle = TickStyle.None;
            TrbA.ValueChanged += Trb_ValueChanged;
            // 
            // TrbB
            // 
            TrbB.AutoSize = false;
            TrbB.Location = new System.Drawing.Point(401, 0);
            TrbB.Margin = new Padding(30, 0, 0, 0);
            TrbB.Maximum = 100000000;
            TrbB.Name = "TrbB";
            TrbB.Size = new Size(371, 20);
            TrbB.TabIndex = 1;
            TrbB.TickStyle = TickStyle.None;
            TrbB.ValueChanged += Trb_ValueChanged;
            // 
            // TrbC
            // 
            TrbC.AutoSize = false;
            TrbC.Location = new System.Drawing.Point(802, 0);
            TrbC.Margin = new Padding(30, 0, 0, 0);
            TrbC.Maximum = 100000000;
            TrbC.Name = "TrbC";
            TrbC.Size = new Size(371, 20);
            TrbC.TabIndex = 2;
            TrbC.TickStyle = TickStyle.None;
            TrbC.Value = 30000;
            TrbC.ValueChanged += Trb_ValueChanged;
            // 
            // TrbD
            // 
            TrbD.AutoSize = false;
            TrbD.Location = new System.Drawing.Point(1203, 0);
            TrbD.Margin = new Padding(30, 0, 0, 0);
            TrbD.Maximum = 100000000;
            TrbD.Name = "TrbD";
            TrbD.Size = new Size(371, 20);
            TrbD.TabIndex = 3;
            TrbD.TickStyle = TickStyle.None;
            TrbD.Value = 200000;
            TrbD.ValueChanged += Trb_ValueChanged;
            // 
            // Flp1
            // 
            Flp1.AutoSize = true;
            Flp1.BackColor = Color.LightGray;
            Flp1.Controls.Add(label1);
            Flp1.Controls.Add(NudMinA);
            Flp1.Controls.Add(label2);
            Flp1.Controls.Add(NudA);
            Flp1.Controls.Add(label3);
            Flp1.Controls.Add(NudMaxA);
            Flp1.Controls.Add(label7);
            Flp1.Controls.Add(NudMinB);
            Flp1.Controls.Add(label5);
            Flp1.Controls.Add(NudB);
            Flp1.Controls.Add(label6);
            Flp1.Controls.Add(NudMaxB);
            Flp1.Controls.Add(label8);
            Flp1.Controls.Add(NudMinC);
            Flp1.Controls.Add(label9);
            Flp1.Controls.Add(NudC);
            Flp1.Controls.Add(label10);
            Flp1.Controls.Add(NudMaxC);
            Flp1.Controls.Add(label4);
            Flp1.Controls.Add(NudMinD);
            Flp1.Controls.Add(label14);
            Flp1.Controls.Add(NudD);
            Flp1.Controls.Add(label15);
            Flp1.Controls.Add(NudMaxD);
            Flp1.Dock = DockStyle.Top;
            Flp1.Location = new System.Drawing.Point(0, 24);
            Flp1.Name = "Flp1";
            Flp1.Size = new Size(1895, 29);
            Flp1.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(401, 6);
            label7.Margin = new Padding(30, 6, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 35;
            label7.Text = "min";
            // 
            // NudMinB
            // 
            NudMinB.BackColor = Color.WhiteSmoke;
            NudMinB.DecimalPlaces = 4;
            NudMinB.Location = new System.Drawing.Point(429, 3);
            NudMinB.Margin = new Padding(0, 3, 0, 3);
            NudMinB.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NudMinB.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            NudMinB.Name = "NudMinB";
            NudMinB.Size = new Size(80, 23);
            NudMinB.TabIndex = 36;
            NudMinB.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            NudMinB.ValueChanged += FormSetting_Changed;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(509, 6);
            label5.Margin = new Padding(0, 6, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 21;
            label5.Text = "b";
            // 
            // NudB
            // 
            NudB.BackColor = Color.WhiteSmoke;
            NudB.DecimalPlaces = 12;
            NudB.Location = new System.Drawing.Point(523, 3);
            NudB.Margin = new Padding(0, 3, 0, 3);
            NudB.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NudB.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            NudB.Name = "NudB";
            NudB.Size = new Size(140, 23);
            NudB.TabIndex = 24;
            NudB.Value = new decimal(new int[] { 5, 0, 0, -2147352576 });
            NudB.ValueChanged += FormSetting_Changed;
            NudB.Click += NudInc_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(663, 6);
            label6.Margin = new Padding(0, 6, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 23;
            label6.Text = "max";
            // 
            // NudMaxB
            // 
            NudMaxB.BackColor = Color.WhiteSmoke;
            NudMaxB.DecimalPlaces = 4;
            NudMaxB.Location = new System.Drawing.Point(693, 3);
            NudMaxB.Margin = new Padding(0, 3, 0, 3);
            NudMaxB.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NudMaxB.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            NudMaxB.Name = "NudMaxB";
            NudMaxB.Size = new Size(80, 23);
            NudMaxB.TabIndex = 22;
            NudMaxB.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NudMaxB.ValueChanged += FormSetting_Changed;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(803, 6);
            label8.Margin = new Padding(30, 6, 0, 0);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 25;
            label8.Text = "min";
            // 
            // NudMinC
            // 
            NudMinC.BackColor = Color.WhiteSmoke;
            NudMinC.DecimalPlaces = 4;
            NudMinC.Location = new System.Drawing.Point(831, 3);
            NudMinC.Margin = new Padding(0, 3, 0, 3);
            NudMinC.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NudMinC.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            NudMinC.Name = "NudMinC";
            NudMinC.Size = new Size(80, 23);
            NudMinC.TabIndex = 26;
            NudMinC.Value = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NudMinC.ValueChanged += FormSetting_Changed;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(911, 6);
            label9.Margin = new Padding(0, 6, 0, 0);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 37;
            label9.Text = "c";
            // 
            // NudC
            // 
            NudC.BackColor = Color.WhiteSmoke;
            NudC.DecimalPlaces = 12;
            NudC.Location = new System.Drawing.Point(924, 3);
            NudC.Margin = new Padding(0, 3, 0, 3);
            NudC.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NudC.Name = "NudC";
            NudC.Size = new Size(140, 23);
            NudC.TabIndex = 38;
            NudC.Value = new decimal(new int[] { 3, 0, 0, 0 });
            NudC.ValueChanged += FormSetting_Changed;
            NudC.Click += NudInc_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(1064, 6);
            label10.Margin = new Padding(0, 6, 0, 0);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 39;
            label10.Text = "max";
            // 
            // NudMaxC
            // 
            NudMaxC.BackColor = Color.WhiteSmoke;
            NudMaxC.DecimalPlaces = 4;
            NudMaxC.Location = new System.Drawing.Point(1094, 3);
            NudMaxC.Margin = new Padding(0, 3, 0, 3);
            NudMaxC.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NudMaxC.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            NudMaxC.Name = "NudMaxC";
            NudMaxC.Size = new Size(80, 23);
            NudMaxC.TabIndex = 40;
            NudMaxC.Value = new decimal(new int[] { 100, 0, 0, 0 });
            NudMaxC.ValueChanged += FormSetting_Changed;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(1204, 6);
            label4.Margin = new Padding(30, 6, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 47;
            label4.Text = "min";
            // 
            // NudMinD
            // 
            NudMinD.BackColor = Color.WhiteSmoke;
            NudMinD.DecimalPlaces = 4;
            NudMinD.Location = new System.Drawing.Point(1232, 3);
            NudMinD.Margin = new Padding(0, 3, 0, 3);
            NudMinD.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NudMinD.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            NudMinD.Name = "NudMinD";
            NudMinD.Size = new Size(80, 23);
            NudMinD.TabIndex = 48;
            NudMinD.Value = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NudMinD.ValueChanged += FormSetting_Changed;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(1312, 6);
            label14.Margin = new Padding(0, 6, 0, 0);
            label14.Name = "label14";
            label14.Size = new Size(14, 15);
            label14.TabIndex = 49;
            label14.Text = "d";
            // 
            // NudD
            // 
            NudD.BackColor = Color.WhiteSmoke;
            NudD.DecimalPlaces = 12;
            NudD.Location = new System.Drawing.Point(1326, 3);
            NudD.Margin = new Padding(0, 3, 0, 3);
            NudD.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NudD.Name = "NudD";
            NudD.Size = new Size(140, 23);
            NudD.TabIndex = 50;
            NudD.Value = new decimal(new int[] { 20, 0, 0, 0 });
            NudD.ValueChanged += FormSetting_Changed;
            NudD.Click += NudInc_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(1466, 6);
            label15.Margin = new Padding(0, 6, 0, 0);
            label15.Name = "label15";
            label15.Size = new Size(30, 15);
            label15.TabIndex = 51;
            label15.Text = "max";
            // 
            // NudMaxD
            // 
            NudMaxD.BackColor = Color.WhiteSmoke;
            NudMaxD.DecimalPlaces = 4;
            NudMaxD.Location = new System.Drawing.Point(1496, 3);
            NudMaxD.Margin = new Padding(0, 3, 0, 3);
            NudMaxD.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NudMaxD.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            NudMaxD.Name = "NudMaxD";
            NudMaxD.Size = new Size(80, 23);
            NudMaxD.TabIndex = 52;
            NudMaxD.Value = new decimal(new int[] { 100, 0, 0, 0 });
            NudMaxD.ValueChanged += FormSetting_Changed;
            // 
            // Mns
            // 
            Mns.Items.AddRange(new ToolStripItem[] { SmiFileMenu, SmiPackingMenu, SmiAlgebraMenu, SmiSegmentMenu, SmiCircleMenu, SmiEllipseMenu, SmiOpenGlMenu, SmiOrbitMenu });
            Mns.Location = new System.Drawing.Point(0, 0);
            Mns.Name = "Mns";
            Mns.Size = new Size(1895, 24);
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
            SmiQuadratic.Size = new Size(180, 22);
            SmiQuadratic.Text = "Quadratic";
            SmiQuadratic.Click += Smi_Click;
            // 
            // SmiCubic
            // 
            SmiCubic.Name = "SmiCubic";
            SmiCubic.Size = new Size(180, 22);
            SmiCubic.Text = "Cubic";
            SmiCubic.Click += Smi_Click;
            // 
            // SmiQuartic
            // 
            SmiQuartic.Name = "SmiQuartic";
            SmiQuartic.Size = new Size(180, 22);
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
            // FrmCubic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1895, 553);
            Controls.Add(PnlFill);
            Name = "FrmCubic";
            Text = "Algebra (Cubic)";
            WindowState = FormWindowState.Maximized;
            Load += FrmCubic_Load;
            ((System.ComponentModel.ISupportInitialize)NudMaxA).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudMinA).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudA).EndInit();
            PnlFill.ResumeLayout(false);
            PnlFill.PerformLayout();
            Flp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TrbA).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrbB).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrbC).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrbD).EndInit();
            Flp1.ResumeLayout(false);
            Flp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudMinB).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudB).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudMaxB).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudMinC).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudC).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudMaxC).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudMinD).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudD).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudMaxD).EndInit();
            Mns.ResumeLayout(false);
            Mns.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PnlFill;
        private Label label1;
        private NumericUpDown NudMaxA;
        private Label label3;
        private NumericUpDown NudMinA;
        private Label label2;
        private NumericUpDown NudA;
        private FlowLayoutPanel Flp1;
        private Label label5;
        private NumericUpDown NudB;
        private Label label6;
        private NumericUpDown NudMaxB;
        private Label label8;
        private NumericUpDown NudMinC;
        private Label label7;
        private NumericUpDown NudMinB;
        private Label label9;
        private NumericUpDown NudC;
        private FlowLayoutPanel Flp2;
        private TrackBar TrbA;
        private Label label10;
        private NumericUpDown NudMaxC;
        private TrackBar TrbB;
        private TrackBar TrbC;
        private TrackBar TrbD;
        private Label label4;
        private NumericUpDown NudMinD;
        private Label label14;
        private NumericUpDown NudD;
        private Label label15;
        private NumericUpDown NudMaxD;
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