
namespace RuilenLeenSysteem.View.UserControls.Categorie
{
    partial class CategorieAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorieAdd));
            this.Btn_CategorieAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Customer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_CategorieName = new System.Windows.Forms.TextBox();
            this.Txt_CategorieDescription = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_CategorieAdd
            // 
            this.Btn_CategorieAdd.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CategorieAdd.Image")));
            this.Btn_CategorieAdd.Location = new System.Drawing.Point(369, 390);
            this.Btn_CategorieAdd.Name = "Btn_CategorieAdd";
            this.Btn_CategorieAdd.Size = new System.Drawing.Size(110, 93);
            this.Btn_CategorieAdd.TabIndex = 11;
            this.Btn_CategorieAdd.Text = "Toevoegen";
            this.Btn_CategorieAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_CategorieAdd.UseVisualStyleBackColor = true;
            this.Btn_CategorieAdd.Click += new System.EventHandler(this.Btn_CategorieAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Naam:";
            // 
            // Lbl_Customer
            // 
            this.Lbl_Customer.AutoSize = true;
            this.Lbl_Customer.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Customer.Location = new System.Drawing.Point(77, 60);
            this.Lbl_Customer.Name = "Lbl_Customer";
            this.Lbl_Customer.Size = new System.Drawing.Size(195, 40);
            this.Lbl_Customer.TabIndex = 32;
            this.Lbl_Customer.Text = "Categorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Beschrijving:";
            // 
            // Txt_CategorieName
            // 
            this.Txt_CategorieName.Location = new System.Drawing.Point(311, 160);
            this.Txt_CategorieName.Name = "Txt_CategorieName";
            this.Txt_CategorieName.Size = new System.Drawing.Size(168, 22);
            this.Txt_CategorieName.TabIndex = 36;
            // 
            // Txt_CategorieDescription
            // 
            this.Txt_CategorieDescription.Location = new System.Drawing.Point(311, 233);
            this.Txt_CategorieDescription.Multiline = true;
            this.Txt_CategorieDescription.Name = "Txt_CategorieDescription";
            this.Txt_CategorieDescription.Size = new System.Drawing.Size(168, 101);
            this.Txt_CategorieDescription.TabIndex = 37;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(241, 390);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(110, 93);
            this.Btn_Cancel.TabIndex = 38;
            this.Btn_Cancel.Text = "Annuleren";
            this.Btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // CategorieAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Txt_CategorieDescription);
            this.Controls.Add(this.Txt_CategorieName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_CategorieAdd);
            this.Name = "CategorieAdd";
            this.Size = new System.Drawing.Size(895, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CategorieAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_CategorieName;
        private System.Windows.Forms.TextBox Txt_CategorieDescription;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}
