
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Read = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Lbl_Customer = new System.Windows.Forms.Label();
            this.Btn_CategorieAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CustomerOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_CategorieSearch
            // 
            this.Txt_CategorieSearch.Location = new System.Drawing.Point(641, 148);
            this.Txt_CategorieSearch.Name = "Txt_CategorieSearch";
            this.Txt_CategorieSearch.Size = new System.Drawing.Size(197, 22);
            this.Txt_CategorieSearch.TabIndex = 13;
            // 
            // Dgv_CustomerOverview
            // 
            this.Dgv_CustomerOverview.AllowUserToAddRows = false;
            this.Dgv_CustomerOverview.AllowUserToDeleteRows = false;
            this.Dgv_CustomerOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CustomerOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Btn_Read,
            this.Btn_Edit});
            this.Dgv_CustomerOverview.Location = new System.Drawing.Point(63, 176);
            this.Dgv_CustomerOverview.Name = "Dgv_CustomerOverview";
            this.Dgv_CustomerOverview.RowHeadersWidth = 51;
            this.Dgv_CustomerOverview.RowTemplate.Height = 24;
            this.Dgv_CustomerOverview.Size = new System.Drawing.Size(775, 344);
            this.Dgv_CustomerOverview.TabIndex = 12;
            this.Dgv_CustomerOverview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CustomerOverview_CellContentClick_1);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Btn_Read
            // 
            this.Btn_Read.HeaderText = "inzien";
            this.Btn_Read.MinimumWidth = 6;
            this.Btn_Read.Name = "Btn_Read";
            this.Btn_Read.Text = "Inzien";
            this.Btn_Read.UseColumnTextForButtonValue = true;
            this.Btn_Read.Width = 125;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.HeaderText = "Bewerk";
            this.Btn_Edit.MinimumWidth = 6;
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Btn_Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Btn_Edit.Text = "Bewerk";
            this.Btn_Edit.UseColumnTextForButtonValue = true;
            this.Btn_Edit.Width = 125;
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
            this.Btn_CategorieAdd.Location = new System.Drawing.Point(63, 77);
            this.Btn_CategorieAdd.Name = "Btn_CategorieAdd";
            this.Btn_CategorieAdd.Size = new System.Drawing.Size(110, 93);
            this.Btn_CategorieAdd.TabIndex = 10;
            this.Btn_CategorieAdd.Text = "Toevoegen";
            this.Btn_CategorieAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_CategorieAdd.UseVisualStyleBackColor = true;
            this.Btn_CategorieAdd.Click += new System.EventHandler(this.Btn_CategorieAdd_Click);
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
            this.Load += new System.EventHandler(this.CategorieOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CustomerOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_CategorieSearch;
        private System.Windows.Forms.DataGridView Dgv_CustomerOverview;
        private System.Windows.Forms.Label Lbl_Customer;
        private System.Windows.Forms.Button Btn_CategorieAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewButtonColumn Btn_Read;
        private System.Windows.Forms.DataGridViewButtonColumn Btn_Edit;
    }
}
