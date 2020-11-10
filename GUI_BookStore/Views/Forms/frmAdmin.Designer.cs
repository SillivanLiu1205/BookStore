namespace GUI_BookStore.UserForms
{
    partial class frmAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnNewAdmin = new System.Windows.Forms.Button();
            this.pnSide = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnMangeBook = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnControl = new System.Windows.Forms.Panel();
            this.timerCollapse = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.DarkOrange;
            this.pnLeft.Controls.Add(this.btnNewAdmin);
            this.pnLeft.Controls.Add(this.pnSide);
            this.pnLeft.Controls.Add(this.btnAccount);
            this.pnLeft.Controls.Add(this.btnManageUser);
            this.pnLeft.Controls.Add(this.btnIncome);
            this.pnLeft.Controls.Add(this.btnMangeBook);
            this.pnLeft.Controls.Add(this.btnCollapse);
            this.pnLeft.Controls.Add(this.pictureBox1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(232, 763);
            this.pnLeft.TabIndex = 4;
            // 
            // btnNewAdmin
            // 
            this.btnNewAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAdmin.FlatAppearance.BorderSize = 0;
            this.btnNewAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAdmin.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnNewAdmin.ForeColor = System.Drawing.Color.White;
            this.btnNewAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAdmin.Image")));
            this.btnNewAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewAdmin.Location = new System.Drawing.Point(12, 378);
            this.btnNewAdmin.Name = "btnNewAdmin";
            this.btnNewAdmin.Size = new System.Drawing.Size(220, 52);
            this.btnNewAdmin.TabIndex = 7;
            this.btnNewAdmin.Text = "New Admin";
            this.btnNewAdmin.UseVisualStyleBackColor = true;
            this.btnNewAdmin.Click += new System.EventHandler(this.btnNewAdmin_Click);
            // 
            // pnSide
            // 
            this.pnSide.BackColor = System.Drawing.Color.White;
            this.pnSide.Location = new System.Drawing.Point(0, 204);
            this.pnSide.Name = "pnSide";
            this.pnSide.Size = new System.Drawing.Size(10, 52);
            this.pnSide.TabIndex = 6;
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccount.Location = new System.Drawing.Point(12, 436);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(220, 52);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUser.FlatAppearance.BorderSize = 0;
            this.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUser.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnManageUser.ForeColor = System.Drawing.Color.White;
            this.btnManageUser.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUser.Image")));
            this.btnManageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnManageUser.Location = new System.Drawing.Point(12, 262);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(220, 52);
            this.btnManageUser.TabIndex = 4;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnIncome.Image")));
            this.btnIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIncome.Location = new System.Drawing.Point(12, 320);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(220, 52);
            this.btnIncome.TabIndex = 3;
            this.btnIncome.Text = "Income";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnMangeBook
            // 
            this.btnMangeBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMangeBook.FlatAppearance.BorderSize = 0;
            this.btnMangeBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangeBook.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnMangeBook.ForeColor = System.Drawing.Color.White;
            this.btnMangeBook.Image = ((System.Drawing.Image)(resources.GetObject("btnMangeBook.Image")));
            this.btnMangeBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMangeBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMangeBook.Location = new System.Drawing.Point(12, 204);
            this.btnMangeBook.Name = "btnMangeBook";
            this.btnMangeBook.Size = new System.Drawing.Size(220, 52);
            this.btnMangeBook.TabIndex = 2;
            this.btnMangeBook.Text = "Manage Book";
            this.btnMangeBook.UseVisualStyleBackColor = true;
            this.btnMangeBook.Click += new System.EventHandler(this.btnMangeBook_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Image = ((System.Drawing.Image)(resources.GetObject("btnCollapse.Image")));
            this.btnCollapse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCollapse.Location = new System.Drawing.Point(174, 3);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(50, 44);
            this.btnCollapse.TabIndex = 1;
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbWelcome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(232, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 129);
            this.panel1.TabIndex = 5;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTime.Location = new System.Drawing.Point(835, 85);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(113, 29);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "HH:MM:SS";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbWelcome.ForeColor = System.Drawing.Color.White;
            this.lbWelcome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbWelcome.Location = new System.Drawing.Point(37, 81);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(130, 33);
            this.lbWelcome.TabIndex = 4;
            this.lbWelcome.Text = "Welcome: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 65);
            this.panel3.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(900, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 53);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pnControl
            // 
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControl.Location = new System.Drawing.Point(232, 129);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(960, 634);
            this.pnControl.TabIndex = 6;
            // 
            // timerCollapse
            // 
            this.timerCollapse.Tick += new System.EventHandler(this.timerCollapse_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(19, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 763);
            this.ControlBox = false;
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnLeft);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnSide;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnMangeBook;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnNewAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerCollapse;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnControl;
    }
}