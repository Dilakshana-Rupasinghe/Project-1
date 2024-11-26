
namespace ICT_PROJECT
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.lblcategoryno = new System.Windows.Forms.Label();
            this.lblcategoryname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcategoryno = new System.Windows.Forms.TextBox();
            this.tbcategoryname = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btndashbord = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.dgvcategor = new System.Windows.Forms.DataGridView();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcategoryno
            // 
            this.lblcategoryno.AutoSize = true;
            this.lblcategoryno.Location = new System.Drawing.Point(53, 115);
            this.lblcategoryno.Name = "lblcategoryno";
            this.lblcategoryno.Size = new System.Drawing.Size(92, 13);
            this.lblcategoryno.TabIndex = 0;
            this.lblcategoryno.Text = "Category_Number";
            // 
            // lblcategoryname
            // 
            this.lblcategoryname.AutoSize = true;
            this.lblcategoryname.Location = new System.Drawing.Point(53, 163);
            this.lblcategoryname.Name = "lblcategoryname";
            this.lblcategoryname.Size = new System.Drawing.Size(83, 13);
            this.lblcategoryname.TabIndex = 1;
            this.lblcategoryname.Text = "Category_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category Management";
            // 
            // tbcategoryno
            // 
            this.tbcategoryno.Location = new System.Drawing.Point(161, 108);
            this.tbcategoryno.Name = "tbcategoryno";
            this.tbcategoryno.Size = new System.Drawing.Size(100, 20);
            this.tbcategoryno.TabIndex = 3;
            // 
            // tbcategoryname
            // 
            this.tbcategoryname.Location = new System.Drawing.Point(161, 156);
            this.tbcategoryname.Name = "tbcategoryname";
            this.tbcategoryname.Size = new System.Drawing.Size(100, 20);
            this.tbcategoryname.TabIndex = 4;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(33, 294);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 5;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(138, 294);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(258, 294);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btndashbord
            // 
            this.btndashbord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashbord.Location = new System.Drawing.Point(418, 343);
            this.btndashbord.Name = "btndashbord";
            this.btndashbord.Size = new System.Drawing.Size(99, 34);
            this.btndashbord.TabIndex = 8;
            this.btndashbord.Text = "Dashboard";
            this.btndashbord.UseVisualStyleBackColor = true;
            this.btndashbord.Click += new System.EventHandler(this.btndashbord_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(626, 343);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(88, 34);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // dgvcategor
            // 
            this.dgvcategor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategor.Location = new System.Drawing.Point(386, 54);
            this.dgvcategor.Name = "dgvcategor";
            this.dgvcategor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcategor.Size = new System.Drawing.Size(362, 207);
            this.dgvcategor.TabIndex = 10;
            this.dgvcategor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcategor_CellContentClick);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(161, 213);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 408);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.dgvcategor);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btndashbord);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.tbcategoryname);
            this.Controls.Add(this.tbcategoryno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcategoryname);
            this.Controls.Add(this.lblcategoryno);
            this.Name = "Form5";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcategoryno;
        private System.Windows.Forms.Label lblcategoryname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbcategoryno;
        private System.Windows.Forms.TextBox tbcategoryname;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btndashbord;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.DataGridView dgvcategor;
        private System.Windows.Forms.Button btnclear;
    }
}