using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace hash_code_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofdFile = new OpenFileDialog();

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdFile.FileName = txtFile.Text;
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = ofdFile.FileName;
                txtMd5.Clear();
                txtSha256.Clear();
            }
        }

       
        private MD5 Md5 = MD5.Create();

        
        private byte[] GetHashMD5(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Md5.ComputeHash(stream);
            }
        }

       
        private SHA256 Sha256 = SHA256.Create();

        private byte[] GetHashSha256(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha256.ComputeHash(stream);
            }
        }


        private SHA1 Sha1 = SHA1.Create();
        private byte[] GetHashSha1(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha1.ComputeHash(stream);
            }
        }

        private SHA384 Sha384 = SHA384.Create();
        private byte[] GetHashSha384(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha384.ComputeHash(stream);
            }
        }

        private SHA512 Sha512 = SHA512.Create();
        private byte[] GetHashSha512(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha512.ComputeHash(stream);
            }
        }

        private RIPEMD160 RipMid160 = RIPEMD160.Create();
        private byte[] GetHashRipMid160(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return RipMid160.ComputeHash(stream);
            }
        }


        public static string BytesToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes) result += b.ToString("x2");
            return result;
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void btnHash_Click_1(object sender, EventArgs e)
        {
            txtMd5.Text = BytesToString(GetHashMD5(txtFile.Text));
            txtSha256.Text = BytesToString(GetHashSha256(txtFile.Text));
            txtSha1.Text = BytesToString(GetHashSha1(txtFile.Text));
            txtSha384.Text = BytesToString(GetHashSha384(txtFile.Text));
            txtSha512.Text = BytesToString(GetHashSha512(txtFile.Text));
            txtRIPMID.Text = BytesToString(GetHashRipMid160(txtFile.Text));
        }

        private void txtMd5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
