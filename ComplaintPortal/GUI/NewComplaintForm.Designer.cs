namespace ComplaintPortal.GUI
{
    partial class NewComplaintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewComplaintForm));
            this.cmb_Complaint = new System.Windows.Forms.ComboBox();
            this.txt_Complaint = new System.Windows.Forms.TextBox();
            this.PostCompBtn = new System.Windows.Forms.Button();
            this.loginlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Complaint
            // 
            this.cmb_Complaint.FormattingEnabled = true;
            this.cmb_Complaint.Items.AddRange(new object[] {
            "Modem Faliure",
            "Connection Reset",
            "Weak Connection"});
            this.cmb_Complaint.Location = new System.Drawing.Point(228, 110);
            this.cmb_Complaint.Name = "cmb_Complaint";
            this.cmb_Complaint.Size = new System.Drawing.Size(489, 28);
            this.cmb_Complaint.TabIndex = 0;
            this.cmb_Complaint.Text = "Complaint Type";
            // 
            // txt_Complaint
            // 
            this.txt_Complaint.Location = new System.Drawing.Point(228, 165);
            this.txt_Complaint.Multiline = true;
            this.txt_Complaint.Name = "txt_Complaint";
            this.txt_Complaint.PlaceholderText = "Please describe the issue you are facing...";
            this.txt_Complaint.Size = new System.Drawing.Size(489, 224);
            this.txt_Complaint.TabIndex = 1;
            this.txt_Complaint.Text = "Please describe the issue you are facing...";
            // 
            // PostCompBtn
            // 
            this.PostCompBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.PostCompBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PostCompBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PostCompBtn.Location = new System.Drawing.Point(228, 437);
            this.PostCompBtn.Margin = new System.Windows.Forms.Padding(10);
            this.PostCompBtn.Name = "PostCompBtn";
            this.PostCompBtn.Size = new System.Drawing.Size(197, 62);
            this.PostCompBtn.TabIndex = 3;
            this.PostCompBtn.Text = "Submit Complaint";
            this.PostCompBtn.UseVisualStyleBackColor = false;
            this.PostCompBtn.Click += new System.EventHandler(this.PostCompBtn_Click);
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.BackColor = System.Drawing.Color.Transparent;
            this.loginlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loginlabel.Location = new System.Drawing.Point(228, 35);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(280, 41);
            this.loginlabel.TabIndex = 11;
            this.loginlabel.Text = "Register Complaint";
            // 
            // NewComplaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.PostCompBtn);
            this.Controls.Add(this.txt_Complaint);
            this.Controls.Add(this.cmb_Complaint);
            this.Name = "NewComplaintForm";
            this.Text = "NewComplaintForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_Complaint;
        private TextBox txt_Complaint;
        private Button PostCompBtn;
        private Label loginlabel;
    }
}