using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BookStore.Views.Popup
{
    public partial class UC_BookDetails : UserControl
    {
        public UC_BookDetails()
        {
            InitializeComponent();
        }

        private void UC_BookDetails_MouseHover(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void UC_BookDetails_Click(object sender, EventArgs e)
        {
            frmBookDetails f = new frmBookDetails();
            f.ShowDialog();
        }
    }
}
