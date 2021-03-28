namespace RFC_SAP_Interface
{
    partial class frmCreateNotif
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.cb01 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt03 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt04 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt05 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPriok = new System.Windows.Forms.ComboBox();
            this.txt06 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt07 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt08 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt09 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Number";
            // 
            // txt01
            // 
            this.txt01.Location = new System.Drawing.Point(102, 31);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(178, 20);
            this.txt01.TabIndex = 1;
            // 
            // cb01
            // 
            this.cb01.FormattingEnabled = true;
            this.cb01.Items.AddRange(new object[] {
            "Z1",
            "Z2"});
            this.cb01.Location = new System.Drawing.Point(102, 58);
            this.cb01.Name = "cb01";
            this.cb01.Size = new System.Drawing.Size(121, 21);
            this.cb01.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jenis Ticket";
            // 
            // txt02
            // 
            this.txt02.Location = new System.Drawing.Point(102, 85);
            this.txt02.Multiline = true;
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(400, 24);
            this.txt02.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Keterangan";
            // 
            // txt03
            // 
            this.txt03.Location = new System.Drawing.Point(102, 115);
            this.txt03.Name = "txt03";
            this.txt03.Size = new System.Drawing.Size(178, 20);
            this.txt03.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Funcloc";
            // 
            // txt04
            // 
            this.txt04.Location = new System.Drawing.Point(102, 141);
            this.txt04.Name = "txt04";
            this.txt04.Size = new System.Drawing.Size(178, 20);
            this.txt04.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Equipment";
            // 
            // txt05
            // 
            this.txt05.Location = new System.Drawing.Point(102, 167);
            this.txt05.Name = "txt05";
            this.txt05.Size = new System.Drawing.Size(178, 20);
            this.txt05.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Reported By";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dd-MM-yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(102, 221);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(97, 20);
            this.dtDate.TabIndex = 13;
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "HH:mm:ss";
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(205, 221);
            this.dtTime.Name = "dtTime";
            this.dtTime.ShowUpDown = true;
            this.dtTime.Size = new System.Drawing.Size(97, 20);
            this.dtTime.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Notif Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Priority";
            // 
            // cbPriok
            // 
            this.cbPriok.FormattingEnabled = true;
            this.cbPriok.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbPriok.Location = new System.Drawing.Point(102, 193);
            this.cbPriok.Name = "cbPriok";
            this.cbPriok.Size = new System.Drawing.Size(121, 21);
            this.cbPriok.TabIndex = 16;
            // 
            // txt06
            // 
            this.txt06.Location = new System.Drawing.Point(465, 141);
            this.txt06.Name = "txt06";
            this.txt06.Size = new System.Drawing.Size(178, 20);
            this.txt06.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Dept. Origin";
            // 
            // txt07
            // 
            this.txt07.Location = new System.Drawing.Point(465, 167);
            this.txt07.Name = "txt07";
            this.txt07.Size = new System.Drawing.Size(178, 20);
            this.txt07.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Dept. Destination";
            // 
            // txt08
            // 
            this.txt08.Location = new System.Drawing.Point(465, 193);
            this.txt08.Name = "txt08";
            this.txt08.Size = new System.Drawing.Size(178, 20);
            this.txt08.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Funcloc Dest";
            // 
            // txt09
            // 
            this.txt09.Location = new System.Drawing.Point(465, 219);
            this.txt09.Name = "txt09";
            this.txt09.Size = new System.Drawing.Size(178, 20);
            this.txt09.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Cost Center Dst";
            // 
            // frmCreateNotif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 504);
            this.Controls.Add(this.txt09);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt08);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt07);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt06);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPriok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt05);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt04);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt03);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb01);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateNotif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateNotif";
            this.Load += new System.EventHandler(this.frmCreateNotif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.ComboBox cb01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt02;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt03;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt04;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt05;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPriok;
        private System.Windows.Forms.TextBox txt06;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt07;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt08;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt09;
        private System.Windows.Forms.Label label12;
    }
}