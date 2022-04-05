namespace HatProject1
{
    partial class Form3Customers
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
            this.btnBackCustomers = new System.Windows.Forms.Button();
            this.richTextBoxCustomers = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnBackCustomers
            // 
            this.btnBackCustomers.Location = new System.Drawing.Point(13, 13);
            this.btnBackCustomers.Name = "btnBackCustomers";
            this.btnBackCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnBackCustomers.TabIndex = 0;
            this.btnBackCustomers.Text = "Go Back";
            this.btnBackCustomers.UseVisualStyleBackColor = true;
            this.btnBackCustomers.Click += new System.EventHandler(this.btnBackCustomers_Click);
            // 
            // richTextBoxCustomers
            // 
            this.richTextBoxCustomers.Location = new System.Drawing.Point(171, 51);
            this.richTextBoxCustomers.Name = "richTextBoxCustomers";
            this.richTextBoxCustomers.Size = new System.Drawing.Size(516, 352);
            this.richTextBoxCustomers.TabIndex = 1;
            this.richTextBoxCustomers.Text = "";
            // 
            // Form3Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxCustomers);
            this.Controls.Add(this.btnBackCustomers);
            this.Name = "Form3Customers";
            this.Text = "Form3Customers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackCustomers;
        private System.Windows.Forms.RichTextBox richTextBoxCustomers;
    }
}