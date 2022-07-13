namespace ComplaintPortal.GUI
{
    partial class CustomerHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHomeForm));
            this.ViewComplaintBtn = new System.Windows.Forms.Button();
            this.RegisterComplaintBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewComplaintBtn
            // 
            this.ViewComplaintBtn.BackColor = System.Drawing.Color.White;
            this.ViewComplaintBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewComplaintBtn.ForeColor = System.Drawing.Color.Black;
            this.ViewComplaintBtn.Location = new System.Drawing.Point(160, 209);
            this.ViewComplaintBtn.Name = "ViewComplaintBtn";
            this.ViewComplaintBtn.Size = new System.Drawing.Size(228, 110);
            this.ViewComplaintBtn.TabIndex = 0;
            this.ViewComplaintBtn.Text = "View Current Complains";
            this.ViewComplaintBtn.UseVisualStyleBackColor = false;
            // 
            // RegisterComplaintBtn
            // 
            this.RegisterComplaintBtn.BackColor = System.Drawing.Color.White;
            this.RegisterComplaintBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterComplaintBtn.ForeColor = System.Drawing.Color.Black;
            this.RegisterComplaintBtn.Location = new System.Drawing.Point(519, 209);
            this.RegisterComplaintBtn.Name = "RegisterComplaintBtn";
            this.RegisterComplaintBtn.Size = new System.Drawing.Size(228, 110);
            this.RegisterComplaintBtn.TabIndex = 1;
            this.RegisterComplaintBtn.Text = "Register New Complaint";
            this.RegisterComplaintBtn.UseVisualStyleBackColor = false;
            // 
            // CustomerHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 518);
            this.Controls.Add(this.RegisterComplaintBtn);
            this.Controls.Add(this.ViewComplaintBtn);
            this.Name = "CustomerHomeForm";
            this.Text = "CustomerHomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ViewComplaintBtn;
        private Button RegisterComplaintBtn;
    }
}