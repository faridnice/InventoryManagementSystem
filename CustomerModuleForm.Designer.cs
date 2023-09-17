namespace InventoryManagementSystem
{
    partial class CustomerModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerModuleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCld = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 54);
            this.panel1.TabIndex = 13;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(521, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 26);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 12;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Module";
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Location = new System.Drawing.Point(416, 218);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(88, 35);
            this.btnClearCustomer.TabIndex = 25;
            this.btnClearCustomer.Text = "Clear";
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(323, 218);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(88, 35);
            this.btnUpdateCustomer.TabIndex = 24;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveCustomer.Location = new System.Drawing.Point(230, 218);
            this.btnSaveCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(88, 35);
            this.btnSaveCustomer.TabIndex = 23;
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.UseVisualStyleBackColor = false;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(108, 163);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(371, 22);
            this.txtCusPhone.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone:";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(108, 110);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(371, 22);
            this.txtCusName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name:";
            // 
            // lblCld
            // 
            this.lblCld.AutoSize = true;
            this.lblCld.Location = new System.Drawing.Point(55, 227);
            this.lblCld.Name = "lblCld";
            this.lblCld.Size = new System.Drawing.Size(78, 16);
            this.lblCld.TabIndex = 26;
            this.lblCld.Text = "Customer Id";
            this.lblCld.Visible = false;
            // 
            // CustomerModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 281);
            this.Controls.Add(this.lblCld);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClearCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.txtCusPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnClearCustomer;
        public System.Windows.Forms.Button btnUpdateCustomer;
        public System.Windows.Forms.Button btnSaveCustomer;
        public System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCld;
    }
}