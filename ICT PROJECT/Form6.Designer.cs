
namespace ICT_PROJECT
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.lblbookid = new System.Windows.Forms.Label();
            this.lblbookname = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblquanti = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.tbbookid = new System.Windows.Forms.TextBox();
            this.tbbookname = new System.Windows.Forms.TextBox();
            this.tbquaint = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.button2btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btndashbord = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.dvgitems = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.cmbfilter = new System.Windows.Forms.ComboBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgitems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Management";
            // 
            // lblbookid
            // 
            this.lblbookid.AutoSize = true;
            this.lblbookid.Location = new System.Drawing.Point(41, 88);
            this.lblbookid.Name = "lblbookid";
            this.lblbookid.Size = new System.Drawing.Size(49, 13);
            this.lblbookid.TabIndex = 1;
            this.lblbookid.Text = "Book_ID";
            // 
            // lblbookname
            // 
            this.lblbookname.AutoSize = true;
            this.lblbookname.Location = new System.Drawing.Point(41, 127);
            this.lblbookname.Name = "lblbookname";
            this.lblbookname.Size = new System.Drawing.Size(66, 13);
            this.lblbookname.TabIndex = 2;
            this.lblbookname.Text = "Book_Name";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(41, 165);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(49, 13);
            this.lblcategory.TabIndex = 3;
            this.lblcategory.Text = "Category";
            // 
            // lblquanti
            // 
            this.lblquanti.AutoSize = true;
            this.lblquanti.Location = new System.Drawing.Point(41, 200);
            this.lblquanti.Name = "lblquanti";
            this.lblquanti.Size = new System.Drawing.Size(46, 13);
            this.lblquanti.TabIndex = 4;
            this.lblquanti.Text = "Quantity";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(41, 241);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(31, 13);
            this.lblprice.TabIndex = 5;
            this.lblprice.Text = "Price";
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Items.AddRange(new object[] {
            "Past Papers",
            "Model Papers",
            "Theory"});
            this.cmbcategory.Location = new System.Drawing.Point(123, 165);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(121, 21);
            this.cmbcategory.TabIndex = 6;
            this.cmbcategory.Text = "Select";
            this.cmbcategory.SelectedIndexChanged += new System.EventHandler(this.cmbcategory_SelectedIndexChanged);
            // 
            // tbbookid
            // 
            this.tbbookid.Location = new System.Drawing.Point(123, 81);
            this.tbbookid.Name = "tbbookid";
            this.tbbookid.Size = new System.Drawing.Size(100, 20);
            this.tbbookid.TabIndex = 7;
            // 
            // tbbookname
            // 
            this.tbbookname.Location = new System.Drawing.Point(123, 120);
            this.tbbookname.Name = "tbbookname";
            this.tbbookname.Size = new System.Drawing.Size(100, 20);
            this.tbbookname.TabIndex = 8;
            // 
            // tbquaint
            // 
            this.tbquaint.Location = new System.Drawing.Point(123, 200);
            this.tbquaint.Name = "tbquaint";
            this.tbquaint.Size = new System.Drawing.Size(100, 20);
            this.tbquaint.TabIndex = 9;
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(123, 234);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(100, 20);
            this.tbprice.TabIndex = 10;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(13, 347);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // button2btnupdate
            // 
            this.button2btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2btnupdate.Location = new System.Drawing.Point(110, 347);
            this.button2btnupdate.Name = "button2btnupdate";
            this.button2btnupdate.Size = new System.Drawing.Size(75, 23);
            this.button2btnupdate.TabIndex = 12;
            this.button2btnupdate.Text = "Update";
            this.button2btnupdate.UseVisualStyleBackColor = true;
            this.button2btnupdate.Click += new System.EventHandler(this.button2btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(203, 347);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btndashbord
            // 
            this.btndashbord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashbord.Location = new System.Drawing.Point(467, 356);
            this.btndashbord.Name = "btndashbord";
            this.btndashbord.Size = new System.Drawing.Size(102, 40);
            this.btndashbord.TabIndex = 14;
            this.btndashbord.Text = "Dashboard";
            this.btndashbord.UseVisualStyleBackColor = true;
            this.btndashbord.Click += new System.EventHandler(this.btndashbord_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(658, 356);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(97, 40);
            this.btnlogout.TabIndex = 15;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // dvgitems
            // 
            this.dvgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgitems.Location = new System.Drawing.Point(291, 53);
            this.dvgitems.Name = "dvgitems";
            this.dvgitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgitems.Size = new System.Drawing.Size(497, 259);
            this.dvgitems.TabIndex = 16;
            this.dvgitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgitems_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Item List";
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(110, 283);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // cmbfilter
            // 
            this.cmbfilter.FormattingEnabled = true;
            this.cmbfilter.Items.AddRange(new object[] {
            "Past Papers",
            "Model Papers",
            "Theory"});
            this.cmbfilter.Location = new System.Drawing.Point(419, 15);
            this.cmbfilter.Name = "cmbfilter";
            this.cmbfilter.Size = new System.Drawing.Size(121, 21);
            this.cmbfilter.TabIndex = 19;
            this.cmbfilter.Text = "Filter";
            this.cmbfilter.SelectedIndexChanged += new System.EventHandler(this.cmbfilter_SelectedIndexChanged);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(584, 9);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(93, 29);
            this.btnrefresh.TabIndex = 20;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 408);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.cmbfilter);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgitems);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btndashbord);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.button2btnupdate);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.tbquaint);
            this.Controls.Add(this.tbbookname);
            this.Controls.Add(this.tbbookid);
            this.Controls.Add(this.cmbcategory);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblquanti);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lblbookname);
            this.Controls.Add(this.lblbookid);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Item management";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgitems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbookid;
        private System.Windows.Forms.Label lblbookname;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblquanti;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.TextBox tbbookid;
        private System.Windows.Forms.TextBox tbbookname;
        private System.Windows.Forms.TextBox tbquaint;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button button2btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btndashbord;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.DataGridView dvgitems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ComboBox cmbfilter;
        private System.Windows.Forms.Button btnrefresh;
    }
}