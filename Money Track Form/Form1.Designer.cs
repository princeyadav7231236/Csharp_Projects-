
namespace Money_Track_form
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
            this.JoeCashLabel = new System.Windows.Forms.Label();
            this.BobCashLabel = new System.Windows.Forms.Label();
            this.BankCashLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JoeCashLabel
            // 
            this.JoeCashLabel.AutoSize = true;
            this.JoeCashLabel.Location = new System.Drawing.Point(27, 18);
            this.JoeCashLabel.Name = "JoeCashLabel";
            this.JoeCashLabel.Size = new System.Drawing.Size(65, 13);
            this.JoeCashLabel.TabIndex = 0;
            this.JoeCashLabel.Text = "Joe has $50";
            this.JoeCashLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // BobCashLabel
            // 
            this.BobCashLabel.AutoSize = true;
            this.BobCashLabel.Location = new System.Drawing.Point(27, 46);
            this.BobCashLabel.Name = "BobCashLabel";
            this.BobCashLabel.Size = new System.Drawing.Size(73, 13);
            this.BobCashLabel.TabIndex = 1;
            this.BobCashLabel.Text = "Bob has $100";
            this.BobCashLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // BankCashLabel
            // 
            this.BankCashLabel.AutoSize = true;
            this.BankCashLabel.Location = new System.Drawing.Point(27, 73);
            this.BankCashLabel.Name = "BankCashLabel";
            this.BankCashLabel.Size = new System.Drawing.Size(100, 13);
            this.BankCashLabel.TabIndex = 2;
            this.BankCashLabel.Text = "The bank has $100";
            this.BankCashLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Recieve $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(52, 162);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(75, 53);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe gives $10 to Bob\r\n";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(133, 162);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(75, 53);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 250);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BankCashLabel);
            this.Controls.Add(this.BobCashLabel);
            this.Controls.Add(this.JoeCashLabel);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JoeCashLabel;
        private System.Windows.Forms.Label BobCashLabel;
        private System.Windows.Forms.Label BankCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

