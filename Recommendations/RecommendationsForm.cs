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
            FavouritesForm favourites = new FavouritesForm();
            favourites.Show();
        }

        private void toCategorLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm categories = new CategoriesForm();
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
            //sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            //sqlConnection.Open();
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(
            //    "SELECT * FROM Products", sqlConnection);
            //DataSet dataSet = new DataSet();
            //dataAdapter.Fill(dataSet);
            //recDGV.DataSource = dataSet.Tables[0];
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand($"SELECT Id from Users WHERE Login = '{Login}'", sqlConnection);
            //SqlDataReader reader = command.ExecuteReader();
            object result = command.ExecuteScalar();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * FROM Products", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            recDGV.DataSource = dataSet.Tables[0];

            //label1.Text = result.ToString();
            //reader.Close();
            sqlConnection.Close();
        }
    }
}
