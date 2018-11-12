using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVision.ParameterForms
{
    public partial class CannyParametersForm : Form
    {
        Form1 frm;
        public CannyParametersForm(Form1 _frm)
        {
            InitializeComponent();
            frm = _frm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApplyCanny_Click(object sender, EventArgs e)
        {
            if (frm != null) {
                double thresh = (double)trackBarThreshold.Value;
                double threshLink = (double)trackBarThresholdLink.Value;
                frm.ApplyCannyFilter(thresh, threshLink);
            }
        }

        private void trackBarThreshold_Scroll(object sender, EventArgs e)
        {
            labelThreshValue.Text = trackBarThreshold.Value.ToString();
            labelThreshLinkValue.Text = trackBarThresholdLink.Value.ToString();
        }
    }
}
