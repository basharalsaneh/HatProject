namespace HatProject1.Orders
{
    partial class Form5CreateOrders
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
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxProjectDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnBackCO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Deadline";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(338, 181);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(67, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category";
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(70, 133);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(120, 17);
            this.listBoxCategory.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Choose Personnel";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(67, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Project Description";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(67, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Project Name";
            // 
            // richTextBoxProjectDescription
            // 
            this.richTextBoxProjectDescription.Location = new System.Drawing.Point(70, 181);
            this.richTextBoxProjectDescription.Name = "richTextBoxProjectDescription";
            this.richTextBoxProjectDescription.Size = new System.Drawing.Size(206, 159);
            this.richTextBoxProjectDescription.TabIndex = 13;
            this.richTextBoxProjectDescription.Text = "";
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(70, 85);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(206, 20);
            this.textBoxProjectName.TabIndex = 12;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Personal1",
            "Personal2"});
            this.checkedListBox1.Location = new System.Drawing.Point(338, 85);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(129, 49);
            this.checkedListBox1.TabIndex = 11;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(621, 319);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(106, 24);
            this.btnAddOrder.TabIndex = 18;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnBackCO
            // 
            this.btnBackCO.Location = new System.Drawing.Point(13, 13);
            this.btnBackCO.Name = "btnBackCO";
            this.btnBackCO.Size = new System.Drawing.Size(75, 23);
            this.btnBackCO.TabIndex = 19;
            this.btnBackCO.Text = "Go Back";
            this.btnBackCO.UseVisualStyleBackColor = true;
            this.btnBackCO.Click += new System.EventHandler(this.btnBackCO_Click);
            // 
            // Form5CreateOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackCO);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxProjectDescription);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form5CreateOrders";
            this.Text = "Form5CreateOrders";
            this.Load += new System.EventHandler(this.Form5CreateOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxProjectDescription;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnBackCO;
    }
}