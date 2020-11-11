namespace GUI_BookStore.UserControls
{
    partial class UC_Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.clbCategory = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbLanguage = new System.Windows.Forms.CheckedListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpBookList = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(273, 37);
            this.txtSearch.MaxLength = 200;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(639, 36);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(881, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 29);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxSearchBy);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 100);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(46, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search By:";
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.BackColor = System.Drawing.Color.White;
            this.cbxSearchBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "Author",
            "Name",
            "Publisher"});
            this.cbxSearchBy.Location = new System.Drawing.Point(50, 39);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(165, 32);
            this.cbxSearchBy.Sorted = true;
            this.cbxSearchBy.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.clbCategory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.clbLanguage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.MinimumSize = new System.Drawing.Size(232, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 534);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category:";
            // 
            // clbCategory
            // 
            this.clbCategory.CheckOnClick = true;
            this.clbCategory.FormattingEnabled = true;
            this.clbCategory.Location = new System.Drawing.Point(3, 152);
            this.clbCategory.Name = "clbCategory";
            this.clbCategory.Size = new System.Drawing.Size(262, 304);
            this.clbCategory.TabIndex = 3;
            this.clbCategory.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCategory_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language:";
            // 
            // clbLanguage
            // 
            this.clbLanguage.CheckOnClick = true;
            this.clbLanguage.FormattingEnabled = true;
            this.clbLanguage.Items.AddRange(new object[] {
            "Vietnamese",
            "English"});
            this.clbLanguage.Location = new System.Drawing.Point(3, 56);
            this.clbLanguage.Name = "clbLanguage";
            this.clbLanguage.Size = new System.Drawing.Size(262, 54);
            this.clbLanguage.TabIndex = 0;
            this.clbLanguage.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbLanguage_ItemCheck);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(268, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 534);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flpBookList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(271, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 534);
            this.panel3.TabIndex = 10;
            // 
            // flpBookList
            // 
            this.flpBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBookList.Location = new System.Drawing.Point(0, 0);
            this.flpBookList.Name = "flpBookList";
            this.flpBookList.Size = new System.Drawing.Size(689, 534);
            this.flpBookList.TabIndex = 0;
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(960, 634);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbLanguage;
        public System.Windows.Forms.FlowLayoutPanel flpBookList;
        internal System.Windows.Forms.CheckedListBox clbCategory;
    }
}
