namespace ComplaintPortal
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.registerlabel = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.BackColor = System.Drawing.Color.Transparent;
            this.LoginLink.LinkColor = System.Drawing.Color.White;
            this.LoginLink.Location = new System.Drawing.Point(314, 583);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(96, 20);
            this.LoginLink.TabIndex = 7;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Back to login";
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.SignUpBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUpBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SignUpBtn.Location = new System.Drawing.Point(314, 510);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(10);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(127, 49);
            this.SignUpBtn.TabIndex = 6;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(314, 258);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(320, 27);
            this.txt_password.TabIndex = 5;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(314, 193);
            this.txt_username.Name = "txt_username";
            this.txt_username.PlaceholderText = "Username";
            this.txt_username.Size = new System.Drawing.Size(320, 27);
            this.txt_username.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Employee",
            "Customer"});
            this.comboBox1.Location = new System.Drawing.Point(314, 315);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Role";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // registerlabel
            // 
            this.registerlabel.AutoSize = true;
            this.registerlabel.BackColor = System.Drawing.Color.Transparent;
            this.registerlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerlabel.Location = new System.Drawing.Point(263, 63);
            this.registerlabel.Name = "registerlabel";
            this.registerlabel.Size = new System.Drawing.Size(454, 41);
            this.registerlabel.TabIndex = 9;
            this.registerlabel.Text = "Sign Up to our complaint portal";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(314, 369);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PlaceholderText = "Address";
            this.txt_Address.Size = new System.Drawing.Size(320, 102);
            this.txt_Address.TabIndex = 10;
            this.txt_Address.Visible = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.registerlabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel LoginLink;
        private Button SignUpBtn;
        private TextBox txt_password;
        private TextBox txt_username;
        private ComboBox comboBox1;
        private Label registerlabel;
        private TextBox txt_Address;
    }
}