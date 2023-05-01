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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void cCloseLabel_Click(object sender, EventArgs e)
        {

        }

        private void fromCatReturnLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecommendationsForm recommendations = new RecommendationsForm();
            recommendations.Show();
        }
    }
}
