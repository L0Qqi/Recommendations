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
    public partial class CategoriesForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private SqlConnection sqlConnection = null;
        private string Login;
        private DataGridViewRow selectedRow;
        public CategoriesForm(string login)
        {
            InitializeComponent();
            Login = login;
        }

        private void cCloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fromCatReturnLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecommendationsForm recommendations = new RecommendationsForm(Login);
            recommendations.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            try
            {
                sqlConnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    "SELECT * FROM Products", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                catDataGV.DataSource = dataSet.Tables[0];
                logger.Info("Подключение к базе данных произошло успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Error("Проблемы с подключением к базе данных: " + ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 1";
        }

        private void houseRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 2";
        }

        private void phoneRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 3";
        }

        private void beautiRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 4";
        }

        private void kitchenRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 5";
        }

        private void computerRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 6";
        }

        private void kidRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 7";
        }

        private void gameRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 8";
        }

        private void allRB_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * FROM Products", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            catDataGV.DataSource = dataSet.Tables[0];
        }

        Point lastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm addopen = new AddForm(Login);
            addopen.Show();
        }

        private void catDataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Сохраните выбранный элемент
                selectedRow = catDataGV.Rows[e.RowIndex];
            }
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                // Получите идентификатор выбранной строки, например, из столбца с индексом 0
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Удалите выбранный элемент из базы данных
                DeleteRowFromDatabase(id);

                // Удалите выбранную строку из DataGridView
                catDataGV.Rows.Remove(selectedRow);

                // Сбросьте переменную выбранной строки
                selectedRow = null;
            }
        }
        private void DeleteRowFromDatabase(int id)
        {
            string query = "DELETE FROM [Products] WHERE Id = @id";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            //SqlCommand command = new SqlCommand("INSERT INTO [Products] (Id, Name, Category_Id) VALUES (@Id,@Name,@Category)",
            //   sqlConnection);

            //command.Parameters.AddWithValue("Name", ObjectTB.Text);

        }
    }
}
