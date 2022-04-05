namespace HatProject1.Orders
{
    partial class Form7CurrentOrders
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBackCurrentO = new System.Windows.Forms.Button();
            this.CurrentOrderColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOrderColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOrderColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOrderColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOrderColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOrderColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOrderColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrentOrderColumn1,
            this.CurrentOrderColumn2,
            this.CurrentOrderColumn3,
            this.CurrentOrderColumn4,
            this.CurrentOrderColumn5,
            this.CurrentOrderColumn6,
            this.CurrentOrderColumn7});
            this.dataGridView1.Location = new System.Drawing.Point(65, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBackCurrentO
            // 
            this.btnBackCurrentO.Location = new System.Drawing.Point(13, 13);
            this.btnBackCurrentO.Name = "btnBackCurrentO";
            this.btnBackCurrentO.Size = new System.Drawing.Size(75, 23);
            this.btnBackCurrentO.TabIndex = 1;
            this.btnBackCurrentO.Text = "Go Back";
            this.btnBackCurrentO.UseVisualStyleBackColor = true;
            this.btnBackCurrentO.Click += new System.EventHandler(this.btnBackCurrentO_Click);
            // 
            // CurrentOrderColumn1
            // 
            this.CurrentOrderColumn1.HeaderText = "OrderID";
            this.CurrentOrderColumn1.Name = "CurrentOrderColumn1";
            // 
            // CurrentOrderColumn2
            // 
            this.CurrentOrderColumn2.HeaderText = "Hat Name";
            this.CurrentOrderColumn2.Name = "CurrentOrderColumn2";
            // 
            // CurrentOrderColumn3
            // 
            this.CurrentOrderColumn3.HeaderText = "StartDate";
            this.CurrentOrderColumn3.Name = "CurrentOrderColumn3";
            // 
            // CurrentOrderColumn4
            // 
            this.CurrentOrderColumn4.HeaderText = "DeadLine";
            this.CurrentOrderColumn4.Name = "CurrentOrderColumn4";
            // 
            // CurrentOrderColumn5
            // 
            this.CurrentOrderColumn5.HeaderText = "Customer";
            this.CurrentOrderColumn5.Name = "CurrentOrderColumn5";
            // 
            // CurrentOrderColumn6
            // 
            this.CurrentOrderColumn6.HeaderText = "Active Personnel";
            this.CurrentOrderColumn6.Name = "CurrentOrderColumn6";
            // 
            // CurrentOrderColumn7
            // 
            this.CurrentOrderColumn7.HeaderText = "Material";
            this.CurrentOrderColumn7.Name = "CurrentOrderColumn7";
            // 
            // Form7CurrentOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackCurrentO);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7CurrentOrders";
            this.Text = "Form7CurrentOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBackCurrentO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentOrderColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentOrderColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentOrderColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentOrderColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentOrderColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentOrderColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentOrderColumn7;
    }
}