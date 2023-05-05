using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        private SqlConnection sqlConnection = null;
        private static Logger logger = LogManager.GetCurrentClassLogger();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTB.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (telephoneTB.Text == "")
            {
                MessageBox.Show("Введите номер телефона");
                return;
            }
            if (bdDateTB.Text == "" && bdDateTB.Text == "Дата рождения")
            {
                MessageBox.Show("Введите дату рождения в формате MM.DD.YYYY");
                return;
            }
            if (loginRegTB.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (passwordRegTB.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            SqlCommand command = new SqlCommand("INSERT INTO [Users] (Name, Phone, Birthday, Login, Password) VALUES (@Name, @Phone, @Birthday, @Login, @Password)", 
                sqlConnection);

            //DateTime date = DateTime.Parse(bdDateTB.Text); {date.Month}/{date.Day}/{date.Year}

            command.Parameters.AddWithValue("Name", nameTB.Text);
            command.Parameters.AddWithValue("Phone", telephoneTB.Text);
            command.Parameters.AddWithValue("Birthday", bdDateTB.Text);
            command.Parameters.AddWithValue("Login", loginRegTB.Text);
            command.Parameters.AddWithValue("Password", passwordRegTB.Text);


            command.ExecuteNonQuery().ToString();

            this.Hide();
            AutorizationForm autorization = new AutorizationForm();
            autorization.Show();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            try
            {
                sqlConnection.Open();
                logger.Info("Аккаунт успешно зарегистрирован");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Error("Ошибка" + ex);
                
            }   
        }
        Point lastPoint;
        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
