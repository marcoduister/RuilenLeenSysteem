
namespace RuilenLeenSysteem.View.UserControls.Trade
{
    partial class TradeOverview
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
            this.Txt_TradeProductSearch = new System.Windows.Forms.TextBox();
            this.Dgv_TradeProductOverview = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TradeProductOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_TradeProductSearch
            // 
            this.Txt_TradeProductSearch.Location = new System.Drawing.Point(641, 119);
            this.Txt_TradeProductSearch.Name = "Txt_TradeProductSearch";
            this.Txt_TradeProductSearch.Size = new System.Drawing.Size(197, 22);
            this.Txt_TradeProductSearch.TabIndex = 21;
            // 
            // Dgv_TradeProductOverview
            // 
            this.Dgv_TradeProductOverview.AllowUserToAddRows = false;
            this.Dgv_TradeProductOverview.AllowUserToDeleteRows = false;
            this.Dgv_TradeProductOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TradeProductOverview.Location = new System.Drawing.Point(63, 237);
            this.Dgv_TradeProductOverview.Name = "Dgv_TradeProductOverview";
            this.Dgv_TradeProductOverview.RowHeadersWidth = 51;
            this.Dgv_TradeProductOverview.RowTemplate.Height = 24;
            this.Dgv_TradeProductOverview.Size = new System.Drawing.Size(775, 283);
            this.Dgv_TradeProductOverview.TabIndex = 20;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(70, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(135, 40);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Ruilen";
            // 
            // TradeOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_TradeProductSearch);
            this.Controls.Add(this.Dgv_TradeProductOverview);
            this.Controls.Add(this.Label1);
            this.Name = "TradeOverview";
            this.Size = new System.Drawing.Size(895, 554);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TradeProductOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_TradeProductSearch;
        private System.Windows.Forms.DataGridView Dgv_TradeProductOverview;
        private System.Windows.Forms.Label Label1;
    }
}
