namespace HatProject1
{
    partial class Form2Hat
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
            this.dataGridViewHatModels = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LableCurrentHatModels = new System.Windows.Forms.Label();
            this.labelNewHatModels = new System.Windows.Forms.Label();
            this.HatName = new System.Windows.Forms.TextBox();
            this.HatCategory = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddHat = new System.Windows.Forms.Button();
            this.btnBackHat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHatModels)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHatModels
            // 
            this.dataGridViewHatModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHatModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.Category,
            this.Column3});
            this.dataGridViewHatModels.Location = new System.Drawing.Point(434, 52);
            this.dataGridViewHatModels.Name = "dataGridViewHatModels";
            this.dataGridViewHatModels.Size = new System.Drawing.Size(332, 357);
            this.dataGridViewHatModels.TabIndex = 0;
            // 
            // CName
            // 
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            // 
            // LableCurrentHatModels
            // 
            this.LableCurrentHatModels.AutoSize = true;
            this.LableCurrentHatModels.Location = new System.Drawing.Point(570, 36);
            this.LableCurrentHatModels.Name = "LableCurrentHatModels";
            this.LableCurrentHatModels.Size = new System.Drawing.Size(61, 13);
            this.LableCurrentHatModels.TabIndex = 1;
            this.LableCurrentHatModels.Text = "Hat Models";
            // 
            // labelNewHatModels
            // 
            this.labelNewHatModels.AutoSize = true;
            this.labelNewHatModels.Location = new System.Drawing.Point(52, 36);
            this.labelNewHatModels.Name = "labelNewHatModels";
            this.labelNewHatModels.Size = new System.Drawing.Size(81, 13);
            this.labelNewHatModels.TabIndex = 2;
            this.labelNewHatModels.Text = "New Hat Model";
            // 
            // HatName
            // 
            this.HatName.Location = new System.Drawing.Point(55, 92);
            this.HatName.Name = "HatName";
            this.HatName.Size = new System.Drawing.Size(100, 20);
            this.HatName.TabIndex = 3;
            this.HatName.TextChanged += new System.EventHandler(this.HatName_TextChanged);
            // 
            // HatCategory
            // 
            this.HatCategory.Location = new System.Drawing.Point(55, 151);
            this.HatCategory.Name = "HatCategory";
            this.HatCategory.Size = new System.Drawing.Size(100, 20);
            this.HatCategory.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(224, 118);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Material";
            // 
            // btnAddHat
            // 
            this.btnAddHat.Location = new System.Drawing.Point(58, 371);
            this.btnAddHat.Name = "btnAddHat";
            this.btnAddHat.Size = new System.Drawing.Size(100, 26);
            this.btnAddHat.TabIndex = 7;
            this.btnAddHat.Text = "Add";
            this.btnAddHat.UseVisualStyleBackColor = true;
            this.btnAddHat.Click += new System.EventHandler(this.btnAddHat_Click);
            // 
            // btnBackHat
            // 
            this.btnBackHat.Location = new System.Drawing.Point(13, 13);
            this.btnBackHat.Name = "btnBackHat";
            this.btnBackHat.Size = new System.Drawing.Size(75, 23);
            this.btnBackHat.TabIndex = 8;
            this.btnBackHat.Text = "Go Back";
            this.btnBackHat.UseVisualStyleBackColor = true;
            this.btnBackHat.Click += new System.EventHandler(this.btnBackHat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hat Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "size";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2Hat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackHat);
            this.Controls.Add(this.btnAddHat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.HatCategory);
            this.Controls.Add(this.HatName);
            this.Controls.Add(this.labelNewHatModels);
            this.Controls.Add(this.LableCurrentHatModels);
            this.Controls.Add(this.dataGridViewHatModels);
            this.Name = "Form2Hat";
            this.Text = "Form2Hat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHatModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHatModels;
        private System.Windows.Forms.Label LableCurrentHatModels;
        private System.Windows.Forms.Label labelNewHatModels;
        private System.Windows.Forms.TextBox HatName;
        private System.Windows.Forms.TextBox HatCategory;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddHat;
        private System.Windows.Forms.Button btnBackHat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}