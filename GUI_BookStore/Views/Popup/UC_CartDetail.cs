using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_BookStore;
using GUI_BookStore.IViews;
using GUI_BookStore.Presenters;
using GUI_BookStore.UserForms;
using GUI_BookStore.Models;

namespace GUI_BookStore.Views.Popup
{
    public partial class UC_CartDetail : UserControl, ICartDetail
    {
        public PCartDetail CartDetailPresenter;
        public CartDetail cartDetail { get => cartDetail; set => cartDetail = value; }

        public UC_CartDetail(CartDetail cartDetail)
        {
            InitializeComponent();
            CartDetailPresenter = new PCartDetail(this);
            nudQuantity.Maximum = this.cartDetail.CartDetailBook.Quantity;
            this.cartDetail = cartDetail;
        }

        private void UC_CartDetail_Load(object sender, EventArgs e)
        {
            FormPaint();
        }

        private void lbTitle_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void lbTitle_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!CartDetailPresenter.DeleteCartDetail(cartDetail.CartDetailID))
            {
                MessageBox.Show("Delete Fail");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CartDetailPresenter.UpdateDateCartDetail(cartDetail.CartDetailID, int.Parse(nudQuantity.Value.ToString())))
            {                
                MessageBox.Show("Update Successfull");
            }
            else
            {
                MessageBox.Show("Update Fail");
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(nudQuantity.Value == cartDetail.Quantity)
            {
                btnUpdate.Visible = false;
            }
            else
            {
                btnUpdate.Visible = true;
            }
        }
        private void FormPaint()
        {
            int price = cartDetail.CartDetailBook.Price * cartDetail.Quantity;
            lbTitle.Text = cartDetail.CartDetailBook.Title;
            lbPrice.Text = price.ToString() + " đ";
            nudQuantity.Value = cartDetail.Quantity;
            ptbImage.Image = Image.FromFile(@"ImageData\" + cartDetail.CartDetailBook.Image);
        }
    }
}
