
namespace RuilenLeenSysteem.View.UserControls.Trade
{
    partial class Trading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trading));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_TradeProductCustomer = new System.Windows.Forms.ComboBox();
            this.Cbx_TradeProductPoints = new System.Windows.Forms.ComboBox();
            this.Txt_TradeProductDescription = new System.Windows.Forms.TextBox();
            this.Txt_TradeProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Btn_ProductAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 60;
            this.label5.Text = "Klant:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 59;
            this.label4.Text = "Punten:";
            // 
            // Cbx_TradeProductCustomer
            // 
            this.Cbx_TradeProductCustomer.FormattingEnabled = true;
            this.Cbx_TradeProductCustomer.Location = new System.Drawing.Point(281, 365);
            this.Cbx_TradeProductCustomer.Name = "Cbx_TradeProductCustomer";
            this.Cbx_TradeProductCustomer.Size = new System.Drawing.Size(168, 24);
            this.Cbx_TradeProductCustomer.TabIndex = 58;
            // 
            // Cbx_TradeProductPoints
            // 
            this.Cbx_TradeProductPoints.FormattingEnabled = true;
            this.Cbx_TradeProductPoints.Location = new System.Drawing.Point(281, 308);
            this.Cbx_TradeProductPoints.Name = "Cbx_TradeProductPoints";
            this.Cbx_TradeProductPoints.Size = new System.Drawing.Size(168, 24);
            this.Cbx_TradeProductPoints.TabIndex = 57;
            // 
            // Txt_TradeProductDescription
            // 
            this.Txt_TradeProductDescription.Location = new System.Drawing.Point(281, 159);
            this.Txt_TradeProductDescription.Multiline = true;
            this.Txt_TradeProductDescription.Name = "Txt_TradeProductDescription";
            this.Txt_TradeProductDescription.Size = new System.Drawing.Size(168, 101);
            this.Txt_TradeProductDescription.TabIndex = 56;
            // 
            // Txt_TradeProductName
            // 
            this.Txt_TradeProductName.Location = new System.Drawing.Point(281, 98);
            this.Txt_TradeProductName.Name = "Txt_TradeProductName";
            this.Txt_TradeProductName.Size = new System.Drawing.Size(168, 22);
            this.Txt_TradeProductName.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Beschrijving:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Product:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(102, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(135, 40);
            this.Label1.TabIndex = 52;
            this.Label1.Text = "Ruilen";
            // 
            // Btn_ProductAdd
            // 
            this.Btn_ProductAdd.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ProductAdd.Image")));
            this.Btn_ProductAdd.Location = new System.Drawing.Point(455, 422);
            this.Btn_ProductAdd.Name = "Btn_ProductAdd";
            this.Btn_ProductAdd.Size = new System.Drawing.Size(110, 93);
            this.Btn_ProductAdd.TabIndex = 61;
            this.Btn_ProductAdd.Text = "Ruilen";
            this.Btn_ProductAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_ProductAdd.UseVisualStyleBackColor = true;
            // 
            // Trading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_ProductAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbx_TradeProductCustomer);
            this.Controls.Add(this.Cbx_TradeProductPoints);
            this.Controls.Add(this.Txt_TradeProductDescription);
            this.Controls.Add(this.Txt_TradeProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label1);
            this.Name = "Trading";
            this.Size = new System.Drawing.Size(895, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbx_TradeProductCustomer;
        private System.Windows.Forms.ComboBox Cbx_TradeProductPoints;
        private System.Windows.Forms.TextBox Txt_TradeProductDescription;
        private System.Windows.Forms.TextBox Txt_TradeProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Btn_ProductAdd;
    }
}
