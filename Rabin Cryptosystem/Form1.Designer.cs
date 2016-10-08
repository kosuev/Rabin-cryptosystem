namespace Rabin_Cryptosystem
{
    partial class MainForm
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
            this.OpentxtBox = new System.Windows.Forms.TextBox();
            this.ShifrtxtBox = new System.Windows.Forms.TextBox();
            this.DshifrtxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpentxtBox
            // 
            this.OpentxtBox.Location = new System.Drawing.Point(12, 34);
            this.OpentxtBox.Multiline = true;
            this.OpentxtBox.Name = "OpentxtBox";
            this.OpentxtBox.Size = new System.Drawing.Size(136, 113);
            this.OpentxtBox.TabIndex = 0;
            this.OpentxtBox.Text = "Enter your message";
            // 
            // ShifrtxtBox
            // 
            this.ShifrtxtBox.Location = new System.Drawing.Point(12, 188);
            this.ShifrtxtBox.Multiline = true;
            this.ShifrtxtBox.Name = "ShifrtxtBox";
            this.ShifrtxtBox.Size = new System.Drawing.Size(136, 113);
            this.ShifrtxtBox.TabIndex = 1;
            // 
            // DshifrtxtBox
            // 
            this.DshifrtxtBox.Location = new System.Drawing.Point(202, 188);
            this.DshifrtxtBox.Multiline = true;
            this.DshifrtxtBox.Name = "DshifrtxtBox";
            this.DshifrtxtBox.Size = new System.Drawing.Size(136, 113);
            this.DshifrtxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Open message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Decrypted message";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Encrypt/decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DshifrtxtBox);
            this.Controls.Add(this.ShifrtxtBox);
            this.Controls.Add(this.OpentxtBox);
            this.Name = "MainForm";
            this.Text = "Rabin cryptosystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OpentxtBox;
        private System.Windows.Forms.TextBox ShifrtxtBox;
        private System.Windows.Forms.TextBox DshifrtxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

