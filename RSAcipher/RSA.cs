using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAcipher
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
        }

        private void btnGenKey_Click(object sender, EventArgs e)
        {
            GenKey genKey = new GenKey();
            genKey.Show();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            encrypt.Show();
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Decrypt decrypt = new Decrypt();
            decrypt.Show();
        }
    }
}
