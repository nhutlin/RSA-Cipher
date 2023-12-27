using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace RSAcipher
{
    public partial class GenKey : Form
    {
        [DllImport("RSAdll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "genKey")]
        private static extern IntPtr genKey(int keySize);

        [DllImport("RSAdll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "clearArray")]
        private static extern void clearArray(IntPtr p, int size);

        public GenKey()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int keySize = Int32.Parse(txtKeySize.Text);
            IntPtr result = genKey(keySize);
            string modulus = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(result));
            string pubKey = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(result + 1 * IntPtr.Size));
            string prvKey = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(result + 2 * IntPtr.Size));
            string prime1 = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(result + 3 * IntPtr.Size));
            string prime2 = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(result + 4 * IntPtr.Size));


            clearArray(result, 5);
            txtModulus.Text = modulus;
            txtPrivateKey.Text = prvKey;
            txtPublicKey.Text = pubKey;
            txtPrime1.Text = prime1;
            txtPrime2.Text = prime2;

            MessageBox.Show("Save file successfully: \n" +
                    "rsa-private.der \n" +
                    "rsa-public.der \n" +
                    "rsa-private.pem \n" +
                    "rsa-public.pem");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
