using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RSAcipher
{
    public partial class Encrypt : Form
    {
        [DllImport("RSAdll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "Encrypt")]
        private static extern IntPtr encrypt(string fPublicKey, string fPlain, string fCipher);

        [DllImport("RSAdll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "clearArray")]
        private static extern void clearArray(IntPtr p, int size);
        public Encrypt()
        {
            InitializeComponent();
        }

        private void openPublicKey_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Example: Set the text of a text box to the selected file's path
                    txtPublicKey.Text = openFileDialog1.FileName;
                }
            }
        }

        private void openSignPath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Ciphertext files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save Ciphertext File";

            // Show the SaveFileDialog
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Set the TextBox text to the selected file path
                txtOutPath.Text = saveFileDialog1.FileName;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string pubKeyPath = txtPublicKey.Text;
            string plainPath = txtPlainPath.Text;
            string outPath = txtOutPath.Text;

            //Get the encrypt value
            IntPtr result = encrypt(pubKeyPath, plainPath, outPath);
            string plaintext = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(result));
            string hexCipher = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(result + 1 * IntPtr.Size));
            string base64Cipher = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(result + 2 * IntPtr.Size));

            clearArray(result, 3);

            txtPlain.Text = plaintext;
            txtHex.Text = hexCipher;
            txtBase64.Text = base64Cipher;
        }

        private void openPlaintext_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog2 = new OpenFileDialog())
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    // Example: Set the text of a text box to the selected file's path
                    txtPlainPath.Text = openFileDialog2.FileName;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
