
namespace RSAcipher
{
    partial class Decrypt
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
            this.btnExit = new System.Windows.Forms.Button();
            this.labelHex = new System.Windows.Forms.Label();
            this.labelPlain = new System.Windows.Forms.Label();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.labelCipher = new System.Windows.Forms.Label();
            this.labelPrivateKey = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.openCiphertext = new System.Windows.Forms.Button();
            this.openPrivateKey = new System.Windows.Forms.Button();
            this.txtCipherPath = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnExit.Location = new System.Drawing.Point(441, 684);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 53);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelHex
            // 
            this.labelHex.AutoSize = true;
            this.labelHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelHex.Location = new System.Drawing.Point(79, 231);
            this.labelHex.Name = "labelHex";
            this.labelHex.Size = new System.Drawing.Size(172, 26);
            this.labelHex.TabIndex = 43;
            this.labelHex.Text = "Ciphertext (hex):";
            // 
            // labelPlain
            // 
            this.labelPlain.AutoSize = true;
            this.labelPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelPlain.Location = new System.Drawing.Point(543, 231);
            this.labelPlain.Name = "labelPlain";
            this.labelPlain.Size = new System.Drawing.Size(102, 26);
            this.labelPlain.TabIndex = 42;
            this.labelPlain.Text = "Plaintext:";
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(548, 272);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(420, 376);
            this.txtPlain.TabIndex = 39;
            // 
            // labelCipher
            // 
            this.labelCipher.AutoSize = true;
            this.labelCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelCipher.Location = new System.Drawing.Point(79, 124);
            this.labelCipher.Name = "labelCipher";
            this.labelCipher.Size = new System.Drawing.Size(159, 26);
            this.labelCipher.TabIndex = 37;
            this.labelCipher.Text = "Ciphertext path";
            // 
            // labelPrivateKey
            // 
            this.labelPrivateKey.AutoSize = true;
            this.labelPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelPrivateKey.Location = new System.Drawing.Point(79, 56);
            this.labelPrivateKey.Name = "labelPrivateKey";
            this.labelPrivateKey.Size = new System.Drawing.Size(168, 26);
            this.labelPrivateKey.TabIndex = 36;
            this.labelPrivateKey.Text = "Private key path";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnDecrypt.Location = new System.Drawing.Point(797, 77);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(171, 53);
            this.btnDecrypt.TabIndex = 35;
            this.btnDecrypt.Text = "DECRYPT";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // openCiphertext
            // 
            this.openCiphertext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openCiphertext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openCiphertext.FlatAppearance.BorderSize = 0;
            this.openCiphertext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.openCiphertext.Location = new System.Drawing.Point(637, 121);
            this.openCiphertext.Name = "openCiphertext";
            this.openCiphertext.Size = new System.Drawing.Size(106, 32);
            this.openCiphertext.TabIndex = 33;
            this.openCiphertext.Text = "Browse";
            this.openCiphertext.UseVisualStyleBackColor = false;
            this.openCiphertext.Click += new System.EventHandler(this.openCiphertext_Click);
            // 
            // openPrivateKey
            // 
            this.openPrivateKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openPrivateKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openPrivateKey.FlatAppearance.BorderSize = 0;
            this.openPrivateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.openPrivateKey.Location = new System.Drawing.Point(637, 56);
            this.openPrivateKey.Name = "openPrivateKey";
            this.openPrivateKey.Size = new System.Drawing.Size(106, 32);
            this.openPrivateKey.TabIndex = 32;
            this.openPrivateKey.Text = "Browse";
            this.openPrivateKey.UseVisualStyleBackColor = false;
            this.openPrivateKey.Click += new System.EventHandler(this.openPrivateKey_Click);
            // 
            // txtCipherPath
            // 
            this.txtCipherPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtCipherPath.Location = new System.Drawing.Point(275, 121);
            this.txtCipherPath.Name = "txtCipherPath";
            this.txtCipherPath.Size = new System.Drawing.Size(324, 32);
            this.txtCipherPath.TabIndex = 30;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPrivateKey.Location = new System.Drawing.Point(275, 56);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(324, 32);
            this.txtPrivateKey.TabIndex = 29;
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(84, 272);
            this.txtHex.Multiline = true;
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(420, 376);
            this.txtHex.TabIndex = 46;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1078, 777);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelHex);
            this.Controls.Add(this.labelPlain);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.labelCipher);
            this.Controls.Add(this.labelPrivateKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.openCiphertext);
            this.Controls.Add(this.openPrivateKey);
            this.Controls.Add(this.txtCipherPath);
            this.Controls.Add(this.txtPrivateKey);
            this.Name = "Decrypt";
            this.Text = "Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.Label labelPlain;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.Label labelCipher;
        private System.Windows.Forms.Label labelPrivateKey;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button openCiphertext;
        private System.Windows.Forms.Button openPrivateKey;
        private System.Windows.Forms.TextBox txtCipherPath;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}