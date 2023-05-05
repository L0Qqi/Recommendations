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

namespace Recommendations
{
    public partial class PersonalAccountForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger(); 
        private SqlConnection sqlConnection = null;
        private string Login;
        public PersonalAccountForm(string login)
        {
            InitializeComponent();
            Login = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void forMeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void recSettingsButton_Click(object sender, EventArgs e)
        {
            
            SettingsForm settings = new SettingsForm();
            settings.Show();
        }

        private void toCatButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm categories = new CategoriesForm();
            categories.Show();
        }

        private void toRecButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecommendationsForm rec = new RecommendationsForm(Login);
            rec.Show();
        }

        private void toFavButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FavouritesForm favourites = new FavouritesForm();
            favourites.Show();
        }

        private void PersonalAccountForm_Load(object sender, EventArgs e)
        {
            
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand($"SELECT Name from Users WHERE Login = '{Login}'", sqlConnection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nameShowLabel.Text = reader["Name"].ToString();


                }
                reader.Close();
                sqlConnection.Close();
                logger.Info("Имя успешно взято из базы данных");
            }
            catch (Exception ex)  
            {
                logger.Error("Ошибка с подключением к базе данных :" + ex);
            }
        }

        private void cCloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;

        private void PersonalAccountForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PersonalAccountForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
    
}
