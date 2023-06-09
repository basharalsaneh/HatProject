﻿namespace HatProject1
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
            this.LableCurrentHatModels = new System.Windows.Forms.Label();
            this.labelNewHatModels = new System.Windows.Forms.Label();
            this.HatName = new System.Windows.Forms.TextBox();
            this.HatSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddHat = new System.Windows.Forms.Button();
            this.btnBackHat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteHat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryText = new System.Windows.Forms.TextBox();
            this.btnToMaterial = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Savebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHatModels)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHatModels
            // 
            this.dataGridViewHatModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHatModels.Location = new System.Drawing.Point(334, 25);
            this.dataGridViewHatModels.Name = "dataGridViewHatModels";
            this.dataGridViewHatModels.RowHeadersWidth = 82;
            this.dataGridViewHatModels.Size = new System.Drawing.Size(430, 357);
            this.dataGridViewHatModels.TabIndex = 0;
            this.dataGridViewHatModels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHatModels_CellContentClick);
            this.dataGridViewHatModels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHatModels_CellContentClick);
            // 
            // LableCurrentHatModels
            // 
            this.LableCurrentHatModels.AutoSize = true;
            this.LableCurrentHatModels.Location = new System.Drawing.Point(331, 9);
            this.LableCurrentHatModels.Name = "LableCurrentHatModels";
            this.LableCurrentHatModels.Size = new System.Drawing.Size(61, 13);
            this.LableCurrentHatModels.TabIndex = 1;
            this.LableCurrentHatModels.Text = "Hat Models";
            // 
            // labelNewHatModels
            // 
            this.labelNewHatModels.AutoSize = true;
            this.labelNewHatModels.Location = new System.Drawing.Point(52, 62);
            this.labelNewHatModels.Name = "labelNewHatModels";
            this.labelNewHatModels.Size = new System.Drawing.Size(81, 13);
            this.labelNewHatModels.TabIndex = 2;
            this.labelNewHatModels.Text = "New Hat Model";
            // 
            // HatName
            // 
            this.HatName.Location = new System.Drawing.Point(55, 109);
            this.HatName.Name = "HatName";
            this.HatName.Size = new System.Drawing.Size(100, 20);
            this.HatName.TabIndex = 3;
            this.HatName.TextChanged += new System.EventHandler(this.HatName_TextChanged);
            // 
            // HatSize
            // 
            this.HatSize.Location = new System.Drawing.Point(55, 151);
            this.HatSize.Name = "HatSize";
            this.HatSize.Size = new System.Drawing.Size(100, 20);
            this.HatSize.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Material";
            // 
            // btnAddHat
            // 
            this.btnAddHat.Location = new System.Drawing.Point(54, 321);
            this.btnAddHat.Name = "btnAddHat";
            this.btnAddHat.Size = new System.Drawing.Size(146, 26);
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
            this.label1.Location = new System.Drawing.Point(52, 93);
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
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Size";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDeleteHat
            // 
            this.btnDeleteHat.Location = new System.Drawing.Point(128, 366);
            this.btnDeleteHat.Name = "btnDeleteHat";
            this.btnDeleteHat.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteHat.TabIndex = 11;
            this.btnDeleteHat.Text = "Delete";
            this.btnDeleteHat.UseVisualStyleBackColor = true;
            this.btnDeleteHat.Click += new System.EventHandler(this.btnDeleteHat_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(55, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // CategoryText
            // 
            this.CategoryText.Location = new System.Drawing.Point(55, 195);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(100, 20);
            this.CategoryText.TabIndex = 12;
            // 
            // btnToMaterial
            // 
            this.btnToMaterial.Location = new System.Drawing.Point(181, 13);
            this.btnToMaterial.Name = "btnToMaterial";
            this.btnToMaterial.Size = new System.Drawing.Size(98, 23);
            this.btnToMaterial.TabIndex = 13;
            this.btnToMaterial.Text = "Go to material";
            this.btnToMaterial.UseVisualStyleBackColor = true;
            this.btnToMaterial.Click += new System.EventHandler(this.btnToMaterial_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(54, 365);
            this.Savebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(68, 26);
            this.Savebutton.TabIndex = 15;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Form2Hat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 406);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnToMaterial);
            this.Controls.Add(this.CategoryText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteHat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackHat);
            this.Controls.Add(this.btnAddHat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HatSize);
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
        private System.Windows.Forms.TextBox HatSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddHat;
        private System.Windows.Forms.Button btnBackHat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteHat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CategoryText;
        private System.Windows.Forms.Button btnToMaterial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Savebutton;
    }
}