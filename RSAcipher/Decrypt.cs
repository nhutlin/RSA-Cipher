using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;


namespace RSAcipher
{
    public partial class Decrypt : Form
    {
        [DllImport("RSAdll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "Decrypt")]
        private static extern IntPtr decrypt(string fPrivateKey, string fCipher);

        [DllImport("RSAdll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "clearArray")]
        private static extern void clearArray(IntPtr p, int size);
        public Decrypt()
        {
            InitializeComponent();
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string prvKeyPath = txtPrivateKey.Text;
            string cipherPath = txtCipherPath.Text;

            IntPtr result = decrypt(prvKeyPath, cipherPath);
            
            string plain = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(result + 1 * IntPtr.Size));

            FileStream fs = new FileStream(cipherPath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            txtHex.Text = sr.ReadToEnd();

            fs.Close();
            txtPlain.Text = plain;
            
            
            
        }

        private void openPrivateKey_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Example: Set the text of a text box to the selected file's path
                    txtPrivateKey.Text = openFileDialog1.FileName;
                }
            }
        }

        private void openCiphertext_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog2 = new OpenFileDialog())
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    // Example: Set the text of a text box to the selected file's path
                    txtCipherPath.Text = openFileDialog2.FileName;
                    
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
