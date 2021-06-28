
namespace RuilenLeenSysteem.View.UserControls.Products
{
    partial class ProductEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEdit));
            this.Btn_ProductEdit = new System.Windows.Forms.Button();
            this.Btn_ProductPhotoUpload = new System.Windows.Forms.Button();
            this.Pbx_ProductImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_ProductCategorie = new System.Windows.Forms.ComboBox();
            this.Txt_ProductDescription = new System.Windows.Forms.TextBox();
            this.Txt_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Txt_ProductPoints = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Txt_Customer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ProductEdit
            // 
            this.Btn_ProductEdit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ProductEdit.Image")));
            this.Btn_ProductEdit.Location = new System.Drawing.Point(726, 435);
            this.Btn_ProductEdit.Name = "Btn_ProductEdit";
            this.Btn_ProductEdit.Size = new System.Drawing.Size(110, 93);
            this.Btn_ProductEdit.TabIndex = 66;
            this.Btn_ProductEdit.Text = "Wijzig";
            this.Btn_ProductEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_ProductEdit.UseVisualStyleBackColor = true;
            this.Btn_ProductEdit.Click += new System.EventHandler(this.Btn_ProductEdit_Click);
            // 
            // Btn_ProductPhotoUpload
            // 
            this.Btn_ProductPhotoUpload.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ProductPhotoUpload.Image")));
            this.Btn_ProductPhotoUpload.Location = new System.Drawing.Point(662, 284);
            this.Btn_ProductPhotoUpload.Name = "Btn_ProductPhotoUpload";
            this.Btn_ProductPhotoUpload.Size = new System.Drawing.Size(110, 93);
            this.Btn_ProductPhotoUpload.TabIndex = 65;
            this.Btn_ProductPhotoUpload.Text = "Uploaden";
            this.Btn_ProductPhotoUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_ProductPhotoUpload.UseVisualStyleBackColor = true;
            // 
            // Pbx_ProductImage
            // 
            this.Pbx_ProductImage.Location = new System.Drawing.Point(554, 74);
            this.Pbx_ProductImage.Name = "Pbx_ProductImage";
            this.Pbx_ProductImage.Size = new System.Drawing.Size(218, 190);
            this.Pbx_ProductImage.TabIndex = 64;
            this.Pbx_ProductImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 63;
            this.label5.Text = "Categorie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "Punten:";
            // 
            // Cbx_ProductCategorie
            // 
            this.Cbx_ProductCategorie.FormattingEnabled = true;
            this.Cbx_ProductCategorie.Location = new System.Drawing.Point(237, 355);
            this.Cbx_ProductCategorie.Name = "Cbx_ProductCategorie";
            this.Cbx_ProductCategorie.Size = new System.Drawing.Size(168, 24);
            this.Cbx_ProductCategorie.TabIndex = 61;
            this.Cbx_ProductCategorie.SelectedIndexChanged += new System.EventHandler(this.Cbx_ProductCategorie_SelectedIndexChanged);
            // 
            // Txt_ProductDescription
            // 
            this.Txt_ProductDescription.Location = new System.Drawing.Point(237, 135);
            this.Txt_ProductDescription.Multiline = true;
            this.Txt_ProductDescription.Name = "Txt_ProductDescription";
            this.Txt_ProductDescription.Size = new System.Drawing.Size(168, 101);
            this.Txt_ProductDescription.TabIndex = 59;
            // 
            // Txt_ProductName
            // 
            this.Txt_ProductName.Location = new System.Drawing.Point(237, 74);
            this.Txt_ProductName.Name = "Txt_ProductName";
            this.Txt_ProductName.Size = new System.Drawing.Size(168, 22);
            this.Txt_ProductName.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "Beschrijving:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Naam:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(58, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(161, 40);
            this.Label1.TabIndex = 55;
            this.Label1.Text = "Product";
            // 
            // Txt_ProductPoints
            // 
            this.Txt_ProductPoints.Location = new System.Drawing.Point(237, 298);
            this.Txt_ProductPoints.Name = "Txt_ProductPoints";
            this.Txt_ProductPoints.Size = new System.Drawing.Size(168, 22);
            this.Txt_ProductPoints.TabIndex = 67;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(610, 435);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(110, 93);
            this.Btn_Cancel.TabIndex = 68;
            this.Btn_Cancel.Text = "Annuleren";
            this.Btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Txt_Customer
            // 
            this.Txt_Customer.Location = new System.Drawing.Point(237, 254);
            this.Txt_Customer.Name = "Txt_Customer";
            this.Txt_Customer.ReadOnly = true;
            this.Txt_Customer.Size = new System.Drawing.Size(168, 22);
            this.Txt_Customer.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Customer:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_Customer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Txt_ProductPoints);
            this.Controls.Add(this.Btn_ProductEdit);
            this.Controls.Add(this.Btn_ProductPhotoUpload);
            this.Controls.Add(this.Pbx_ProductImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbx_ProductCategorie);
            this.Controls.Add(this.Txt_ProductDescription);
            this.Controls.Add(this.Txt_ProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label1);
            this.Name = "ProductEdit";
            this.Size = new System.Drawing.Size(895, 554);
            this.Load += new System.EventHandler(this.ProductEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ProductEdit;
        private System.Windows.Forms.Button Btn_ProductPhotoUpload;
        private System.Windows.Forms.PictureBox Pbx_ProductImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbx_ProductCategorie;
        private System.Windows.Forms.TextBox Txt_ProductDescription;
        private System.Windows.Forms.TextBox Txt_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Txt_ProductPoints;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.TextBox Txt_Customer;
        private System.Windows.Forms.Label label6;
    }
}
