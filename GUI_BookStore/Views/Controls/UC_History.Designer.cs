namespace GUI_BookStore.UserControls
{
    partial class UC_History
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
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lbTotalPayment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCart.Location = new System.Drawing.Point(0, 0);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(966, 543);
            this.dgvCart.TabIndex = 0;
            // 
            // lbTotalPayment
            // 
            this.lbTotalPayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotalPayment.AutoSize = true;
            this.lbTotalPayment.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPayment.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTotalPayment.Location = new System.Drawing.Point(786, 571);
            this.lbTotalPayment.Name = "lbTotalPayment";
            this.lbTotalPayment.Size = new System.Drawing.Size(180, 33);
            this.lbTotalPayment.TabIndex = 1;
            this.lbTotalPayment.Text = "Total Payment:";
            this.lbTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UC_History
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbTotalPayment);
            this.Controls.Add(this.dgvCart);
            this.Name = "UC_History";
            this.Size = new System.Drawing.Size(966, 634);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lbTotalPayment;
    }
}
