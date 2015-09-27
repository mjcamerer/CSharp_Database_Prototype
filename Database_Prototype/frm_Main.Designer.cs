namespace Database_Prototype
{
    partial class frm_Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AdvancedCustomerId = new System.Windows.Forms.Button();
            this.btn_SearchCustomerId = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_CustomerId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SearchOrderId = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_OrderId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AdvancedCustomerId);
            this.groupBox1.Controls.Add(this.btn_SearchCustomerId);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_CustomerId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Customer";
            // 
            // btn_AdvancedCustomerId
            // 
            this.btn_AdvancedCustomerId.Location = new System.Drawing.Point(327, 17);
            this.btn_AdvancedCustomerId.Name = "btn_AdvancedCustomerId";
            this.btn_AdvancedCustomerId.Size = new System.Drawing.Size(75, 23);
            this.btn_AdvancedCustomerId.TabIndex = 26;
            this.btn_AdvancedCustomerId.Text = "Advanced";
            this.btn_AdvancedCustomerId.UseVisualStyleBackColor = true;
            this.btn_AdvancedCustomerId.Click += new System.EventHandler(this.btn_AdvancedCustomerId_Click);
            // 
            // btn_SearchCustomerId
            // 
            this.btn_SearchCustomerId.Location = new System.Drawing.Point(246, 17);
            this.btn_SearchCustomerId.Name = "btn_SearchCustomerId";
            this.btn_SearchCustomerId.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchCustomerId.TabIndex = 25;
            this.btn_SearchCustomerId.Text = "Search";
            this.btn_SearchCustomerId.UseVisualStyleBackColor = true;
            this.btn_SearchCustomerId.Click += new System.EventHandler(this.btn_SearchCustomerId_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Customer ID:";
            // 
            // txt_CustomerId
            // 
            this.txt_CustomerId.Location = new System.Drawing.Point(89, 19);
            this.txt_CustomerId.Name = "txt_CustomerId";
            this.txt_CustomerId.Size = new System.Drawing.Size(151, 20);
            this.txt_CustomerId.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SearchOrderId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_OrderId);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 51);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Order";
            // 
            // btn_SearchOrderId
            // 
            this.btn_SearchOrderId.Location = new System.Drawing.Point(246, 17);
            this.btn_SearchOrderId.Name = "btn_SearchOrderId";
            this.btn_SearchOrderId.Size = new System.Drawing.Size(156, 23);
            this.btn_SearchOrderId.TabIndex = 25;
            this.btn_SearchOrderId.Text = "Search";
            this.btn_SearchOrderId.UseVisualStyleBackColor = true;
            this.btn_SearchOrderId.Click += new System.EventHandler(this.btn_SearchOrderId_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Order ID:";
            // 
            // txt_OrderId
            // 
            this.txt_OrderId.Location = new System.Drawing.Point(89, 19);
            this.txt_OrderId.Name = "txt_OrderId";
            this.txt_OrderId.Size = new System.Drawing.Size(151, 20);
            this.txt_OrderId.TabIndex = 26;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 138);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Main";
            this.Text = "Garden Company Database Search";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AdvancedCustomerId;
        private System.Windows.Forms.Button btn_SearchCustomerId;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_CustomerId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_SearchOrderId;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_OrderId;
    }
}