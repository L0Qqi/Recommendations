using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recommendations
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalAccountForm account = new PersonalAccountForm();
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
            this.Hide();
            MyOrdersForm myOrders = new MyOrdersForm();
            myOrders.Show();
        }
    }
}
