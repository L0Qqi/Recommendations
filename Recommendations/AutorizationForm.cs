using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recommendations
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void autorizationLabel_Click(object sender, EventArgs e)
        {

        }

        private void toRegLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
