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
        public FlowLayoutPanel CartDetails { get => flpCartDetail; }
        public Label LabelMessage { get => lbMessage; }
        public Label LabelSubtotal { get => lbSubtotal; }
        public Cart cart { get; set; }

        public PYourCart YourCartPresenter;
        public UC_YourCart(string Username, Cart card)
        {
            InitializeComponent();
            YourCartPresenter = new PYourCart(this);
            this.cart = cart;
        }

        private void timerPain_Tick(object sender, EventArgs e)
        {
            YourCartPresenter.LoadForm(cart.CartID);
        }
    }
}
