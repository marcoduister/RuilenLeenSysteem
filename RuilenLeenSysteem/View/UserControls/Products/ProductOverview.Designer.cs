
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
            this.Btn_CategorieAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ProductOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_ProductSearch
            // 
            this.Txt_ProductSearch.Location = new System.Drawing.Point(641, 119);
            this.Txt_ProductSearch.Name = "Txt_ProductSearch";
            this.Txt_ProductSearch.Size = new System.Drawing.Size(197, 22);
            this.Txt_ProductSearch.TabIndex = 17;
            // 
            // Dgv_ProductOverview
            // 
            this.Dgv_ProductOverview.AllowUserToAddRows = false;
            this.Dgv_ProductOverview.AllowUserToDeleteRows = false;
            this.Dgv_ProductOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ProductOverview.Location = new System.Drawing.Point(63, 237);
            this.Dgv_ProductOverview.Name = "Dgv_ProductOverview";
            this.Dgv_ProductOverview.RowHeadersWidth = 51;
            this.Dgv_ProductOverview.RowTemplate.Height = 24;
            this.Dgv_ProductOverview.Size = new System.Drawing.Size(775, 283);
            this.Dgv_ProductOverview.TabIndex = 16;
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
            // Btn_CategorieAdd
            // 
            this.Btn_CategorieAdd.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CategorieAdd.Image")));
            this.Btn_CategorieAdd.Location = new System.Drawing.Point(63, 119);
            this.Btn_CategorieAdd.Name = "Btn_CategorieAdd";
            this.Btn_CategorieAdd.Size = new System.Drawing.Size(110, 93);
            this.Btn_CategorieAdd.TabIndex = 14;
            this.Btn_CategorieAdd.Text = "Toevoegen";
            this.Btn_CategorieAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_CategorieAdd.UseVisualStyleBackColor = true;
            // 
            // ProductOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_ProductSearch);
            this.Controls.Add(this.Dgv_ProductOverview);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Btn_CategorieAdd);
            this.Name = "ProductOverview";
            this.Size = new System.Drawing.Size(895, 554);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ProductOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ProductSearch;
        private System.Windows.Forms.DataGridView Dgv_ProductOverview;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Btn_CategorieAdd;
    }
}
