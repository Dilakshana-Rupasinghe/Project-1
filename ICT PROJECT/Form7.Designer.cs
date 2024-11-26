
namespace ICT_PROJECT
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.tbqun = new System.Windows.Forms.TextBox();
            this.tbpri = new System.Windows.Forms.TextBox();
            this.tbclintnm = new System.Windows.Forms.TextBox();
            this.tbbooknm = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvbl = new System.Windows.Forms.DataGridView();
            this.dvgitems = new System.Windows.Forms.DataGridView();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnaddbil = new System.Windows.Forms.Button();
            this.lblclintename = new System.Windows.Forms.Label();
            this.lblpric = new System.Windows.Forms.Label();
            this.lblquntity = new System.Windows.Forms.Label();
            this.lblbookname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnprint = new System.Windows.Forms.Button();
            this.btndashbord = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgitems)).BeginInit();
            this.SuspendLayout();
            // 
            // tbqun
            // 
            this.tbqun.Location = new System.Drawing.Point(119, 108);
            this.tbqun.Name = "tbqun";
            this.tbqun.Size = new System.Drawing.Size(100, 20);
            this.tbqun.TabIndex = 29;
            // 
            // tbpri
            // 
            this.tbpri.Enabled = false;
            this.tbpri.Location = new System.Drawing.Point(119, 137);
            this.tbpri.Name = "tbpri";
            this.tbpri.Size = new System.Drawing.Size(100, 20);
            this.tbpri.TabIndex = 28;
            // 
            // tbclintnm
            // 
            this.tbclintnm.Location = new System.Drawing.Point(119, 166);
            this.tbclintnm.Name = "tbclintnm";
            this.tbclintnm.Size = new System.Drawing.Size(100, 20);
            this.tbclintnm.TabIndex = 27;
            // 
            // tbbooknm
            // 
            this.tbbooknm.Enabled = false;
            this.tbbooknm.Location = new System.Drawing.Point(119, 78);
            this.tbbooknm.Name = "tbbooknm";
            this.tbbooknm.Size = new System.Drawing.Size(100, 20);
            this.tbbooknm.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(501, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Bill List";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "List of Books";
            // 
            // dgvbl
            // 
            this.dgvbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            this.dgvbl.Location = new System.Drawing.Point(280, 221);
            this.dgvbl.Name = "dgvbl";
            this.dgvbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbl.Size = new System.Drawing.Size(508, 139);
            this.dgvbl.TabIndex = 23;
            // 
            // dvgitems
            // 
            this.dvgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgitems.Location = new System.Drawing.Point(280, 36);
            this.dvgitems.Name = "dvgitems";
            this.dvgitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgitems.Size = new System.Drawing.Size(508, 144);
            this.dvgitems.TabIndex = 22;
            this.dvgitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgitems_CellContentClick);
            // 
            // btnclean
            // 
            this.btnclean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclean.Location = new System.Drawing.Point(164, 221);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(75, 23);
            this.btnclean.TabIndex = 21;
            this.btnclean.Text = "Clear";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // btnaddbil
            // 
            this.btnaddbil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbil.Location = new System.Drawing.Point(42, 221);
            this.btnaddbil.Name = "btnaddbil";
            this.btnaddbil.Size = new System.Drawing.Size(75, 23);
            this.btnaddbil.TabIndex = 20;
            this.btnaddbil.Text = "Add to Bill";
            this.btnaddbil.UseVisualStyleBackColor = true;
            this.btnaddbil.Click += new System.EventHandler(this.btnaddbil_Click);
            // 
            // lblclintename
            // 
            this.lblclintename.AutoSize = true;
            this.lblclintename.Location = new System.Drawing.Point(39, 169);
            this.lblclintename.Name = "lblclintename";
            this.lblclintename.Size = new System.Drawing.Size(64, 13);
            this.lblclintename.TabIndex = 19;
            this.lblclintename.Text = "Clinte Name";
            // 
            // lblpric
            // 
            this.lblpric.AutoSize = true;
            this.lblpric.Location = new System.Drawing.Point(39, 140);
            this.lblpric.Name = "lblpric";
            this.lblpric.Size = new System.Drawing.Size(31, 13);
            this.lblpric.TabIndex = 18;
            this.lblpric.Text = "Price";
            // 
            // lblquntity
            // 
            this.lblquntity.AutoSize = true;
            this.lblquntity.Location = new System.Drawing.Point(39, 111);
            this.lblquntity.Name = "lblquntity";
            this.lblquntity.Size = new System.Drawing.Size(40, 13);
            this.lblquntity.TabIndex = 17;
            this.lblquntity.Text = "Quntity";
            // 
            // lblbookname
            // 
            this.lblbookname.AutoSize = true;
            this.lblbookname.Location = new System.Drawing.Point(39, 80);
            this.lblbookname.Name = "lblbookname";
            this.lblbookname.Size = new System.Drawing.Size(63, 13);
            this.lblbookname.TabIndex = 16;
            this.lblbookname.Text = "Book Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bill Creation";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(110, 273);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(59, 16);
            this.lbltotal.TabIndex = 30;
            this.lbltotal.Text = "Amount";
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(634, 370);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(87, 39);
            this.btnlogout.TabIndex = 32;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.OriginAtMargins = true;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(98, 309);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(87, 37);
            this.btnprint.TabIndex = 31;
            this.btnprint.Text = "Peint Bill";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btndashbord
            // 
            this.btndashbord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashbord.Location = new System.Drawing.Point(456, 375);
            this.btndashbord.Name = "btndashbord";
            this.btndashbord.Size = new System.Drawing.Size(84, 29);
            this.btndashbord.TabIndex = 33;
            this.btndashbord.Text = "Dashboard";
            this.btndashbord.UseVisualStyleBackColor = true;
            this.btndashbord.Click += new System.EventHandler(this.btndashbord_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Book ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book name";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quntity";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 408);
            this.Controls.Add(this.btndashbord);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.tbqun);
            this.Controls.Add(this.tbpri);
            this.Controls.Add(this.tbclintnm);
            this.Controls.Add(this.tbbooknm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvbl);
            this.Controls.Add(this.dvgitems);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnaddbil);
            this.Controls.Add(this.lblclintename);
            this.Controls.Add(this.lblpric);
            this.Controls.Add(this.lblquntity);
            this.Controls.Add(this.lblbookname);
            this.Controls.Add(this.label6);
            this.Name = "Form7";
            this.Text = "Bill creation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgitems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbqun;
        private System.Windows.Forms.TextBox tbpri;
        private System.Windows.Forms.TextBox tbclintnm;
        private System.Windows.Forms.TextBox tbbooknm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvbl;
        private System.Windows.Forms.DataGridView dvgitems;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnaddbil;
        private System.Windows.Forms.Label lblclintename;
        private System.Windows.Forms.Label lblpric;
        private System.Windows.Forms.Label lblquntity;
        private System.Windows.Forms.Label lblbookname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnlogout;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btndashbord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}