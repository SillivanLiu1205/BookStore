using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_BookStore.IViews;
using GUI_BookStore.Presenters;
using DTO_BookStore;

namespace GUI_BookStore.UserControls
{
    public partial class UC_YourCart : UserControl, IYourCart
    {
        public DataGridView CartDetails { get => dgvCartDetails; }
        public Label LabelMessage { get => lbMessage; }
        public Label LabelSubtotal { get => lbSubtotal; }
        public Cart cart;

        public PYourCart YourCartPresenter;
        public UC_YourCart(Cart cart)
        {
            InitializeComponent();
            YourCartPresenter = new PYourCart();
            this.cart = cart;
        }

        private void UC_YourCart_Load(object sender, EventArgs e)
        {
            YourCartPresenter.Get
        }
    }
}
