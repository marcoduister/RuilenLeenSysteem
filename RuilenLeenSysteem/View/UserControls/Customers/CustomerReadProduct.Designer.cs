
namespace RuilenLeenSysteem.View.UserControls.Customers
{
    partial class CustomerReadProduct
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
            this.Lbl_Customer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_CustomerFirstName = new System.Windows.Forms.TextBox();
            this.Txt_CustomerAdress = new System.Windows.Forms.TextBox();
            this.Txt_CustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.Txt_CustomerEmail = new System.Windows.Forms.TextBox();
            this.Txt_CustomerLastName = new System.Windows.Forms.TextBox();
            this.Dgv_TradeView = new System.Windows.Forms.DataGridView();
            this.Dgv_BorrowView = new System.Windows.Forms.DataGridView();
            this.Product_borrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points_borrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eindBorrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_balance = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.BrProduct_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TradeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_BorrowView)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Customer
            // 
            this.Lbl_Customer.AutoSize = true;
            this.Lbl_Customer.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Customer.Location = new System.Drawing.Point(97, 28);
            this.Lbl_Customer.Name = "Lbl_Customer";
            this.Lbl_Customer.Size = new System.Drawing.Size(114, 40);
            this.Lbl_Customer.TabIndex = 8;
            this.Lbl_Customer.Text = "Klant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Achternaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefoon nummer:";
            // 
            // Txt_CustomerFirstName
            // 
            this.Txt_CustomerFirstName.Location = new System.Drawing.Point(251, 94);
            this.Txt_CustomerFirstName.Name = "Txt_CustomerFirstName";
            this.Txt_CustomerFirstName.ReadOnly = true;
            this.Txt_CustomerFirstName.Size = new System.Drawing.Size(168, 22);
            this.Txt_CustomerFirstName.TabIndex = 14;
            // 
            // Txt_CustomerAdress
            // 
            this.Txt_CustomerAdress.Location = new System.Drawing.Point(251, 137);
            this.Txt_CustomerAdress.Name = "Txt_CustomerAdress";
            this.Txt_CustomerAdress.ReadOnly = true;
            this.Txt_CustomerAdress.Size = new System.Drawing.Size(168, 22);
            this.Txt_CustomerAdress.TabIndex = 15;
            // 
            // Txt_CustomerPhoneNumber
            // 
            this.Txt_CustomerPhoneNumber.Location = new System.Drawing.Point(251, 178);
            this.Txt_CustomerPhoneNumber.Name = "Txt_CustomerPhoneNumber";
            this.Txt_CustomerPhoneNumber.ReadOnly = true;
            this.Txt_CustomerPhoneNumber.Size = new System.Drawing.Size(168, 22);
            this.Txt_CustomerPhoneNumber.TabIndex = 16;
            // 
            // Txt_CustomerEmail
            // 
            this.Txt_CustomerEmail.Location = new System.Drawing.Point(680, 137);
            this.Txt_CustomerEmail.Name = "Txt_CustomerEmail";
            this.Txt_CustomerEmail.ReadOnly = true;
            this.Txt_CustomerEmail.Size = new System.Drawing.Size(168, 22);
            this.Txt_CustomerEmail.TabIndex = 17;
            // 
            // Txt_CustomerLastName
            // 
            this.Txt_CustomerLastName.Location = new System.Drawing.Point(680, 94);
            this.Txt_CustomerLastName.Name = "Txt_CustomerLastName";
            this.Txt_CustomerLastName.ReadOnly = true;
            this.Txt_CustomerLastName.Size = new System.Drawing.Size(168, 22);
            this.Txt_CustomerLastName.TabIndex = 18;
            // 
            // Dgv_TradeView
            // 
            this.Dgv_TradeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TradeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrProduct_Name,
            this.Points,
            this.OrderDate});
            this.Dgv_TradeView.Location = new System.Drawing.Point(33, 270);
            this.Dgv_TradeView.Name = "Dgv_TradeView";
            this.Dgv_TradeView.RowHeadersWidth = 51;
            this.Dgv_TradeView.RowTemplate.Height = 24;
            this.Dgv_TradeView.Size = new System.Drawing.Size(371, 245);
            this.Dgv_TradeView.TabIndex = 19;
            // 
            // Dgv_BorrowView
            // 
            this.Dgv_BorrowView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_BorrowView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_borrow,
            this.Points_borrow,
            this.StartDate,
            this.eindBorrow});
            this.Dgv_BorrowView.Location = new System.Drawing.Point(477, 270);
            this.Dgv_BorrowView.Name = "Dgv_BorrowView";
            this.Dgv_BorrowView.RowHeadersWidth = 51;
            this.Dgv_BorrowView.RowTemplate.Height = 24;
            this.Dgv_BorrowView.Size = new System.Drawing.Size(371, 245);
            this.Dgv_BorrowView.TabIndex = 20;
            // 
            // Product_borrow
            // 
            this.Product_borrow.Frozen = true;
            this.Product_borrow.HeaderText = "Product";
            this.Product_borrow.MinimumWidth = 6;
            this.Product_borrow.Name = "Product_borrow";
            this.Product_borrow.ReadOnly = true;
            this.Product_borrow.Width = 125;
            // 
            // Points_borrow
            // 
            this.Points_borrow.Frozen = true;
            this.Points_borrow.HeaderText = "punten";
            this.Points_borrow.MinimumWidth = 6;
            this.Points_borrow.Name = "Points_borrow";
            this.Points_borrow.ReadOnly = true;
            this.Points_borrow.Width = 125;
            // 
            // StartDate
            // 
            this.StartDate.Frozen = true;
            this.StartDate.HeaderText = "Start Leen Datum";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 125;
            // 
            // eindBorrow
            // 
            this.eindBorrow.Frozen = true;
            this.eindBorrow.HeaderText = "einde leen Datum";
            this.eindBorrow.MinimumWidth = 6;
            this.eindBorrow.Name = "eindBorrow";
            this.eindBorrow.ReadOnly = true;
            this.eindBorrow.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ruil overzicht";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Leen overzicht";
            // 
            // Txt_balance
            // 
            this.Txt_balance.Location = new System.Drawing.Point(680, 179);
            this.Txt_balance.Name = "Txt_balance";
            this.Txt_balance.ReadOnly = true;
            this.Txt_balance.Size = new System.Drawing.Size(168, 22);
            this.Txt_balance.TabIndex = 24;
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.Location = new System.Drawing.Point(549, 177);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(93, 23);
            this.Balance.TabIndex = 23;
            this.Balance.Text = "Balance:";
            // 
            // BrProduct_Name
            // 
            this.BrProduct_Name.Frozen = true;
            this.BrProduct_Name.HeaderText = "Product";
            this.BrProduct_Name.MinimumWidth = 6;
            this.BrProduct_Name.Name = "BrProduct_Name";
            this.BrProduct_Name.ReadOnly = true;
            this.BrProduct_Name.Width = 125;
            // 
            // Points
            // 
            this.Points.Frozen = true;
            this.Points.HeaderText = "punten";
            this.Points.MinimumWidth = 6;
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Width = 125;
            // 
            // OrderDate
            // 
            this.OrderDate.Frozen = true;
            this.OrderDate.HeaderText = "BestelDatum";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 125;
            // 
            // CustomerReadProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_balance);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dgv_BorrowView);
            this.Controls.Add(this.Dgv_TradeView);
            this.Controls.Add(this.Txt_CustomerLastName);
            this.Controls.Add(this.Txt_CustomerEmail);
            this.Controls.Add(this.Txt_CustomerPhoneNumber);
            this.Controls.Add(this.Txt_CustomerAdress);
            this.Controls.Add(this.Txt_CustomerFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Customer);
            this.Name = "CustomerReadProduct";
            this.Size = new System.Drawing.Size(895, 554);
            this.Load += new System.EventHandler(this.CustomerReadProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TradeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_BorrowView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_CustomerFirstName;
        private System.Windows.Forms.TextBox Txt_CustomerAdress;
        private System.Windows.Forms.TextBox Txt_CustomerPhoneNumber;
        private System.Windows.Forms.TextBox Txt_CustomerEmail;
        private System.Windows.Forms.TextBox Txt_CustomerLastName;
        private System.Windows.Forms.DataGridView Dgv_TradeView;
        private System.Windows.Forms.DataGridView Dgv_BorrowView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_borrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points_borrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn eindBorrow;
        private System.Windows.Forms.TextBox Txt_balance;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrProduct_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
    }
}
