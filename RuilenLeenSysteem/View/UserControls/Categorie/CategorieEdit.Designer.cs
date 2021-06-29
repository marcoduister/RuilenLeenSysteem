
namespace RuilenLeenSysteem.View.UserControls.Categorie
{
    partial class CategorieEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorieEdit));
            this.Txt_CategorieDescription = new System.Windows.Forms.TextBox();
            this.Txt_CategorieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Customer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_CategorieChange = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_CategorieDescription
            // 
            this.Txt_CategorieDescription.Location = new System.Drawing.Point(333, 224);
            this.Txt_CategorieDescription.Multiline = true;
            this.Txt_CategorieDescription.Name = "Txt_CategorieDescription";
            this.Txt_CategorieDescription.Size = new System.Drawing.Size(168, 101);
            this.Txt_CategorieDescription.TabIndex = 43;
            // 
            // Txt_CategorieName
            // 
            this.Txt_CategorieName.Location = new System.Drawing.Point(333, 151);
            this.Txt_CategorieName.Name = "Txt_CategorieName";
            this.Txt_CategorieName.Size = new System.Drawing.Size(168, 22);
            this.Txt_CategorieName.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Beschrijving:";
            // 
            // Lbl_Customer
            // 
            this.Lbl_Customer.AutoSize = true;
            this.Lbl_Customer.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Customer.Location = new System.Drawing.Point(99, 51);
            this.Lbl_Customer.Name = "Lbl_Customer";
            this.Lbl_Customer.Size = new System.Drawing.Size(362, 40);
            this.Lbl_Customer.TabIndex = 40;
            this.Lbl_Customer.Text = "Categorie wijzigen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Naam:";
            // 
            // Btn_CategorieChange
            // 
            this.Btn_CategorieChange.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CategorieChange.Image")));
            this.Btn_CategorieChange.Location = new System.Drawing.Point(391, 381);
            this.Btn_CategorieChange.Name = "Btn_CategorieChange";
            this.Btn_CategorieChange.Size = new System.Drawing.Size(110, 93);
            this.Btn_CategorieChange.TabIndex = 38;
            this.Btn_CategorieChange.Text = "Wijzigen";
            this.Btn_CategorieChange.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_CategorieChange.UseVisualStyleBackColor = true;
            this.Btn_CategorieChange.Click += new System.EventHandler(this.Btn_CategorieChange_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(275, 381);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(110, 93);
            this.Btn_Cancel.TabIndex = 44;
            this.Btn_Cancel.Text = "Annuleren";
            this.Btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // CategorieEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Txt_CategorieDescription);
            this.Controls.Add(this.Txt_CategorieName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_CategorieChange);
            this.Name = "CategorieEdit";
            this.Size = new System.Drawing.Size(895, 554);
            this.Load += new System.EventHandler(this.CategorieEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_CategorieDescription;
        private System.Windows.Forms.TextBox Txt_CategorieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_CategorieChange;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}
