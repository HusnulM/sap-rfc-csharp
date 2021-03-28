namespace RFC_SAP_Interface
{
    partial class frmConfirmOrder
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
            this.button1 = new System.Windows.Forms.Button();
            this.aufnr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vornr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ck1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "CONFIRM ORDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aufnr
            // 
            this.aufnr.Location = new System.Drawing.Point(171, 103);
            this.aufnr.Name = "aufnr";
            this.aufnr.Size = new System.Drawing.Size(216, 20);
            this.aufnr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Number";
            // 
            // vornr
            // 
            this.vornr.Location = new System.Drawing.Point(171, 129);
            this.vornr.Name = "vornr";
            this.vornr.Size = new System.Drawing.Size(71, 20);
            this.vornr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Operation";
            // 
            // ck1
            // 
            this.ck1.AutoSize = true;
            this.ck1.Location = new System.Drawing.Point(171, 156);
            this.ck1.Name = "ck1";
            this.ck1.Size = new System.Drawing.Size(86, 17);
            this.ck1.TabIndex = 3;
            this.ck1.Text = "Final Confirm";
            this.ck1.UseVisualStyleBackColor = true;
            // 
            // frmConfirmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 453);
            this.Controls.Add(this.ck1);
            this.Controls.Add(this.vornr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aufnr);
            this.Controls.Add(this.label1);
            this.Name = "frmConfirmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmConfirmOrder";
            this.Load += new System.EventHandler(this.frmConfirmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox aufnr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vornr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ck1;
    }
}