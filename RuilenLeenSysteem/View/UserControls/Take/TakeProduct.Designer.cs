﻿
namespace RuilenLeenSysteem.View.UserControls.Take
{
    partial class TakeProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeProduct));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_ProductCategorie = new System.Windows.Forms.ComboBox();
            this.Cbx_ProductCustomer = new System.Windows.Forms.ComboBox();
            this.Txt_ProductDescription = new System.Windows.Forms.TextBox();
            this.Txt_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Txt_ProductAccessories = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_TakeProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 72;
            this.label5.Text = "Aantal labels:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 71;
            this.label4.Text = "Klant:";
            // 
            // Cbx_ProductCategorie
            // 
            this.Cbx_ProductCategorie.FormattingEnabled = true;
            this.Cbx_ProductCategorie.Location = new System.Drawing.Point(228, 323);
            this.Cbx_ProductCategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbx_ProductCategorie.Name = "Cbx_ProductCategorie";
            this.Cbx_ProductCategorie.Size = new System.Drawing.Size(127, 21);
            this.Cbx_ProductCategorie.TabIndex = 70;
            // 
            // Cbx_ProductCustomer
            // 
            this.Cbx_ProductCustomer.FormattingEnabled = true;
            this.Cbx_ProductCustomer.Location = new System.Drawing.Point(228, 228);
            this.Cbx_ProductCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbx_ProductCustomer.Name = "Cbx_ProductCustomer";
            this.Cbx_ProductCustomer.Size = new System.Drawing.Size(127, 21);
            this.Cbx_ProductCustomer.TabIndex = 69;
            // 
            // Txt_ProductDescription
            // 
            this.Txt_ProductDescription.Location = new System.Drawing.Point(228, 121);
            this.Txt_ProductDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_ProductDescription.Multiline = true;
            this.Txt_ProductDescription.Name = "Txt_ProductDescription";
            this.Txt_ProductDescription.Size = new System.Drawing.Size(127, 83);
            this.Txt_ProductDescription.TabIndex = 68;
            // 
            // Txt_ProductName
            // 
            this.Txt_ProductName.Location = new System.Drawing.Point(228, 72);
            this.Txt_ProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_ProductName.Name = "Txt_ProductName";
            this.Txt_ProductName.Size = new System.Drawing.Size(127, 20);
            this.Txt_ProductName.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Beschrijving:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Naam:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(81, 24);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(309, 32);
            this.Label1.TabIndex = 64;
            this.Label1.Text = "Product aannemen";
            // 
            // Txt_ProductAccessories
            // 
            this.Txt_ProductAccessories.Location = new System.Drawing.Point(228, 276);
            this.Txt_ProductAccessories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_ProductAccessories.Name = "Txt_ProductAccessories";
            this.Txt_ProductAccessories.Size = new System.Drawing.Size(127, 20);
            this.Txt_ProductAccessories.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "Bij geleverd:";
            // 
            // Btn_TakeProduct
            // 
            this.Btn_TakeProduct.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TakeProduct.Image")));
            this.Btn_TakeProduct.Location = new System.Drawing.Point(272, 358);
            this.Btn_TakeProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_TakeProduct.Name = "Btn_TakeProduct";
            this.Btn_TakeProduct.Size = new System.Drawing.Size(82, 76);
            this.Btn_TakeProduct.TabIndex = 77;
            this.Btn_TakeProduct.Text = "Aannemen ";
            this.Btn_TakeProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_TakeProduct.UseVisualStyleBackColor = true;
            this.Btn_TakeProduct.Click += new System.EventHandler(this.Btn_TakeProduct_Click);
            // 
            // TakeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_TakeProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_ProductAccessories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbx_ProductCategorie);
            this.Controls.Add(this.Cbx_ProductCustomer);
            this.Controls.Add(this.Txt_ProductDescription);
            this.Controls.Add(this.Txt_ProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TakeProduct";
            this.Size = new System.Drawing.Size(584, 290);
            this.Load += new System.EventHandler(this.TakeProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbx_ProductCategorie;
        private System.Windows.Forms.ComboBox Cbx_ProductCustomer;
        private System.Windows.Forms.TextBox Txt_ProductDescription;
        private System.Windows.Forms.TextBox Txt_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Txt_ProductAccessories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_TakeProduct;
    }
}
