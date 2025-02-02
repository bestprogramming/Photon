using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photon
{
    public partial class FrmIncTimer : Form
    {
        public NumericUpDown? Nud;
        public Action? Change;

        public FrmIncTimer()
        {
            InitializeComponent();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            if (Nud != null)
            {
                Nud.Value += NudInc.Value;
            }

            Change?.Invoke();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Tmr.Interval = NudMilliseconds.ToInt();
            Tmr.Enabled = true;
            Tmr.Start();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Tmr.Stop();
        }
    }
}
