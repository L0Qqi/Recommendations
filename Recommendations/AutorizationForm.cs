using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Recommendations
{
    public partial class AutorizationForm : Form
    {
        private SqlConnection sqlConnection = null;
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
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM `Users` WHERE `Login` = {loginTB.Text} AND `Password`= {passwordTB.Text}",
                sqlConnection);
            DataTable table = new DataTable();

            
            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            //if (table.Rows.Count > 0)
            //{
                this.Hide();
                RecommendationsForm recommendations = new RecommendationsForm();
                recommendations.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Учетная запись не найдена ");
            //}
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

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            sqlConnection.Open();

            
        }
    }
}
