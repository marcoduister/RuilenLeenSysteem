
namespace RuilenLeenSysteem.View
{
    partial class login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_LoginVolunteer = new System.Windows.Forms.Button();
            this.Btn_LoginIT_Employee = new System.Windows.Forms.Button();
            this.Btn_LoginAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_LoginVolunteer
            // 
            this.Btn_LoginVolunteer.Location = new System.Drawing.Point(44, 149);
            this.Btn_LoginVolunteer.Name = "Btn_LoginVolunteer";
            this.Btn_LoginVolunteer.Size = new System.Drawing.Size(124, 35);
            this.Btn_LoginVolunteer.TabIndex = 8;
            this.Btn_LoginVolunteer.Text = "Vrijwiliger";
            this.Btn_LoginVolunteer.UseVisualStyleBackColor = true;
            this.Btn_LoginVolunteer.Click += new System.EventHandler(this.Btn_LoginVolunteer_Click);
            // 
            // Btn_LoginIT_Employee
            // 
            this.Btn_LoginIT_Employee.Location = new System.Drawing.Point(174, 149);
            this.Btn_LoginIT_Employee.Name = "Btn_LoginIT_Employee";
            this.Btn_LoginIT_Employee.Size = new System.Drawing.Size(124, 35);
            this.Btn_LoginIT_Employee.TabIndex = 9;
            this.Btn_LoginIT_Employee.Text = "ICT-Medewerker";
            this.Btn_LoginIT_Employee.UseVisualStyleBackColor = true;
            this.Btn_LoginIT_Employee.Click += new System.EventHandler(this.Btn_LoginIT_Employee_Click);
            // 
            // Btn_LoginAdmin
            // 
            this.Btn_LoginAdmin.Location = new System.Drawing.Point(304, 149);
            this.Btn_LoginAdmin.Name = "Btn_LoginAdmin";
            this.Btn_LoginAdmin.Size = new System.Drawing.Size(124, 35);
            this.Btn_LoginAdmin.TabIndex = 10;
            this.Btn_LoginAdmin.Text = "Beheerder";
            this.Btn_LoginAdmin.UseVisualStyleBackColor = true;
            this.Btn_LoginAdmin.Click += new System.EventHandler(this.Btn_LoginAdmin_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 235);
            this.Controls.Add(this.Btn_LoginAdmin);
            this.Controls.Add(this.Btn_LoginIT_Employee);
            this.Controls.Add(this.Btn_LoginVolunteer);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_LoginVolunteer;
        private System.Windows.Forms.Button Btn_LoginIT_Employee;
        private System.Windows.Forms.Button Btn_LoginAdmin;
    }
}