using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenaltyQuick.Views
{
    public partial class WelcomeForm : Form
    {

        public WelcomeForm()
        {
            //this.Anchor = AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Top & AnchorStyles.Bottom;
            InitializeComponent();
        }
        
        private void startLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form startForm = new StartForm();
            startForm.Show();
            this.Hide();

            
        }
    }
}
