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
    public partial class AddForm : Form
    {
        private SqlConnection sqlConnection = null;
        private string Login;
        public AddForm(string login)
        {
            InitializeComponent();
            Login = login;
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rndId = random.Next(10, 1000); //был баг в системе
            int catnum = 0;
            if (tVRB.Checked) {  catnum = 1; }
            else if (houseRB.Checked) { catnum = 2; }
            else if (phoneRB.Checked){  catnum = 3; }
            else if (beautiRB.Checked){  catnum = 4; }
            else if (kitchenRB.Checked) {  catnum = 5; }
            else if (computerRB.Checked){  catnum = 6; }
            else if (kidRB.Checked){ catnum = 7; }
            else if (gameRB.Checked){ catnum = 8; }
            SqlCommand command = new SqlCommand("INSERT INTO [Products] (Id, Name, Category_Id) VALUES (@Id,@Name,@Category)",
               sqlConnection);

            command.Parameters.AddWithValue("Name", ObjectTB.Text);
            command.Parameters.AddWithValue("Category", catnum);
            command.Parameters.AddWithValue("Id", rndId);


            command.ExecuteNonQuery().ToString();


            this.Hide();
            CategoriesForm categories = new CategoriesForm(Login);
            categories.Show();

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            sqlConnection.Open();
        }
    }
}
