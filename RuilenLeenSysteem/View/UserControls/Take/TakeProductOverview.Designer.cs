
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
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TakeProductOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_TakeProductSearch
            // 
            this.Txt_TakeProductSearch.Location = new System.Drawing.Point(638, 110);
            this.Txt_TakeProductSearch.Name = "Txt_TakeProductSearch";
            this.Txt_TakeProductSearch.Size = new System.Drawing.Size(197, 22);
            this.Txt_TakeProductSearch.TabIndex = 27;
            // 
            // Dgv_TakeProductOverview
            // 
            this.Dgv_TakeProductOverview.AllowUserToAddRows = false;
            this.Dgv_TakeProductOverview.AllowUserToDeleteRows = false;
            this.Dgv_TakeProductOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TakeProductOverview.Location = new System.Drawing.Point(57, 215);
            this.Dgv_TakeProductOverview.Name = "Dgv_TakeProductOverview";
            this.Dgv_TakeProductOverview.RowHeadersWidth = 51;
            this.Dgv_TakeProductOverview.RowTemplate.Height = 24;
            this.Dgv_TakeProductOverview.Size = new System.Drawing.Size(778, 309);
            this.Dgv_TakeProductOverview.TabIndex = 26;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(50, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(186, 40);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Innemen";
            // 
            // Btn_TakeProduct
            // 
            this.Btn_TakeProduct.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TakeProduct.Image")));
            this.Btn_TakeProduct.Location = new System.Drawing.Point(57, 98);
            this.Btn_TakeProduct.Name = "Btn_TakeProduct";
            this.Btn_TakeProduct.Size = new System.Drawing.Size(110, 93);
            this.Btn_TakeProduct.TabIndex = 76;
            this.Btn_TakeProduct.Text = "Innemen";
            this.Btn_TakeProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_TakeProduct.UseVisualStyleBackColor = true;
            this.Btn_TakeProduct.Click += new System.EventHandler(this.Btn_TakeProduct_Click);
            // 
            // TakeProductOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_TakeProduct);
            this.Controls.Add(this.Txt_TakeProductSearch);
            this.Controls.Add(this.Dgv_TakeProductOverview);
            this.Controls.Add(this.Label1);
            this.Name = "TakeProductOverview";
            this.Size = new System.Drawing.Size(895, 554);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TakeProductOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_TakeProductSearch;
        private System.Windows.Forms.DataGridView Dgv_TakeProductOverview;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Btn_TakeProduct;
    }
}
