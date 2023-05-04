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
    public partial class PersonalAccountForm : Form
    {
        public PersonalAccountForm()
        {
            InitializeComponent();
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
            RecommendationsForm rec = new RecommendationsForm();
            rec.Show();
        }

        private void toFavButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FavouritesForm favourites = new FavouritesForm();
            favourites.Show();
        }
    }
}
