namespace Photon.SphericalScreen
{
    partial class FrmRender
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
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Bgw = new System.ComponentModel.BackgroundWorker();
            this.Prb = new System.Windows.Forms.ProgressBar();
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblPercent = new System.Windows.Forms.Label();
            this.PnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBottom
            // 
            this.PnlBottom.Controls.Add(this.BtnCancel);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 70);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(614, 43);
            this.PnlBottom.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(259, 8);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(96, 25);
            this.BtnCancel.TabIndex = 39;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Bgw
            // 
            this.Bgw.WorkerReportsProgress = true;
            this.Bgw.WorkerSupportsCancellation = true;
            this.Bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw_DoWork);
            this.Bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Bgw_ProgressChanged);
            this.Bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Bgw_RunWorkerCompleted);
            // 
            // Prb
            // 
            this.Prb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Prb.Location = new System.Drawing.Point(0, 15);
            this.Prb.Name = "Prb";
            this.Prb.Size = new System.Drawing.Size(614, 23);
            this.Prb.TabIndex = 1;
            // 
            // LblHeader
            // 
            this.LblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHeader.Location = new System.Drawing.Point(0, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(614, 15);
            this.LblHeader.TabIndex = 2;
            this.LblHeader.Text = "Header";
            this.LblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblPercent
            // 
            this.LblPercent.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblPercent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPercent.Location = new System.Drawing.Point(0, 38);
            this.LblPercent.Name = "LblPercent";
            this.LblPercent.Size = new System.Drawing.Size(614, 15);
            this.LblPercent.TabIndex = 3;
            this.LblPercent.Text = "Percent";
            this.LblPercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmRender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(614, 113);
            this.Controls.Add(this.LblPercent);
            this.Controls.Add(this.Prb);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.LblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Render progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRender_FormClosing);
            this.Load += new System.EventHandler(this.FrmRender_Load);
            this.PnlBottom.ResumeLayout(false);
            this.PnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlBottom;
        private System.ComponentModel.BackgroundWorker Bgw;
        private Button BtnCancel;
        private ProgressBar Prb;
        private Label LblHeader;
        private Label LblPercent;
    }
}