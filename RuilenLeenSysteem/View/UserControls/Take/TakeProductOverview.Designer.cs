
namespace RuilenLeenSysteem.View.UserControls.Take
{
    partial class TakeProductOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeProductOverview));
            this.Txt_TakeProductSearch = new System.Windows.Forms.TextBox();
            this.Dgv_TakeProductOverview = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.Btn_TakeProduct = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Read = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_Review = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TakeProductOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_TakeProductSearch
            // 
            this.Txt_TakeProductSearch.Location = new System.Drawing.Point(478, 113);
            this.Txt_TakeProductSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_TakeProductSearch.Name = "Txt_TakeProductSearch";
            this.Txt_TakeProductSearch.Size = new System.Drawing.Size(149, 20);
            this.Txt_TakeProductSearch.TabIndex = 27;
            // 
            // Dgv_TakeProductOverview
            // 
            this.Dgv_TakeProductOverview.AllowUserToAddRows = false;
            this.Dgv_TakeProductOverview.AllowUserToDeleteRows = false;
            this.Dgv_TakeProductOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TakeProductOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductName,
            this.Status,
            this.btn_Read,
            this.btn_Edit,
            this.Btn_Review,
            this.btn_Delete});
            this.Dgv_TakeProductOverview.Location = new System.Drawing.Point(43, 136);
            this.Dgv_TakeProductOverview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_TakeProductOverview.Name = "Dgv_TakeProductOverview";
            this.Dgv_TakeProductOverview.RowHeadersWidth = 51;
            this.Dgv_TakeProductOverview.RowTemplate.Height = 24;
            this.Dgv_TakeProductOverview.Size = new System.Drawing.Size(584, 290);
            this.Dgv_TakeProductOverview.TabIndex = 26;
            this.Dgv_TakeProductOverview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_TakeProductOverview_CellContentClick);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(38, 20);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(185, 32);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Aannemen ";
            // 
            // Btn_TakeProduct
            // 
            this.Btn_TakeProduct.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TakeProduct.Image")));
            this.Btn_TakeProduct.Location = new System.Drawing.Point(43, 55);
            this.Btn_TakeProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_TakeProduct.Name = "Btn_TakeProduct";
            this.Btn_TakeProduct.Size = new System.Drawing.Size(82, 76);
            this.Btn_TakeProduct.TabIndex = 76;
            this.Btn_TakeProduct.Text = "Aannemen ";
            this.Btn_TakeProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_TakeProduct.UseVisualStyleBackColor = true;
            this.Btn_TakeProduct.Click += new System.EventHandler(this.Btn_TakeProduct_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Naam";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // btn_Read
            // 
            this.btn_Read.HeaderText = "Bekijk";
            this.btn_Read.MinimumWidth = 6;
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Visible = false;
            this.btn_Read.Width = 125;
            // 
            // btn_Edit
            // 
            this.btn_Edit.HeaderText = "Wijzig";
            this.btn_Edit.MinimumWidth = 6;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Visible = false;
            this.btn_Edit.Width = 125;
            // 
            // Btn_Review
            // 
            this.Btn_Review.HeaderText = "Review";
            this.Btn_Review.Name = "Btn_Review";
            // 
            // btn_Delete
            // 
            this.btn_Delete.HeaderText = "Verwijder";
            this.btn_Delete.MinimumWidth = 6;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Width = 125;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(51, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(227, 40);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Aannemen ";
            // 
            // Btn_TakeProduct
            // 
            this.Btn_TakeProduct.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TakeProduct.Image")));
            this.Btn_TakeProduct.Location = new System.Drawing.Point(57, 68);
            this.Btn_TakeProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_TakeProduct.Name = "Btn_TakeProduct";
            this.Btn_TakeProduct.Size = new System.Drawing.Size(109, 94);
            this.Btn_TakeProduct.TabIndex = 76;
            this.Btn_TakeProduct.Text = "Aannemen ";
            this.Btn_TakeProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_TakeProduct.UseVisualStyleBackColor = true;
            this.Btn_TakeProduct.Click += new System.EventHandler(this.Btn_TakeProduct_Click);
            // 
            // TakeProductOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_TakeProduct);
            this.Controls.Add(this.Txt_TakeProductSearch);
            this.Controls.Add(this.Dgv_TakeProductOverview);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TakeProductOverview";
            this.Size = new System.Drawing.Size(671, 450);
            this.Load += new System.EventHandler(this.TakeProductOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TakeProductOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_TakeProductSearch;
        private System.Windows.Forms.DataGridView Dgv_TakeProductOverview;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Btn_TakeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Read;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Btn_Review;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Delete;
    }
}
