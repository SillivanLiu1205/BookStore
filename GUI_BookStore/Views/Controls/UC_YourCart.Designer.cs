namespace GUI_BookStore.UserControls
{
    partial class UC_YourCart
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
            this.components = new System.ComponentModel.Container();
            this.lbMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.dgvCartDetails = new System.Windows.Forms.DataGridView();
            this.bsCart = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbMessage.Location = new System.Drawing.Point(19, 28);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(153, 24);
            this.lbMessage.TabIndex = 1;
            this.lbMessage.Text = "Your cart is empty";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.lbSubtotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 84);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(799, 0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(161, 84);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbSubtotal.Location = new System.Drawing.Point(653, 31);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSubtotal.Size = new System.Drawing.Size(90, 24);
            this.lbSubtotal.TabIndex = 0;
            this.lbSubtotal.Text = "Sub Total:";
            this.lbSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvCartDetails
            // 
            this.dgvCartDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvCartDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCartDetails.Enabled = false;
            this.dgvCartDetails.GridColor = System.Drawing.Color.White;
            this.dgvCartDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvCartDetails.Name = "dgvCartDetails";
            this.dgvCartDetails.RowHeadersWidth = 51;
            this.dgvCartDetails.RowTemplate.Height = 24;
            this.dgvCartDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartDetails.Size = new System.Drawing.Size(960, 550);
            this.dgvCartDetails.TabIndex = 4;
            // 
            // UC_YourCart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.dgvCartDetails);
            this.Controls.Add(this.panel1);
            this.Name = "UC_YourCart";
            this.Size = new System.Drawing.Size(960, 634);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCartDetails;
        private System.Windows.Forms.BindingSource bsCart;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lbSubtotal;
    }
}
