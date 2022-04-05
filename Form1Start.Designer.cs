namespace HatProject1
{
    partial class Form1Start
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
            this.btnHatModels = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnHatProjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHatModels
            // 
            this.btnHatModels.Location = new System.Drawing.Point(90, 146);
            this.btnHatModels.Name = "btnHatModels";
            this.btnHatModels.Size = new System.Drawing.Size(75, 23);
            this.btnHatModels.TabIndex = 0;
            this.btnHatModels.Text = "Hat models";
            this.btnHatModels.UseVisualStyleBackColor = true;
            this.btnHatModels.Click += new System.EventHandler(this.btnHatModels_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(252, 145);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnHatProjects
            // 
            this.btnHatProjects.Location = new System.Drawing.Point(416, 145);
            this.btnHatProjects.Name = "btnHatProjects";
            this.btnHatProjects.Size = new System.Drawing.Size(75, 23);
            this.btnHatProjects.TabIndex = 2;
            this.btnHatProjects.Text = "Hat Projects";
            this.btnHatProjects.UseVisualStyleBackColor = true;
            this.btnHatProjects.Click += new System.EventHandler(this.btnHatProjects_Click);
            // 
            // Form1Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHatProjects);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnHatModels);
            this.Name = "Form1Start";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHatModels;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnHatProjects;
    }
}

