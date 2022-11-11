
namespace UserMaintenance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listUsers = new System.Windows.Forms.ListBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 15;
            this.listUsers.Location = new System.Drawing.Point(29, 26);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(287, 289);
            this.listUsers.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(426, 39);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(184, 23);
            this.txtFullName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFirstName.Location = new System.Drawing.Point(426, 89);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(184, 23);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(355, 42);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(65, 15);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Vezetéknév";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(355, 92);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 15);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "Keresztnév";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(367, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(243, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Hozzáadás";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 352);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.listUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAdd;
    }
}

