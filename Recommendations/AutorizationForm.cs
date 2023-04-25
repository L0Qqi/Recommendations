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

            loginTB.Text = "Логин";
            loginTB.ForeColor = Color.Gray;

            passwordTB.Text = "Пароль";
            passwordTB.ForeColor = Color.Gray;


            this.passwordTB.AutoSize = false;
            this.passwordTB.Size = new Size(this.passwordTB.Size.Width, 35);
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
            this.Hide();
            RecommendationsForm recommendations = new RecommendationsForm();
            recommendations.Show();
        }

        private void loginTB_Enter(object sender, EventArgs e)
        {
            if (loginTB.Text == "Логин")
            {
                loginTB.Text = "";
                loginTB.ForeColor = Color.Black;
            }
        }

        private void loginTB_Leave(object sender, EventArgs e)
        {
            if (loginTB.Text == "")
            {
                loginTB.Text = "Логин";
                loginTB.ForeColor = Color.Gray;
            }
        }
        private void passwordTB_Enter(object sender, EventArgs e)
        {
            if (passwordTB.Text == "Пароль")
            {
                passwordTB.UseSystemPasswordChar = true;
                passwordTB.Text = "";
                passwordTB.ForeColor = Color.Black;
            }
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (passwordTB.Text == "")
            {
                passwordTB.UseSystemPasswordChar = false;
                passwordTB.Text = "Пароль";
                passwordTB.ForeColor = Color.Gray;
            }
        }

        private void cCloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
