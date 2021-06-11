namespace Wildlife.License_Management
{
    partial class LicenseEntry
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtlicid = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelate = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.txtlicname = new System.Windows.Forms.TextBox();
            this.btnsearach = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-101, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(919, 125);
            this.metroPanel1.TabIndex = 31;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(219, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "License";
            // 
            // txtamt
            // 
            this.txtamt.Location = new System.Drawing.Point(242, 249);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(203, 20);
            this.txtamt.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(125, 250);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 36;
            this.metroLabel3.Text = "Amount";
            // 
            // txtlicid
            // 
            this.txtlicid.Location = new System.Drawing.Point(101, 153);
            this.txtlicid.Name = "txtlicid";
            this.txtlicid.Size = new System.Drawing.Size(80, 20);
            this.txtlicid.TabIndex = 0;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 154);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "License Id";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(125, 213);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "Choose Category";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(469, 332);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 36);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(157, 332);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(98, 36);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(261, 332);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 36);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelate
            // 
            this.btndelate.BackColor = System.Drawing.Color.Transparent;
            this.btndelate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelate.Location = new System.Drawing.Point(365, 332);
            this.btndelate.Name = "btndelate";
            this.btndelate.Size = new System.Drawing.Size(98, 36);
            this.btndelate.TabIndex = 5;
            this.btndelate.Text = "Delete";
            this.btndelate.UseVisualStyleBackColor = false;
            this.btndelate.Click += new System.EventHandler(this.btndelate_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(340, 139);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(146, 19);
            this.metroLabel4.TabIndex = 43;
            this.metroLabel4.Text = "Select License Category";
            // 
            // cmbsearch
            // 
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Location = new System.Drawing.Point(492, 139);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(160, 21);
            this.cmbsearch.TabIndex = 7;
            // 
            // txtlicname
            // 
            this.txtlicname.Location = new System.Drawing.Point(242, 213);
            this.txtlicname.Name = "txtlicname";
            this.txtlicname.Size = new System.Drawing.Size(203, 20);
            this.txtlicname.TabIndex = 1;
            // 
            // btnsearach
            // 
            this.btnsearach.BackColor = System.Drawing.Color.Transparent;
            this.btnsearach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearach.Location = new System.Drawing.Point(658, 131);
            this.btnsearach.Name = "btnsearach";
            this.btnsearach.Size = new System.Drawing.Size(98, 36);
            this.btnsearach.TabIndex = 8;
            this.btnsearach.Text = "Search";
            this.btnsearach.UseVisualStyleBackColor = false;
            this.btnsearach.Click += new System.EventHandler(this.btnsearach_Click);
            // 
            // LicenseEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 391);
            this.Controls.Add(this.btnsearach);
            this.Controls.Add(this.txtlicname);
            this.Controls.Add(this.cmbsearch);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btndelate);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtamt);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtlicid);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LicenseEntry";
            this.Text = "License";
            this.Load += new System.EventHandler(this.Category_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtamt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox txtlicid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.TextBox txtlicname;
        private System.Windows.Forms.Button btnsearach;
    }
}