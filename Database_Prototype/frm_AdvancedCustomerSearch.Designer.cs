namespace Database_Prototype
{
    partial class frm_AdvancedCustomerSearch
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SearchPhoneNumber = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_CustomerId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_SeachCustomerID = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SearchName = new System.Windows.Forms.Button();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 262);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced Customer Search";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_PhoneNumber);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btn_SearchPhoneNumber);
            this.groupBox4.Location = new System.Drawing.Point(10, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 54);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search By Phone Number";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(93, 19);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(137, 20);
            this.txt_PhoneNumber.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phone Number:";
            // 
            // btn_SearchPhoneNumber
            // 
            this.btn_SearchPhoneNumber.Location = new System.Drawing.Point(236, 17);
            this.btn_SearchPhoneNumber.Name = "btn_SearchPhoneNumber";
            this.btn_SearchPhoneNumber.Size = new System.Drawing.Size(59, 23);
            this.btn_SearchPhoneNumber.TabIndex = 24;
            this.btn_SearchPhoneNumber.Text = "Search";
            this.btn_SearchPhoneNumber.UseVisualStyleBackColor = true;
            this.btn_SearchPhoneNumber.Click += new System.EventHandler(this.btn_SearchPhoneNumber_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_CustomerId);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btn_SeachCustomerID);
            this.groupBox3.Location = new System.Drawing.Point(10, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 54);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search By Customer ID";
            // 
            // txt_CustomerId
            // 
            this.txt_CustomerId.Location = new System.Drawing.Point(80, 19);
            this.txt_CustomerId.Name = "txt_CustomerId";
            this.txt_CustomerId.Size = new System.Drawing.Size(150, 20);
            this.txt_CustomerId.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Customer ID:";
            // 
            // btn_SeachCustomerID
            // 
            this.btn_SeachCustomerID.Location = new System.Drawing.Point(236, 17);
            this.btn_SeachCustomerID.Name = "btn_SeachCustomerID";
            this.btn_SeachCustomerID.Size = new System.Drawing.Size(59, 23);
            this.btn_SeachCustomerID.TabIndex = 24;
            this.btn_SeachCustomerID.Text = "Search";
            this.btn_SeachCustomerID.UseVisualStyleBackColor = true;
            this.btn_SeachCustomerID.Click += new System.EventHandler(this.btn_SeachCustomerID_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SearchName);
            this.groupBox1.Controls.Add(this.txt_FirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Location = new System.Drawing.Point(10, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 108);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By First and Last Name";
            // 
            // btn_SearchName
            // 
            this.btn_SearchName.Location = new System.Drawing.Point(41, 71);
            this.btn_SearchName.Name = "btn_SearchName";
            this.btn_SearchName.Size = new System.Drawing.Size(221, 23);
            this.btn_SearchName.TabIndex = 26;
            this.btn_SearchName.Text = "Search";
            this.btn_SearchName.UseVisualStyleBackColor = true;
            this.btn_SearchName.Click += new System.EventHandler(this.btn_SearchName_Click);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(123, 19);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(139, 20);
            this.txt_FirstName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Last Name:";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(123, 45);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(139, 20);
            this.txt_LastName.TabIndex = 27;
            // 
            // frm_AdvancedCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 288);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_AdvancedCustomerSearch";
            this.Text = "Advanced Customer Search";
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SearchPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_CustomerId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_SeachCustomerID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SearchName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LastName;
    }
}