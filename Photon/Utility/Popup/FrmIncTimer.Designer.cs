namespace Photon
{
    partial class FrmIncTimer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NudInc = new System.Windows.Forms.NumericUpDown();
            this.NudMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NudInc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMilliseconds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Milliseconds";
            // 
            // NudInc
            // 
            this.NudInc.DecimalPlaces = 14;
            this.NudInc.Location = new System.Drawing.Point(91, 7);
            this.NudInc.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudInc.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.NudInc.Name = "NudInc";
            this.NudInc.Size = new System.Drawing.Size(150, 23);
            this.NudInc.TabIndex = 2;
            this.NudInc.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // NudMilliseconds
            // 
            this.NudMilliseconds.Location = new System.Drawing.Point(91, 36);
            this.NudMilliseconds.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudMilliseconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudMilliseconds.Name = "NudMilliseconds";
            this.NudMilliseconds.Size = new System.Drawing.Size(150, 23);
            this.NudMilliseconds.TabIndex = 3;
            this.NudMilliseconds.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(62, 75);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(143, 75);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Tmr
            // 
            this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // FrmIncTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 110);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.NudMilliseconds);
            this.Controls.Add(this.NudInc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmIncTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inc timer";
            ((System.ComponentModel.ISupportInitialize)(this.NudInc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMilliseconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown NudInc;
        private NumericUpDown NudMilliseconds;
        private Button BtnOk;
        private Button BtnCancel;
        private System.Windows.Forms.Timer Tmr;
    }
}