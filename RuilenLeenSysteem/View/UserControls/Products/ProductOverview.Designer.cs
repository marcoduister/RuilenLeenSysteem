
namespace RuilenLeenSysteem.View.UserControls.Products
{
    partial class ProductOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductOverview));
            this.Txt_ProductSearch = new System.Windows.Forms.TextBox();
            this.Dgv_ProductOverview = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.Btn_ProductAdd = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ProductOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_ProductSearch
            // 
            this.Txt_ProductSearch.Location = new System.Drawing.Point(641, 148);
            this.Txt_ProductSearch.Name = "Txt_ProductSearch";
            this.Txt_ProductSearch.Size = new System.Drawing.Size(197, 22);
            this.Txt_ProductSearch.TabIndex = 17;
            // 
            // Dgv_ProductOverview
            // 
            this.Dgv_ProductOverview.AllowUserToAddRows = false;
            this.Dgv_ProductOverview.AllowUserToDeleteRows = false;
            this.Dgv_ProductOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ProductOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Product_Name,
            this.ProductDescription,
            this.ProductPoints,
            this.ProductStatus,
            this.ProductType,
            this.Btn_Edit,
            this.Btn_Delete});
            this.Dgv_ProductOverview.Location = new System.Drawing.Point(63, 176);
            this.Dgv_ProductOverview.Name = "Dgv_ProductOverview";
            this.Dgv_ProductOverview.RowHeadersWidth = 51;
            this.Dgv_ProductOverview.RowTemplate.Height = 24;
            this.Dgv_ProductOverview.Size = new System.Drawing.Size(775, 344);
            this.Dgv_ProductOverview.TabIndex = 16;
            this.Dgv_ProductOverview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ProductOverview_CellContentClick_1);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(56, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(207, 40);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Producten";
            // 
            // Btn_ProductAdd
            // 
            this.Btn_ProductAdd.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ProductAdd.Image")));
            this.Btn_ProductAdd.Location = new System.Drawing.Point(63, 77);
            this.Btn_ProductAdd.Name = "Btn_ProductAdd";
            this.Btn_ProductAdd.Size = new System.Drawing.Size(110, 93);
            this.Btn_ProductAdd.TabIndex = 14;
            this.Btn_ProductAdd.Text = "Toevoegen";
            this.Btn_ProductAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_ProductAdd.UseVisualStyleBackColor = true;
            this.Btn_ProductAdd.Click += new System.EventHandler(this.Btn_ProductAdd_Click);
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.HeaderText = "ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Name.HeaderText = "Naam";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            // 
            // ProductDescription
            // 
            this.ProductDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductDescription.HeaderText = "Beschrijving";
            this.ProductDescription.MinimumWidth = 6;
            this.ProductDescription.Name = "ProductDescription";
            // 
            // ProductPoints
            // 
            this.ProductPoints.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductPoints.HeaderText = "Punten";
            this.ProductPoints.MinimumWidth = 6;
            this.ProductPoints.Name = "ProductPoints";
            // 
            // ProductStatus
            // 
            this.ProductStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductStatus.HeaderText = "Status";
            this.ProductStatus.MinimumWidth = 6;
            this.ProductStatus.Name = "ProductStatus";
            // 
            // ProductType
            // 
            this.ProductType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductType.HeaderText = "Type";
            this.ProductType.MinimumWidth = 6;
            this.ProductType.Name = "ProductType";
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.HeaderText = "Bewerk";
            this.Btn_Edit.MinimumWidth = 6;
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Text = "Bewerk";
            this.Btn_Edit.UseColumnTextForButtonValue = true;
            this.Btn_Edit.Width = 125;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.HeaderText = "Verwijder";
            this.Btn_Delete.MinimumWidth = 6;
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Text = "Verwijder";
            this.Btn_Delete.UseColumnTextForButtonValue = true;
            this.Btn_Delete.Width = 125;
            // 
            // ProductOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_ProductSearch);
            this.Controls.Add(this.Dgv_ProductOverview);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Btn_ProductAdd);
            this.Name = "ProductOverview";
            this.Size = new System.Drawing.Size(895, 554);
            this.Load += new System.EventHandler(this.ProductOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ProductOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ProductSearch;
        private System.Windows.Forms.DataGridView Dgv_ProductOverview;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Btn_ProductAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewButtonColumn Btn_Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Btn_Delete;
    }
}
