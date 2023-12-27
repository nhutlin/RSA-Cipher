
namespace RSAcipher
{
    partial class GenKey
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
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtModulus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrime1 = new System.Windows.Forms.TextBox();
            this.label_prime1 = new System.Windows.Forms.Label();
            this.label_prime2 = new System.Windows.Forms.Label();
            this.txtPrime2 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKeySize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(850, 74);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.Size = new System.Drawing.Size(168, 55);
            this.txtPublicKey.TabIndex = 0;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(80, 288);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(722, 156);
            this.txtPrivateKey.TabIndex = 1;
            // 
            // txtModulus
            // 
            this.txtModulus.Location = new System.Drawing.Point(80, 74);
            this.txtModulus.Multiline = true;
            this.txtModulus.Name = "txtModulus";
            this.txtModulus.ReadOnly = true;
            this.txtModulus.Size = new System.Drawing.Size(722, 156);
            this.txtModulus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modulus n:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Private Exponent d:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(845, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Public Exponent e:";
            // 
            // txtPrime1
            // 
            this.txtPrime1.Location = new System.Drawing.Point(850, 170);
            this.txtPrime1.Multiline = true;
            this.txtPrime1.Name = "txtPrime1";
            this.txtPrime1.ReadOnly = true;
            this.txtPrime1.Size = new System.Drawing.Size(350, 150);
            this.txtPrime1.TabIndex = 6;
            // 
            // label_prime1
            // 
            this.label_prime1.AutoSize = true;
            this.label_prime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prime1.Location = new System.Drawing.Point(845, 142);
            this.label_prime1.Name = "label_prime1";
            this.label_prime1.Size = new System.Drawing.Size(84, 25);
            this.label_prime1.TabIndex = 7;
            this.label_prime1.Text = "Prime 1:";
            // 
            // label_prime2
            // 
            this.label_prime2.AutoSize = true;
            this.label_prime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prime2.Location = new System.Drawing.Point(845, 347);
            this.label_prime2.Name = "label_prime2";
            this.label_prime2.Size = new System.Drawing.Size(84, 25);
            this.label_prime2.TabIndex = 9;
            this.label_prime2.Text = "Prime 2:";
            // 
            // txtPrime2
            // 
            this.txtPrime2.Location = new System.Drawing.Point(850, 375);
            this.txtPrime2.Multiline = true;
            this.txtPrime2.Name = "txtPrime2";
            this.txtPrime2.ReadOnly = true;
            this.txtPrime2.Size = new System.Drawing.Size(350, 152);
            this.txtPrime2.TabIndex = 8;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(591, 459);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(211, 68);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(80, 459);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(211, 68);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1055, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Key size:";
            // 
            // txtKeySize
            // 
            this.txtKeySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeySize.FormattingEnabled = true;
            this.txtKeySize.Items.AddRange(new object[] {
            "2048",
            "3072",
            "4096"});
            this.txtKeySize.Location = new System.Drawing.Point(1060, 74);
            this.txtKeySize.Name = "txtKeySize";
            this.txtKeySize.Size = new System.Drawing.Size(121, 33);
            this.txtKeySize.TabIndex = 15;
            this.txtKeySize.Text = "3072";
            // 
            // GenKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1290, 542);
            this.Controls.Add(this.txtKeySize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label_prime2);
            this.Controls.Add(this.txtPrime2);
            this.Controls.Add(this.label_prime1);
            this.Controls.Add(this.txtPrime1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModulus);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.txtPublicKey);
            this.Name = "GenKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtModulus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrime1;
        private System.Windows.Forms.Label label_prime1;
        private System.Windows.Forms.Label label_prime2;
        private System.Windows.Forms.TextBox txtPrime2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtKeySize;
    }
}