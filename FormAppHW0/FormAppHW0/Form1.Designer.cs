namespace FormAppHW0
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
            this.lnAmount = new System.Windows.Forms.TextBox();
            this.trmYears = new System.Windows.Forms.TextBox();
            this.iRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MonthHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BalHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IntereestHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrincipalHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lnAmount
            // 
            this.lnAmount.Location = new System.Drawing.Point(148, 48);
            this.lnAmount.Name = "lnAmount";
            this.lnAmount.Size = new System.Drawing.Size(100, 20);
            this.lnAmount.TabIndex = 0;
            this.lnAmount.TextChanged += new System.EventHandler(this.LnAmount_TextChanged);
            // 
            // trmYears
            // 
            this.trmYears.Location = new System.Drawing.Point(148, 106);
            this.trmYears.Name = "trmYears";
            this.trmYears.Size = new System.Drawing.Size(100, 20);
            this.trmYears.TabIndex = 1;
            this.trmYears.TextChanged += new System.EventHandler(this.TrmYears_TextChanged);
            // 
            // iRate
            // 
            this.iRate.Location = new System.Drawing.Point(148, 162);
            this.iRate.Name = "iRate";
            this.iRate.Size = new System.Drawing.Size(100, 20);
            this.iRate.TabIndex = 2;
            this.iRate.TextChanged += new System.EventHandler(this.IRate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loan Amount ($)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loan Term (Years)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interest Rate (%)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 86);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(254, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Must be a Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(254, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Must be a Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(254, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Must be a %";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MonthHead,
            this.BalHead,
            this.IntereestHead,
            this.PrincipalHead});
            this.listView1.Location = new System.Drawing.Point(12, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(657, 187);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MonthHead
            // 
            this.MonthHead.Text = "Month";
            this.MonthHead.Width = 76;
            // 
            // BalHead
            // 
            this.BalHead.Text = "Balance";
            this.BalHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BalHead.Width = 186;
            // 
            // IntereestHead
            // 
            this.IntereestHead.Text = "Interest Paid";
            this.IntereestHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IntereestHead.Width = 196;
            // 
            // PrincipalHead
            // 
            this.PrincipalHead.Text = "Principal Paid";
            this.PrincipalHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrincipalHead.Width = 187;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 399);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iRate);
            this.Controls.Add(this.trmYears);
            this.Controls.Add(this.lnAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lnAmount;
        private System.Windows.Forms.TextBox trmYears;
        private System.Windows.Forms.TextBox iRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MonthHead;
        private System.Windows.Forms.ColumnHeader BalHead;
        private System.Windows.Forms.ColumnHeader IntereestHead;
        private System.Windows.Forms.ColumnHeader PrincipalHead;
    }
}

