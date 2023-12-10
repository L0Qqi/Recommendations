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
    public partial class RecommendationsForm : Form
    {
        private string Login;
        private SqlConnection sqlConnection = null;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public RecommendationsForm(string login)
        {
            InitializeComponent();

            Login = login;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalAccountForm account = new PersonalAccountForm(Login);
            account.Show(); 

        }

        private void ctLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void baskLabel_Click(object sender, EventArgs e)
        {

        }

        private void mOrdLabel_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FavouritesForm favourites = new FavouritesForm(Login);
            favourites.Show();
        }

        private void toCategorLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm categories = new CategoriesForm(Login);
            categories.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void cCloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RecommendationsForm_Load(object sender, EventArgs e)
        {
            
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand($"SELECT Id from Users WHERE Login = '{Login}'", sqlConnection);

                object result = command.ExecuteScalar();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    $"SELECT Products.Name, Categories.Name as Category, Favorites.User_id FROM Categories " +
                    $"JOIN Products ON Products.Category_Id = Categories.Id " +
                    $"JOIN Favorites ON Favorites.User_id = {result} AND Categories.Id = Categories_id",
                    sqlConnection);
                DataSet dataSet = new DataSet(Login);
                dataAdapter.Fill(dataSet);
                recDGV.DataSource = dataSet.Tables[0];

                sqlConnection.Close();
                logger.Info("Данные извлечены успешно");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                logger.Error("Проблемы с подключением к базе данных: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecEditForm recEditForm = new RecEditForm();
            recEditForm.ShowDialog();
        }
    }
}
