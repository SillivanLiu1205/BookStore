namespace GUI_BookStore.Views.Popup
{
    partial class UC_BookDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BookDetails));
            this.pnBook = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbBok = new System.Windows.Forms.PictureBox();
            this.pnBook.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBok)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBook
            // 
            this.pnBook.Controls.Add(this.lbPrice);
            this.pnBook.Controls.Add(this.lbTitle);
            this.pnBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBook.Location = new System.Drawing.Point(0, 216);
            this.pnBook.Name = "pnBook";
            this.pnBook.Size = new System.Drawing.Size(230, 106);
            this.pnBook.TabIndex = 0;
            this.pnBook.Click += new System.EventHandler(this.ptbBok_Click);
            this.pnBook.MouseEnter += new System.EventHandler(this.ptbBok_MouseEnter);
            this.pnBook.MouseLeave += new System.EventHandler(this.ptbBok_MouseLeave);
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbPrice.Location = new System.Drawing.Point(3, 3);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(79, 34);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "Price";
            this.lbPrice.Click += new System.EventHandler(this.ptbBok_Click);
            this.lbPrice.MouseEnter += new System.EventHandler(this.ptbBok_MouseEnter);
            this.lbPrice.MouseLeave += new System.EventHandler(this.ptbBok_MouseLeave);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(3, 37);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(224, 69);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title";
            this.lbTitle.Click += new System.EventHandler(this.ptbBok_Click);
            this.lbTitle.MouseEnter += new System.EventHandler(this.ptbBok_MouseEnter);
            this.lbTitle.MouseLeave += new System.EventHandler(this.ptbBok_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptbBok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 216);
            this.panel2.TabIndex = 1;
            // 
            // ptbBok
            // 
            this.ptbBok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbBok.Image = ((System.Drawing.Image)(resources.GetObject("ptbBok.Image")));
            this.ptbBok.Location = new System.Drawing.Point(0, 0);
            this.ptbBok.Name = "ptbBok";
            this.ptbBok.Size = new System.Drawing.Size(230, 216);
            this.ptbBok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBok.TabIndex = 0;
            this.ptbBok.TabStop = false;
            this.ptbBok.Click += new System.EventHandler(this.ptbBok_Click);
            this.ptbBok.MouseEnter += new System.EventHandler(this.ptbBok_MouseEnter);
            this.ptbBok.MouseLeave += new System.EventHandler(this.ptbBok_MouseLeave);
            // 
            // UC_BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnBook);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_BookDetails";
            this.Size = new System.Drawing.Size(230, 322);
            this.Load += new System.EventHandler(this.UC_BookDetails_Load);
            this.pnBook.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnBook;
        internal System.Windows.Forms.Label lbPrice;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.PictureBox ptbBok;
        internal System.Windows.Forms.Label lbTitle;
    }
}
