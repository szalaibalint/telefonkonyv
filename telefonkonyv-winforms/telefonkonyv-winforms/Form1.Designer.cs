namespace telefonkonyv_winforms
{
    partial class Form1
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblModify = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblAddTexts = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtDel = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtModify = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(480, 254);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(255, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "*************WELCOME TO PHONEBOOK*************";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(582, 297);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(39, 13);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "MENU";
            // 
            // lblAddNew
            // 
            this.lblAddNew.AutoSize = true;
            this.lblAddNew.Location = new System.Drawing.Point(451, 348);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(60, 13);
            this.lblAddNew.TabIndex = 2;
            this.lblAddNew.Text = "1.Add New";
            this.lblAddNew.Click += new System.EventHandler(this.lblAddNew_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(560, 345);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(50, 13);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.Text = "2.Display";
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(689, 344);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(33, 13);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "3.Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblModify
            // 
            this.lblModify.AutoSize = true;
            this.lblModify.Location = new System.Drawing.Point(464, 395);
            this.lblModify.Name = "lblModify";
            this.lblModify.Size = new System.Drawing.Size(47, 13);
            this.lblModify.TabIndex = 5;
            this.lblModify.Text = "4.Modify";
            this.lblModify.Click += new System.EventHandler(this.lblModify_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(554, 394);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "5.Search";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(672, 397);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(47, 13);
            this.lblDelete.TabIndex = 7;
            this.lblDelete.Text = "6.Delete";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // lblAddTexts
            // 
            this.lblAddTexts.AutoSize = true;
            this.lblAddTexts.Location = new System.Drawing.Point(43, 35);
            this.lblAddTexts.Name = "lblAddTexts";
            this.lblAddTexts.Size = new System.Drawing.Size(35, 13);
            this.lblAddTexts.TabIndex = 8;
            this.lblAddTexts.Text = "label1";
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdd.Location = new System.Drawing.Point(46, 51);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 13);
            this.txtAdd.TabIndex = 9;
            this.txtAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdd_KeyDown);
            // 
            // txtDel
            // 
            this.txtDel.BackColor = System.Drawing.SystemColors.Control;
            this.txtDel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDel.Location = new System.Drawing.Point(46, 51);
            this.txtDel.Name = "txtDel";
            this.txtDel.Size = new System.Drawing.Size(100, 13);
            this.txtDel.TabIndex = 10;
            this.txtDel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDel_KeyDown);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(46, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 13);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // txtModify
            // 
            this.txtModify.BackColor = System.Drawing.SystemColors.Control;
            this.txtModify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModify.Location = new System.Drawing.Point(46, 51);
            this.txtModify.Name = "txtModify";
            this.txtModify.Size = new System.Drawing.Size(100, 13);
            this.txtModify.TabIndex = 12;
            this.txtModify.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtModify_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtModify);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtDel);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lblAddTexts);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblModify);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblAddNew);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblAddNew;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblModify;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblAddTexts;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtDel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtModify;
    }
}

