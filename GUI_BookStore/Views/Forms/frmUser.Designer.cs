namespace GUI_BookStore.UserForms
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnSide = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnYourCart = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMoveSide = new System.Windows.Forms.Button();
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
            this.pnLeft.Controls.Add(this.pnSide);
            this.pnLeft.Controls.Add(this.btnAccount);
            this.pnLeft.Controls.Add(this.btnYourCart);
            this.pnLeft.Controls.Add(this.btnHistory);
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Controls.Add(this.btnMoveSide);
            this.pnLeft.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.pnLeft, "pnLeft");
            this.pnLeft.Name = "pnLeft";
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
            // btnYourCart
            // 
            this.btnYourCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYourCart.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnYourCart, "btnYourCart");
            this.btnYourCart.ForeColor = System.Drawing.Color.White;
            this.btnYourCart.Name = "btnYourCart";
            this.btnYourCart.UseVisualStyleBackColor = true;
            this.btnYourCart.Click += new System.EventHandler(this.btnYourCart_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnHistory, "btnHistory");
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMoveSide
            // 
            resources.ApplyResources(this.btnMoveSide, "btnMoveSide");
            this.btnMoveSide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveSide.FlatAppearance.BorderSize = 0;
            this.btnMoveSide.Name = "btnMoveSide";
            this.btnMoveSide.UseVisualStyleBackColor = true;
            this.btnMoveSide.Click += new System.EventHandler(this.btnMoveSide_Click);
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
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            // frmUser
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ControlBox = false;
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Button btnMoveSide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnSide;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnYourCart;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Timer timerCollapse;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel pnControl;
    }
}