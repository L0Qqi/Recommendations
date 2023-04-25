using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Recommendations
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            nameTB.Text = "Имя";
            nameTB.ForeColor = Color.Gray;

            telephoneTB.Text = "Номер телефона";
            telephoneTB.ForeColor = Color.Gray;

            bdDateTB.Text = "Дата рождения";
            bdDateTB.ForeColor = Color.Gray;

            loginRegTB.Text = "Логин";
            loginRegTB.ForeColor = Color.Gray;

            passwordRegTB.Text = "Пароль";
            passwordRegTB.ForeColor = Color.Gray;

  
        }

        private void nameTB_Enter(object sender, EventArgs e)
        {
            if (nameTB.Text == "Имя")
            {
                nameTB.Text = "";
                nameTB.ForeColor = Color.Black;
            }
        }

        private void nameTB_Leave(object sender, EventArgs e)
        {
            if (nameTB.Text == "")
            {
                nameTB.Text = "Имя";
                nameTB.ForeColor = Color.Gray;
            }
        }

        private void telephoneTB_Enter(object sender, EventArgs e)
        {
            if (telephoneTB.Text == "Номер телефона")
            {
                telephoneTB.Text = "";
                telephoneTB.ForeColor = Color.Black;
            }
        }

        private void telephoneTB_Leave(object sender, EventArgs e)
        {
            if (telephoneTB.Text == "")
            {
                telephoneTB.Text = "Номер телефона";
                telephoneTB.ForeColor = Color.Gray;
            }
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void bdDateTB_Enter(object sender, EventArgs e)
        {
            if (bdDateTB.Text == "Дата рождения")
            {
                bdDateTB.Text = "";
                bdDateTB.ForeColor = Color.Black;
            }
        }

        private void bdDateTB_Leave(object sender, EventArgs e)
        {
            if (bdDateTB.Text == "")
            {
                bdDateTB.Text = "Дата рождения";
                bdDateTB.ForeColor = Color.Gray;
            }
        }

        private void loginRegTB_Enter(object sender, EventArgs e)
        {
            if (loginRegTB.Text == "Логин")
            {
                loginRegTB.Text = "";
                loginRegTB.ForeColor = Color.Black;
            }
        }

        private void loginRegTB_Leave(object sender, EventArgs e)
        {
            if (loginRegTB.Text == "")
            {
                loginRegTB.Text = "Логин";
                loginRegTB.ForeColor = Color.Gray;
            }
        }

        private void passwordRegTB_Enter(object sender, EventArgs e)
        {
            if (passwordRegTB.Text == "Пароль")
            {
                passwordRegTB.Text = "";
                passwordRegTB.ForeColor = Color.Black;
            }
        }

        private void passwordRegTB_Leave(object sender, EventArgs e)
        {
            if (passwordRegTB.Text == "")
            {
                passwordRegTB.Text = "Пароль";
                passwordRegTB.ForeColor = Color.Gray;
            }
        }

        private void cCloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm autorization = new AutorizationForm();
            autorization.Show();
        }
    }
}
