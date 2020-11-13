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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnControl = new System.Windows.Forms.Panel();
            this.timerCollapse = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            resources.ApplyResources(this.pnLeft, "pnLeft");
            this.pnLeft.Name = "pnLeft";
            // 
            // btnNewAdmin
            // 
            this.btnNewAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAdmin.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNewAdmin, "btnNewAdmin");
            this.btnNewAdmin.ForeColor = System.Drawing.Color.White;
            this.btnNewAdmin.Name = "btnNewAdmin";
            this.btnNewAdmin.UseVisualStyleBackColor = true;
            this.btnNewAdmin.Click += new System.EventHandler(this.btnNewAdmin_Click);
            // 
            // pnSide
            // 
            this.pnSide.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pnSide, "pnSide");
            this.pnSide.Name = "pnSide";
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAccount, "btnAccount");
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUser.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnManageUser, "btnManageUser");
            this.btnManageUser.ForeColor = System.Drawing.Color.White;
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnIncome, "btnIncome");
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnMangeBook
            // 
            this.btnMangeBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMangeBook.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMangeBook, "btnMangeBook");
            this.btnMangeBook.ForeColor = System.Drawing.Color.White;
            this.btnMangeBook.Name = "btnMangeBook";
            this.btnMangeBook.UseVisualStyleBackColor = true;
            this.btnMangeBook.Click += new System.EventHandler(this.btnMangeBook_Click);
            // 
            // btnCollapse
            // 
            resources.ApplyResources(this.btnCollapse, "btnCollapse");
            this.btnCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbWelcome);
            this.panel1.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbTime
            // 
            resources.ApplyResources(this.lbTime, "lbTime");
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Name = "lbTime";
            // 
            // lbWelcome
            // 
            resources.ApplyResources(this.lbWelcome, "lbWelcome");
            this.lbWelcome.ForeColor = System.Drawing.Color.White;
            this.lbWelcome.Name = "lbWelcome";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pnControl
            // 
            resources.ApplyResources(this.pnControl, "pnControl");
            this.pnControl.Name = "pnControl";
            // 
            // timerCollapse
            // 
            this.timerCollapse.Tick += new System.EventHandler(this.timerCollapse_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // frmAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnLeft);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerCollapse;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnControl;
        internal System.Windows.Forms.Label lbWelcome;
    }
}