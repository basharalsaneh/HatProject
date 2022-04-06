namespace HatProject1
{
    partial class Form8Material
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
            this.btnBackMaterial = new System.Windows.Forms.Button();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxAmmount = new System.Windows.Forms.TextBox();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.textBoxMNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackMaterial
            // 
            this.btnBackMaterial.Location = new System.Drawing.Point(13, 13);
            this.btnBackMaterial.Name = "btnBackMaterial";
            this.btnBackMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnBackMaterial.TabIndex = 0;
            this.btnBackMaterial.Text = "Go Back";
            this.btnBackMaterial.UseVisualStyleBackColor = true;
            this.btnBackMaterial.Click += new System.EventHandler(this.btnBackMaterial_Click);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(12, 202);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 1;
            this.textBoxCost.TextChanged += new System.EventHandler(this.textBoxCost_TextChanged);
            // 
            // textBoxAmmount
            // 
            this.textBoxAmmount.Location = new System.Drawing.Point(12, 241);
            this.textBoxAmmount.Name = "textBoxAmmount";
            this.textBoxAmmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmmount.TabIndex = 2;
            this.textBoxAmmount.TextChanged += new System.EventHandler(this.textBoxAmmount_TextChanged);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(12, 277);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnAddMaterial.TabIndex = 3;
            this.btnAddMaterial.Text = "Add";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // textBoxMNamn
            // 
            this.textBoxMNamn.Location = new System.Drawing.Point(12, 163);
            this.textBoxMNamn.Name = "textBoxMNamn";
            this.textBoxMNamn.Size = new System.Drawing.Size(100, 20);
            this.textBoxMNamn.TabIndex = 4;
            this.textBoxMNamn.TextChanged += new System.EventHandler(this.textBoxMNamn_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ammount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add New Material";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(337, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 249);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cost";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ammount";
            this.Column3.Name = "Column3";
            // 
            // Form8Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMNamn);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.textBoxAmmount);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.btnBackMaterial);
            this.Name = "Form8Material";
            this.Text = "Form8Material";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackMaterial;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxAmmount;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.TextBox textBoxMNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}