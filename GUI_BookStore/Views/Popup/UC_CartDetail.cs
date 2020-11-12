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

namespace GUI_BookStore.Views.Popup
{
    public partial class UC_CartDetail : UserControl, ICartDetail
    {
        private PCartDetail CartDetailPresenter;
        public CartDetail cartDetail { get; set; }
        public Book book { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public UC_CartDetail(CartDetail cartDetail)
        {
            InitializeComponent();
            this.cartDetail = cartDetail;
            CartDetailPresenter = new PCartDetail(this);
        }

        private void UC_BookDetails_Load(object sender, EventArgs e)
        {
            this.lbTitle
        }

        private void ptbBok_Click(object sender, EventArgs e)
        {
            LoadDetailsForm();
        }

        private void ptbBok_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void ptbBok_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        private void LoadBookDetail()
        {
            book = 
        }
    }
}
