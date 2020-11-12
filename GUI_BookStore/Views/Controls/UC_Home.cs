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
using System.Runtime.Remoting.Messaging;
using GUI_BookStore.Presenters;

namespace GUI_BookStore.UserControls
{
    public partial class UC_Home : UserControl, IHomeView
    {
        private PHome homePresenter { get; set; }
        public string SearchBy => cbxSearchBy.SelectedItem.ToString();

        public string SearchContext => txtSearch.Text;

        public string Language
        {
            get
            {
                foreach(string item in clbLanguage.CheckedItems)
                {
                    return item;
                }
                return null;
            }
        }

        public string CategoryName
        {
            get
            {
                foreach(string item in clbCategory.CheckedItems)
                {
                    return item;
                }
                return null;
            }
        }

        public UC_Home()
        {
            InitializeComponent();
            homePresenter = new PHome(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            homePresenter.GetBooks(SearchBy, SearchContext, Language, CategoryName);
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            cbxSearchBy.SelectedIndex = 1;
            loadCategories();
            homePresenter.GetBooks(SearchBy, SearchContext, Language, CategoryName);
        }

        private void loadCategories()
        {
            homePresenter.GetAllCategoryName();
        }

        private void clbLanguage_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clbLanguage.Items.Count; i++)
            {
                if (i != e.Index) clbLanguage.SetItemChecked(i, false);
            }
        }

        private void clbCategory_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clbCategory.Items.Count; i++)
            {
                if (i != e.Index) clbCategory.SetItemChecked(i, false);
            }
        }
    }
}
