﻿
namespace RuilenLeenSysteem.View.UserControls.Products
{
    partial class ProductAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdd));
            this.Label1 = new System.Windows.Forms.Label();
            this.Txt_ProductDescription = new System.Windows.Forms.TextBox();
            this.Txt_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbx_ProductPoints = new System.Windows.Forms.ComboBox();
            this.Cbx_ProductCategorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pbx_ProductImage = new System.Windows.Forms.PictureBox();
            this.Btn_ProductPhotoUpload = new System.Windows.Forms.Button();
            this.Btn_ProductAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(63, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(161, 40);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Product";
            // 
            // Txt_ProductDescription
            // 
            this.Txt_ProductDescription.Location = new System.Drawing.Point(242, 126);
            this.Txt_ProductDescription.Multiline = true;
            this.Txt_ProductDescription.Name = "Txt_ProductDescription";
            this.Txt_ProductDescription.Size = new System.Drawing.Size(168, 101);
            this.Txt_ProductDescription.TabIndex = 47;
            // 
            // Txt_ProductName
            // 
            this.Txt_ProductName.Location = new System.Drawing.Point(242, 65);
            this.Txt_ProductName.Name = "Txt_ProductName";
            this.Txt_ProductName.Size = new System.Drawing.Size(168, 22);
            this.Txt_ProductName.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Beschrijving:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Naam:";
            // 
            // Cbx_ProductPoints
            // 
            this.Cbx_ProductPoints.FormattingEnabled = true;
            this.Cbx_ProductPoints.Location = new System.Drawing.Point(242, 275);
            this.Cbx_ProductPoints.Name = "Cbx_ProductPoints";
            this.Cbx_ProductPoints.Size = new System.Drawing.Size(168, 24);
            this.Cbx_ProductPoints.TabIndex = 48;
            // 
            // Cbx_ProductCategorie
            // 
            this.Cbx_ProductCategorie.FormattingEnabled = true;
            this.Cbx_ProductCategorie.Location = new System.Drawing.Point(242, 332);
            this.Cbx_ProductCategorie.Name = "Cbx_ProductCategorie";
            this.Cbx_ProductCategorie.Size = new System.Drawing.Size(168, 24);
            this.Cbx_ProductCategorie.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "Punten:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Categorie:";
            // 
            // Pbx_ProductImage
            // 
            this.Pbx_ProductImage.Location = new System.Drawing.Point(559, 65);
            this.Pbx_ProductImage.Name = "Pbx_ProductImage";
            this.Pbx_ProductImage.Size = new System.Drawing.Size(218, 190);
            this.Pbx_ProductImage.TabIndex = 52;
            this.Pbx_ProductImage.TabStop = false;
            // 
            // Btn_ProductPhotoUpload
            // 
            this.Btn_ProductPhotoUpload.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ProductPhotoUpload.Image")));
            this.Btn_ProductPhotoUpload.Location = new System.Drawing.Point(667, 275);
            this.Btn_ProductPhotoUpload.Name = "Btn_ProductPhotoUpload";
            this.Btn_ProductPhotoUpload.Size = new System.Drawing.Size(110, 93);
            this.Btn_ProductPhotoUpload.TabIndex = 53;
            this.Btn_ProductPhotoUpload.Text = "Uploaden";
            this.Btn_ProductPhotoUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_ProductPhotoUpload.UseVisualStyleBackColor = true;
            // 
            // Btn_ProductAdd
            // 
            this.Btn_ProductAdd.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ProductAdd.Image")));
            this.Btn_ProductAdd.Location = new System.Drawing.Point(731, 426);
            this.Btn_ProductAdd.Name = "Btn_ProductAdd";
            this.Btn_ProductAdd.Size = new System.Drawing.Size(110, 93);
            this.Btn_ProductAdd.TabIndex = 54;
            this.Btn_ProductAdd.Text = "Toevoegen";
            this.Btn_ProductAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_ProductAdd.UseVisualStyleBackColor = true;
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_ProductAdd);
            this.Controls.Add(this.Btn_ProductPhotoUpload);
            this.Controls.Add(this.Pbx_ProductImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbx_ProductCategorie);
            this.Controls.Add(this.Cbx_ProductPoints);
            this.Controls.Add(this.Txt_ProductDescription);
            this.Controls.Add(this.Txt_ProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label1);
            this.Name = "ProductAdd";
            this.Size = new System.Drawing.Size(895, 554);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Txt_ProductDescription;
        private System.Windows.Forms.TextBox Txt_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbx_ProductPoints;
        private System.Windows.Forms.ComboBox Cbx_ProductCategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Pbx_ProductImage;
        private System.Windows.Forms.Button Btn_ProductPhotoUpload;
        private System.Windows.Forms.Button Btn_ProductAdd;
    }
}