
namespace Linq_feladat
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
            this.listCountries = new System.Windows.Forms.ListBox();
            this.txtCountryFilter = new System.Windows.Forms.TextBox();
            this.dgwRamen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRamen)).BeginInit();
            this.SuspendLayout();
            // 
            // listCountries
            // 
            this.listCountries.FormattingEnabled = true;
            this.listCountries.ItemHeight = 15;
            this.listCountries.Location = new System.Drawing.Point(13, 40);
            this.listCountries.Name = "listCountries";
            this.listCountries.Size = new System.Drawing.Size(197, 394);
            this.listCountries.TabIndex = 0;
            this.listCountries.SelectedIndexChanged += new System.EventHandler(this.listCountries_SelectedIndexChanged);
            // 
            // txtCountryFilter
            // 
            this.txtCountryFilter.Location = new System.Drawing.Point(13, 12);
            this.txtCountryFilter.Name = "txtCountryFilter";
            this.txtCountryFilter.Size = new System.Drawing.Size(197, 23);
            this.txtCountryFilter.TabIndex = 1;
            this.txtCountryFilter.TextChanged += new System.EventHandler(this.txtCountryFilter_TextChanged);
            // 
            // dgwRamen
            // 
            this.dgwRamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRamen.Location = new System.Drawing.Point(216, 40);
            this.dgwRamen.Name = "dgwRamen";
            this.dgwRamen.RowTemplate.Height = 25;
            this.dgwRamen.Size = new System.Drawing.Size(572, 394);
            this.dgwRamen.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwRamen);
            this.Controls.Add(this.txtCountryFilter);
            this.Controls.Add(this.listCountries);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRamen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCountries;
        private System.Windows.Forms.TextBox txtCountryFilter;
        private System.Windows.Forms.DataGridView dgwRamen;
    }
}

