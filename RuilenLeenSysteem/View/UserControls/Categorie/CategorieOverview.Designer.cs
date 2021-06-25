
namespace RuilenLeenSysteem.View.UserControls.Categorie
{
    partial class CategorieOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorieOverview));
            this.Txt_CategorieSearch = new System.Windows.Forms.TextBox();
            this.Dgv_CustomerOverview = new System.Windows.Forms.DataGridView();
            this.Lbl_Customer = new System.Windows.Forms.Label();
            this.Btn_CategorieAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CustomerOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_CategorieSearch
            // 
            this.Txt_CategorieSearch.Location = new System.Drawing.Point(641, 119);
            this.Txt_CategorieSearch.Name = "Txt_CategorieSearch";
            this.Txt_CategorieSearch.Size = new System.Drawing.Size(197, 22);
            this.Txt_CategorieSearch.TabIndex = 13;
            // 
            // Dgv_CustomerOverview
            // 
            this.Dgv_CustomerOverview.AllowUserToAddRows = false;
            this.Dgv_CustomerOverview.AllowUserToDeleteRows = false;
            this.Dgv_CustomerOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CustomerOverview.Location = new System.Drawing.Point(63, 237);
            this.Dgv_CustomerOverview.Name = "Dgv_CustomerOverview";
            this.Dgv_CustomerOverview.RowHeadersWidth = 51;
            this.Dgv_CustomerOverview.RowTemplate.Height = 24;
            this.Dgv_CustomerOverview.Size = new System.Drawing.Size(775, 283);
            this.Dgv_CustomerOverview.TabIndex = 12;
            // 
            // Lbl_Customer
            // 
            this.Lbl_Customer.AutoSize = true;
            this.Lbl_Customer.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Customer.Location = new System.Drawing.Point(56, 34);
            this.Lbl_Customer.Name = "Lbl_Customer";
            this.Lbl_Customer.Size = new System.Drawing.Size(195, 40);
            this.Lbl_Customer.TabIndex = 11;
            this.Lbl_Customer.Text = "Categorie";
            // 
            // Btn_CategorieAdd
            // 
            this.Btn_CategorieAdd.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CategorieAdd.Image")));
            this.Btn_CategorieAdd.Location = new System.Drawing.Point(63, 119);
            this.Btn_CategorieAdd.Name = "Btn_CategorieAdd";
            this.Btn_CategorieAdd.Size = new System.Drawing.Size(110, 93);
            this.Btn_CategorieAdd.TabIndex = 10;
            this.Btn_CategorieAdd.Text = "Toevoegen";
            this.Btn_CategorieAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_CategorieAdd.UseVisualStyleBackColor = true;
            // 
            // CategorieOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_CategorieSearch);
            this.Controls.Add(this.Dgv_CustomerOverview);
            this.Controls.Add(this.Lbl_Customer);
            this.Controls.Add(this.Btn_CategorieAdd);
            this.Name = "CategorieOverview";
            this.Size = new System.Drawing.Size(895, 554);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CustomerOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_CategorieSearch;
        private System.Windows.Forms.DataGridView Dgv_CustomerOverview;
        private System.Windows.Forms.Label Lbl_Customer;
        private System.Windows.Forms.Button Btn_CategorieAdd;
    }
}
