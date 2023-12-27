
namespace RSAcipher
{
    partial class Encrypt
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
            this.outCipher = new System.Windows.Forms.Label();
            this.labelPlain = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.openSignPath = new System.Windows.Forms.Button();
            this.openPlaintext = new System.Windows.Forms.Button();
            this.openPublicKey = new System.Windows.Forms.Button();
            this.txtOutPath = new System.Windows.Forms.TextBox();
            this.txtPlainPath = new System.Windows.Forms.TextBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // outCipher
            // 
            this.outCipher.AutoSize = true;
            this.outCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.outCipher.Location = new System.Drawing.Point(117, 199);
            this.outCipher.Name = "outCipher";
            this.outCipher.Size = new System.Drawing.Size(225, 26);
            this.outCipher.TabIndex = 21;
            this.outCipher.Text = "Output ciphertext path";
            // 
            // labelPlain
            // 
            this.labelPlain.AutoSize = true;
            this.labelPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelPlain.Location = new System.Drawing.Point(198, 130);
            this.labelPlain.Name = "labelPlain";
            this.labelPlain.Size = new System.Drawing.Size(144, 26);
            this.labelPlain.TabIndex = 20;
            this.labelPlain.Text = "Plaintext path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(182, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Public key path";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEncrypt.Location = new System.Drawing.Point(901, 120);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(171, 53);
            this.btnEncrypt.TabIndex = 18;
            this.btnEncrypt.Text = "ENCRYPT";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // openSignPath
            // 
            this.openSignPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openSignPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openSignPath.FlatAppearance.BorderSize = 0;
            this.openSignPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSignPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.openSignPath.Location = new System.Drawing.Point(732, 196);
            this.openSignPath.Name = "openSignPath";
            this.openSignPath.Size = new System.Drawing.Size(106, 32);
            this.openSignPath.TabIndex = 17;
            this.openSignPath.Text = "Browse";
            this.openSignPath.UseVisualStyleBackColor = false;
            this.openSignPath.Click += new System.EventHandler(this.openSignPath_Click);
            // 
            // openPlaintext
            // 
            this.openPlaintext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openPlaintext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openPlaintext.FlatAppearance.BorderSize = 0;
            this.openPlaintext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.openPlaintext.Location = new System.Drawing.Point(732, 130);
            this.openPlaintext.Name = "openPlaintext";
            this.openPlaintext.Size = new System.Drawing.Size(106, 32);
            this.openPlaintext.TabIndex = 16;
            this.openPlaintext.Text = "Browse";
            this.openPlaintext.UseVisualStyleBackColor = false;
            this.openPlaintext.Click += new System.EventHandler(this.openPlaintext_Click);
            // 
            // openPublicKey
            // 
            this.openPublicKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openPublicKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openPublicKey.FlatAppearance.BorderSize = 0;
            this.openPublicKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.openPublicKey.Location = new System.Drawing.Point(732, 65);
            this.openPublicKey.Name = "openPublicKey";
            this.openPublicKey.Size = new System.Drawing.Size(106, 32);
            this.openPublicKey.TabIndex = 15;
            this.openPublicKey.Text = "Browse";
            this.openPublicKey.UseVisualStyleBackColor = false;
            this.openPublicKey.Click += new System.EventHandler(this.openPublicKey_Click);
            // 
            // txtOutPath
            // 
            this.txtOutPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtOutPath.Location = new System.Drawing.Point(370, 196);
            this.txtOutPath.Name = "txtOutPath";
            this.txtOutPath.Size = new System.Drawing.Size(324, 32);
            this.txtOutPath.TabIndex = 14;
            // 
            // txtPlainPath
            // 
            this.txtPlainPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPlainPath.Location = new System.Drawing.Point(370, 130);
            this.txtPlainPath.Name = "txtPlainPath";
            this.txtPlainPath.Size = new System.Drawing.Size(324, 32);
            this.txtPlainPath.TabIndex = 13;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPublicKey.Location = new System.Drawing.Point(370, 65);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(324, 32);
            this.txtPublicKey.TabIndex = 12;
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(38, 319);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(342, 376);
            this.txtPlain.TabIndex = 22;
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(432, 319);
            this.txtHex.Multiline = true;
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(342, 376);
            this.txtHex.TabIndex = 23;
            // 
            // txtBase64
            // 
            this.txtBase64.Location = new System.Drawing.Point(823, 319);
            this.txtBase64.Multiline = true;
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.Size = new System.Drawing.Size(342, 376);
            this.txtBase64.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(33, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Plaintext:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(427, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ciphertext (hex):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(818, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ciphertext (base64):";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnExit.Location = new System.Drawing.Point(523, 719);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 53);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1208, 784);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBase64);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.outCipher);
            this.Controls.Add(this.labelPlain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.openSignPath);
            this.Controls.Add(this.openPlaintext);
            this.Controls.Add(this.openPublicKey);
            this.Controls.Add(this.txtOutPath);
            this.Controls.Add(this.txtPlainPath);
            this.Controls.Add(this.txtPublicKey);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Encrypt";
            this.Text = "Encrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label outCipher;
        private System.Windows.Forms.Label labelPlain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button openSignPath;
        private System.Windows.Forms.Button openPlaintext;
        private System.Windows.Forms.Button openPublicKey;
        private System.Windows.Forms.TextBox txtOutPath;
        private System.Windows.Forms.TextBox txtPlainPath;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtBase64;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}