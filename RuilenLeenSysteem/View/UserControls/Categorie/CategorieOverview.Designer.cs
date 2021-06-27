
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
            this.Lbl_Customer = new System.Windows.Forms.Label();
            this.Btn_CategorieAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Read = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_CategorieSearch
            // 
            this.Txt_CategorieSearch.Location = new System.Drawing.Point(641, 148);
            this.Txt_CategorieSearch.Name = "Txt_CategorieSearch";
            this.Txt_CategorieSearch.Size = new System.Drawing.Size(197, 22);
            this.Txt_CategorieSearch.TabIndex = 13;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naam,
            this.Datum,
            this.btn_Read,
            this.btn_Edit,
            this.btn_Delete});
            this.dataGridView1.Location = new System.Drawing.Point(74, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 344);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Name";
            this.Naam.MinimumWidth = 6;
            this.Naam.Name = "Naam";
            this.Naam.Width = 125;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Date";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.Width = 125;
            // 
            // btn_Read
            // 
            this.btn_Read.HeaderText = "Inzien";
            this.btn_Read.MinimumWidth = 6;
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_Read.Width = 125;
            // 
            // btn_Edit
            // 
            this.btn_Edit.HeaderText = "Aanpassen";
            this.btn_Edit.MinimumWidth = 6;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_Edit.Width = 125;
            // 
            // btn_Delete
            // 
            this.btn_Delete.HeaderText = "Verwijderen";
            this.btn_Delete.MinimumWidth = 6;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_Delete.Width = 125;
            // 
            // CategorieOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_CategorieSearch);
            this.Controls.Add(this.Lbl_Customer);
            this.Controls.Add(this.Btn_CategorieAdd);
            this.Name = "CategorieOverview";
            this.Size = new System.Drawing.Size(895, 554);
            this.Load += new System.EventHandler(this.CategorieOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_CategorieSearch;
        private System.Windows.Forms.Label Lbl_Customer;
        private System.Windows.Forms.Button Btn_CategorieAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Read;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Edit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Delete;
    }
}
