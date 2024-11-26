
namespace ICT_PROJECT
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblSRuid = new System.Windows.Forms.Label();
            this.lblSRnic = new System.Windows.Forms.Label();
            this.lblSRcn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSRuid = new System.Windows.Forms.TextBox();
            this.tbSRNICNO = new System.Windows.Forms.TextBox();
            this.tbSRContactno = new System.Windows.Forms.TextBox();
            this.lblSRusername = new System.Windows.Forms.Label();
            this.tbSRUsername = new System.Windows.Forms.TextBox();
            this.tbSRPassword = new System.Windows.Forms.TextBox();
            this.lblSRpassword = new System.Windows.Forms.Label();
            this.btnSRSubmit = new System.Windows.Forms.Button();
            this.btnSRReset = new System.Windows.Forms.Button();
            this.btnSRDashbord = new System.Windows.Forms.Button();
            this.dgvstaff = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Addtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSRuid
            // 
            this.lblSRuid.AutoSize = true;
            this.lblSRuid.Location = new System.Drawing.Point(28, 80);
            this.lblSRuid.Name = "lblSRuid";
            this.lblSRuid.Size = new System.Drawing.Size(43, 13);
            this.lblSRuid.TabIndex = 0;
            this.lblSRuid.Text = "User ID";
            this.lblSRuid.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSRnic
            // 
            this.lblSRnic.AutoSize = true;
            this.lblSRnic.Location = new System.Drawing.Point(28, 118);
            this.lblSRnic.Name = "lblSRnic";
            this.lblSRnic.Size = new System.Drawing.Size(65, 13);
            this.lblSRnic.TabIndex = 2;
            this.lblSRnic.Text = "NIC Number";
            // 
            // lblSRcn
            // 
            this.lblSRcn.AutoSize = true;
            this.lblSRcn.Location = new System.Drawing.Point(28, 151);
            this.lblSRcn.Name = "lblSRcn";
            this.lblSRcn.Size = new System.Drawing.Size(84, 13);
            this.lblSRcn.TabIndex = 3;
            this.lblSRcn.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Staff Registation Form";
            // 
            // tbSRuid
            // 
            this.tbSRuid.Location = new System.Drawing.Point(171, 73);
            this.tbSRuid.Name = "tbSRuid";
            this.tbSRuid.Size = new System.Drawing.Size(228, 20);
            this.tbSRuid.TabIndex = 5;
            // 
            // tbSRNICNO
            // 
            this.tbSRNICNO.Location = new System.Drawing.Point(171, 111);
            this.tbSRNICNO.Name = "tbSRNICNO";
            this.tbSRNICNO.Size = new System.Drawing.Size(228, 20);
            this.tbSRNICNO.TabIndex = 7;
            // 
            // tbSRContactno
            // 
            this.tbSRContactno.Location = new System.Drawing.Point(171, 144);
            this.tbSRContactno.Name = "tbSRContactno";
            this.tbSRContactno.Size = new System.Drawing.Size(228, 20);
            this.tbSRContactno.TabIndex = 8;
            // 
            // lblSRusername
            // 
            this.lblSRusername.AutoSize = true;
            this.lblSRusername.Location = new System.Drawing.Point(27, 193);
            this.lblSRusername.Name = "lblSRusername";
            this.lblSRusername.Size = new System.Drawing.Size(60, 13);
            this.lblSRusername.TabIndex = 9;
            this.lblSRusername.Text = "User Name";
            // 
            // tbSRUsername
            // 
            this.tbSRUsername.Location = new System.Drawing.Point(171, 186);
            this.tbSRUsername.Name = "tbSRUsername";
            this.tbSRUsername.Size = new System.Drawing.Size(228, 20);
            this.tbSRUsername.TabIndex = 10;
            // 
            // tbSRPassword
            // 
            this.tbSRPassword.Location = new System.Drawing.Point(171, 222);
            this.tbSRPassword.Name = "tbSRPassword";
            this.tbSRPassword.Size = new System.Drawing.Size(228, 20);
            this.tbSRPassword.TabIndex = 11;
            // 
            // lblSRpassword
            // 
            this.lblSRpassword.AutoSize = true;
            this.lblSRpassword.Location = new System.Drawing.Point(28, 229);
            this.lblSRpassword.Name = "lblSRpassword";
            this.lblSRpassword.Size = new System.Drawing.Size(53, 13);
            this.lblSRpassword.TabIndex = 12;
            this.lblSRpassword.Text = "Password";
            // 
            // btnSRSubmit
            // 
            this.btnSRSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRSubmit.Location = new System.Drawing.Point(31, 337);
            this.btnSRSubmit.Name = "btnSRSubmit";
            this.btnSRSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSRSubmit.TabIndex = 13;
            this.btnSRSubmit.Text = "Submit";
            this.btnSRSubmit.UseVisualStyleBackColor = true;
            this.btnSRSubmit.Click += new System.EventHandler(this.btnSRSubmit_Click);
            // 
            // btnSRReset
            // 
            this.btnSRReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRReset.Location = new System.Drawing.Point(324, 337);
            this.btnSRReset.Name = "btnSRReset";
            this.btnSRReset.Size = new System.Drawing.Size(75, 23);
            this.btnSRReset.TabIndex = 14;
            this.btnSRReset.Text = "Reset";
            this.btnSRReset.UseVisualStyleBackColor = true;
            // 
            // btnSRDashbord
            // 
            this.btnSRDashbord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRDashbord.Location = new System.Drawing.Point(542, 328);
            this.btnSRDashbord.Name = "btnSRDashbord";
            this.btnSRDashbord.Size = new System.Drawing.Size(95, 39);
            this.btnSRDashbord.TabIndex = 15;
            this.btnSRDashbord.Text = "Dashboard";
            this.btnSRDashbord.UseVisualStyleBackColor = true;
            this.btnSRDashbord.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvstaff
            // 
            this.dgvstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstaff.Location = new System.Drawing.Point(419, 51);
            this.dgvstaff.Name = "dgvstaff";
            this.dgvstaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstaff.Size = new System.Drawing.Size(434, 211);
            this.dgvstaff.TabIndex = 16;
            this.dgvstaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstaff_CellContentClick);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(127, 337);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(223, 337);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(659, 328);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(96, 39);
            this.btnlogout.TabIndex = 19;
            this.btnlogout.Text = "Log_Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(171, 308);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Address";
            // 
            // Addtb
            // 
            this.Addtb.Location = new System.Drawing.Point(171, 263);
            this.Addtb.Name = "Addtb";
            this.Addtb.Size = new System.Drawing.Size(228, 20);
            this.Addtb.TabIndex = 22;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 408);
            this.Controls.Add(this.Addtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dgvstaff);
            this.Controls.Add(this.btnSRDashbord);
            this.Controls.Add(this.btnSRReset);
            this.Controls.Add(this.btnSRSubmit);
            this.Controls.Add(this.lblSRpassword);
            this.Controls.Add(this.tbSRPassword);
            this.Controls.Add(this.tbSRUsername);
            this.Controls.Add(this.lblSRusername);
            this.Controls.Add(this.tbSRContactno);
            this.Controls.Add(this.tbSRNICNO);
            this.Controls.Add(this.tbSRuid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSRcn);
            this.Controls.Add(this.lblSRnic);
            this.Controls.Add(this.lblSRuid);
            this.Name = "Form3";
            this.Text = "Staff Rgistation";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSRuid;
        private System.Windows.Forms.Label lblSRnic;
        private System.Windows.Forms.Label lblSRcn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSRuid;
        private System.Windows.Forms.TextBox tbSRNICNO;
        private System.Windows.Forms.TextBox tbSRContactno;
        private System.Windows.Forms.Label lblSRusername;
        private System.Windows.Forms.TextBox tbSRUsername;
        private System.Windows.Forms.TextBox tbSRPassword;
        private System.Windows.Forms.Label lblSRpassword;
        private System.Windows.Forms.Button btnSRSubmit;
        private System.Windows.Forms.Button btnSRReset;
        private System.Windows.Forms.Button btnSRDashbord;
        private System.Windows.Forms.DataGridView dgvstaff;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Addtb;
    }
}