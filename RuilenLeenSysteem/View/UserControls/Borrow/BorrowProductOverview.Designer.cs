
namespace RuilenLeenSysteem.View.UserControls.Borrow
{
    partial class BorrowProductOverview
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
            this.Txt_BorrowProductSearch = new System.Windows.Forms.TextBox();
            this.Dgv_BorrowProductOverview = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_BorrowProductOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_BorrowProductSearch
            // 
            this.Txt_BorrowProductSearch.Location = new System.Drawing.Point(638, 110);
            this.Txt_BorrowProductSearch.Name = "Txt_BorrowProductSearch";
            this.Txt_BorrowProductSearch.Size = new System.Drawing.Size(197, 22);
            this.Txt_BorrowProductSearch.TabIndex = 24;
            // 
            // Dgv_BorrowProductOverview
            // 
            this.Dgv_BorrowProductOverview.AllowUserToAddRows = false;
            this.Dgv_BorrowProductOverview.AllowUserToDeleteRows = false;
            this.Dgv_BorrowProductOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_BorrowProductOverview.Location = new System.Drawing.Point(60, 228);
            this.Dgv_BorrowProductOverview.Name = "Dgv_BorrowProductOverview";
            this.Dgv_BorrowProductOverview.RowHeadersWidth = 51;
            this.Dgv_BorrowProductOverview.RowTemplate.Height = 24;
            this.Dgv_BorrowProductOverview.Size = new System.Drawing.Size(775, 283);
            this.Dgv_BorrowProductOverview.TabIndex = 23;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(67, 43);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(130, 40);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Lenen";
            // 
            // BorrowProductOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_BorrowProductSearch);
            this.Controls.Add(this.Dgv_BorrowProductOverview);
            this.Controls.Add(this.Label1);
            this.Name = "BorrowProductOverview";
            this.Size = new System.Drawing.Size(895, 554);
            this.Load += new System.EventHandler(this.BorrowProductOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_BorrowProductOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_BorrowProductSearch;
        private System.Windows.Forms.DataGridView Dgv_BorrowProductOverview;
        private System.Windows.Forms.Label Label1;
    }
}
