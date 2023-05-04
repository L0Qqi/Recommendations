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
    public partial class FavouritesForm : Form
    {
        private SqlConnection sqlConnection = null;
        private string Login;
        public FavouritesForm()
        {
            InitializeComponent();
        }

        private void fromFavReturnLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecommendationsForm recommendations = new RecommendationsForm(Login);
            recommendations.Show();
        }

        private void FavouritesForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * FROM Products WHERE Favourites = 1", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            favDataGV.DataSource = dataSet.Tables[0];
        }

        private void cCloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
