using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recommendations
{
    public partial class SettingsForm : Form
    {
        private SqlConnection sqlConnection = null;
        private string Login;
        public SettingsForm(string login)
        {
            InitializeComponent();
            Login = login;
        }

        private void cCloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

        }

        public int GetUserIdFromDatabase(string login)
        {
            sqlConnection.Open();
            int userId = 0;
            // Создание SQL-запроса для получения user_id по login
            string query = "SELECT User_id FROM Users WHERE Login = @Login";


            SqlCommand command = new SqlCommand(query, sqlConnection);
           
                // Добавление параметра для передачи значения login
                command.Parameters.AddWithValue("@Login", login);

                // Выполнение SQL-запроса и получение user_id
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    userId = Convert.ToInt32(result);
                }

                return userId;
        }
        public List<int> GetObjectIdsFromDatabase(int userId)
        {
            List<int> objectIds = new List<int>();
            sqlConnection.Open();
            

            // Создание SQL-запроса для получения списка object_id по user_id
            string query = "SELECT Categories_id FROM Objects WHERE User_id = @UserId";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@UserId", userId);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int objectId = reader.GetInt32(0); // Предполагается, что object_id - это int
                    objectIds.Add(objectId);
                }
            }


            return objectIds;
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string login = "4";
            int userId = GetUserIdFromDatabase(login);
            List<int> objectIds = GetObjectIdsFromDatabase(userId);
            foreach (int objectId in objectIds)
            {
                // Поиск элемента в CheckListBox по номеру и установка свойства Checked
                int index = objectsCheckLB.FindStringExact(objectId.ToString());
                if (index != -1)
                {
                    objectsCheckLB.SetItemChecked(index, true);
                }
            }

        }
    }
}
