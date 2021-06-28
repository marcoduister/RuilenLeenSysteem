
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowProduct_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Borrow = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.Dgv_BorrowProductOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BorrowProduct_Name,
            this.Description,
            this.Points,
            this.Status,
            this.btn_Borrow});
            this.Dgv_BorrowProductOverview.Location = new System.Drawing.Point(60, 138);
            this.Dgv_BorrowProductOverview.Name = "Dgv_BorrowProductOverview";
            this.Dgv_BorrowProductOverview.RowHeadersWidth = 51;
            this.Dgv_BorrowProductOverview.RowTemplate.Height = 24;
            this.Dgv_BorrowProductOverview.Size = new System.Drawing.Size(775, 373);
            this.Dgv_BorrowProductOverview.TabIndex = 23;
            this.Dgv_BorrowProductOverview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_BorrowProductOverview_CellContentClick);
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
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // BorrowProduct_Name
            // 
            this.BorrowProduct_Name.HeaderText = "Naam";
            this.BorrowProduct_Name.MinimumWidth = 6;
            this.BorrowProduct_Name.Name = "BorrowProduct_Name";
            this.BorrowProduct_Name.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Beschijving";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // Points
            // 
            this.Points.HeaderText = "punten";
            this.Points.MinimumWidth = 6;
            this.Points.Name = "Points";
            this.Points.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.HeaderText = "Uitlenen";
            this.btn_Borrow.MinimumWidth = 6;
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Text = "Uitlenen";
            this.btn_Borrow.UseColumnTextForButtonValue = true;
            this.btn_Borrow.Width = 125;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowProduct_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Borrow;
    }
}
