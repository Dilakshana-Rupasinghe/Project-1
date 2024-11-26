
namespace ICT_PROJECT
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.btnbill = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbill
            // 
            this.btnbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbill.Image = ((System.Drawing.Image)(resources.GetObject("btnbill.Image")));
            this.btnbill.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnbill.Location = new System.Drawing.Point(285, 43);
            this.btnbill.Name = "btnbill";
            this.btnbill.Size = new System.Drawing.Size(201, 209);
            this.btnbill.TabIndex = 0;
            this.btnbill.Text = "Bill Creation";
            this.btnbill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbill.UseVisualStyleBackColor = true;
            this.btnbill.Click += new System.EventHandler(this.btnbill_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(348, 305);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(113, 50);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(665, 342);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(83, 37);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 408);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnbill);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cashir Dashbord";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbill;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnback;
    }
}