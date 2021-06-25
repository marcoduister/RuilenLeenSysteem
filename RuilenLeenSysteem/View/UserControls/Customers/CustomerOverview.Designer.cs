
namespace RuilenLeenSysteem.View.UserControls.Customers
{
    partial class CustomerOverview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOverview));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_CustomerAdd = new System.Windows.Forms.Button();
            this.Lbl_Customer = new System.Windows.Forms.Label();
            this.Dgv_CustomerOverview = new System.Windows.Forms.DataGridView();
            this.Txt_CustomerSearch = new System.Windows.Forms.TextBox();
            this.CustomerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerManage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CustomerOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Btn_CustomerAdd
            // 
            this.Btn_CustomerAdd.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CustomerAdd.Image")));
            this.Btn_CustomerAdd.Location = new System.Drawing.Point(60, 120);
            this.Btn_CustomerAdd.Name = "Btn_CustomerAdd";
            this.Btn_CustomerAdd.Size = new System.Drawing.Size(110, 93);
            this.Btn_CustomerAdd.TabIndex = 6;
            this.Btn_CustomerAdd.Text = "Toevoegen";
            this.Btn_CustomerAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_CustomerAdd.UseVisualStyleBackColor = true;
            // 
            // Lbl_Customer
            // 
            this.Lbl_Customer.AutoSize = true;
            this.Lbl_Customer.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Customer.Location = new System.Drawing.Point(53, 35);
            this.Lbl_Customer.Name = "Lbl_Customer";
            this.Lbl_Customer.Size = new System.Drawing.Size(165, 41);
            this.Lbl_Customer.TabIndex = 7;
            this.Lbl_Customer.Text = "Klanten";
            // 
            // Dgv_CustomerOverview
            // 
            this.Dgv_CustomerOverview.AllowUserToAddRows = false;
            this.Dgv_CustomerOverview.AllowUserToDeleteRows = false;
            this.Dgv_CustomerOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CustomerOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerFirstName,
            this.CustomerLastName,
            this.CustomerManage});
            this.Dgv_CustomerOverview.Location = new System.Drawing.Point(60, 238);
            this.Dgv_CustomerOverview.Name = "Dgv_CustomerOverview";
            this.Dgv_CustomerOverview.RowHeadersWidth = 51;
            this.Dgv_CustomerOverview.RowTemplate.Height = 24;
            this.Dgv_CustomerOverview.Size = new System.Drawing.Size(775, 283);
            this.Dgv_CustomerOverview.TabIndex = 8;
            // 
            // Txt_CustomerSearch
            // 
            this.Txt_CustomerSearch.Location = new System.Drawing.Point(638, 120);
            this.Txt_CustomerSearch.Name = "Txt_CustomerSearch";
            this.Txt_CustomerSearch.Size = new System.Drawing.Size(197, 22);
            this.Txt_CustomerSearch.TabIndex = 9;
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.HeaderText = "Voornaam";
            this.CustomerFirstName.MinimumWidth = 6;
            this.CustomerFirstName.Name = "CustomerFirstName";
            this.CustomerFirstName.Width = 125;
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.HeaderText = "Achternaam";
            this.CustomerLastName.MinimumWidth = 6;
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.Width = 125;
            // 
            // CustomerManage
            // 
            this.CustomerManage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerManage.HeaderText = "Beheer";
            this.CustomerManage.MinimumWidth = 6;
            this.CustomerManage.Name = "CustomerManage";
            this.CustomerManage.ReadOnly = true;
            // 
            // CustomerOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_CustomerSearch);
            this.Controls.Add(this.Dgv_CustomerOverview);
            this.Controls.Add(this.Lbl_Customer);
            this.Controls.Add(this.Btn_CustomerAdd);
            this.Name = "CustomerOverview";
            this.Size = new System.Drawing.Size(895, 554);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CustomerOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Btn_CustomerAdd;
        private System.Windows.Forms.Label Lbl_Customer;
        private System.Windows.Forms.DataGridView Dgv_CustomerOverview;
        private System.Windows.Forms.TextBox Txt_CustomerSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerManage;
    }
}
