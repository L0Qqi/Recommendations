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
    public partial class RecommendationsForm : Form
    {
        public RecommendationsForm()
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
    }
}
