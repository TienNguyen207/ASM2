namespace New_ASM2
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
            this.btadd = new System.Windows.Forms.Button();
            this.tbno = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.tbThis = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.No = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btedit = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(40, 330);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 0;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbno
            // 
            this.tbno.Location = new System.Drawing.Point(143, 91);
            this.tbno.Name = "tbno";
            this.tbno.Size = new System.Drawing.Size(100, 20);
            this.tbno.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(143, 133);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(143, 177);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(100, 20);
            this.tbLast.TabIndex = 3;
            // 
            // tbThis
            // 
            this.tbThis.Location = new System.Drawing.Point(143, 221);
            this.tbThis.Name = "tbThis";
            this.tbThis.Size = new System.Drawing.Size(100, 20);
            this.tbThis.TabIndex = 4;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Household customer",
            "Administrative agency, public services",
            "Production units",
            "Business services"});
            this.cbType.Location = new System.Drawing.Point(122, 271);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 5;
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(62, 91);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(21, 13);
            this.No.TabIndex = 6;
            this.No.Text = "No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Water Used Last Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Water Used This Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Types";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(315, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 248);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(168, 330);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(75, 23);
            this.btedit.TabIndex = 12;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(40, 383);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 13;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(168, 383);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 14;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Water Bill";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.No);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbThis);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbno);
            this.Controls.Add(this.btadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox tbno;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.TextBox tbThis;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label No;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label label1;
    }
}

