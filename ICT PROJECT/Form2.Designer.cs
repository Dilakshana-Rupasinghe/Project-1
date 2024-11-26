
namespace ICT_PROJECT
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnStaffregistatio = new System.Windows.Forms.Button();
            this.btnItemmanagement = new System.Windows.Forms.Button();
            this.btnCategorys = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStaffregistatio
            // 
            this.btnStaffregistatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffregistatio.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffregistatio.Image")));
            this.btnStaffregistatio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffregistatio.Location = new System.Drawing.Point(109, 12);
            this.btnStaffregistatio.Name = "btnStaffregistatio";
            this.btnStaffregistatio.Size = new System.Drawing.Size(227, 178);
            this.btnStaffregistatio.TabIndex = 0;
            this.btnStaffregistatio.Text = "Staff \r\nRegistation";
            this.btnStaffregistatio.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStaffregistatio.UseVisualStyleBackColor = true;
            this.btnStaffregistatio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnItemmanagement
            // 
            this.btnItemmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemmanagement.Image = ((System.Drawing.Image)(resources.GetObject("btnItemmanagement.Image")));
            this.btnItemmanagement.Location = new System.Drawing.Point(441, 12);
            this.btnItemmanagement.Name = "btnItemmanagement";
            this.btnItemmanagement.Size = new System.Drawing.Size(230, 178);
            this.btnItemmanagement.TabIndex = 2;
            this.btnItemmanagement.Text = "Item Management";
            this.btnItemmanagement.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnItemmanagement.UseVisualStyleBackColor = true;
            this.btnItemmanagement.Click += new System.EventHandler(this.btnItemmanagement_Click);
            // 
            // btnCategorys
            // 
            this.btnCategorys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorys.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorys.Image")));
            this.btnCategorys.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategorys.Location = new System.Drawing.Point(109, 215);
            this.btnCategorys.Name = "btnCategorys";
            this.btnCategorys.Size = new System.Drawing.Size(227, 181);
            this.btnCategorys.TabIndex = 4;
            this.btnCategorys.Text = "Categorys";
            this.btnCategorys.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCategorys.UseVisualStyleBackColor = true;
            this.btnCategorys.Click += new System.EventHandler(this.btnCategorys_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(495, 264);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 51);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(640, 351);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(87, 30);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 408);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCategorys);
            this.Controls.Add(this.btnItemmanagement);
            this.Controls.Add(this.btnStaffregistatio);
            this.MinimumSize = new System.Drawing.Size(451, 362);
            this.Name = "Form2";
            this.Text = "Addmin Dashbord";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStaffregistatio;
        private System.Windows.Forms.Button btnItemmanagement;
        private System.Windows.Forms.Button btnCategorys;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnback;
    }
}