using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library_hash_Encrypt;

namespace Assignement5.TryIt
{
    public partial class DLLHashing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHash_Click(object sender, EventArgs e)
        {
            if(!(encryptinput.Text==""))
            {
                lblEncryped.Text= Library_hash_Encrypt.Encryption_and_Decryption.Encrypt(encryptinput.Text);
                lblHash.Text= Library_hash_Encrypt.Hashing.HashPassword(encryptinput.Text);
                txtdecryptinput.Text = Library_hash_Encrypt.Encryption_and_Decryption.Encrypt(encryptinput.Text);
            }
            else
            {
                lblEncryped.Text = "Please enter some Text";
                lblHash.Text = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lbldecrytedoutput.Text = Library_hash_Encrypt.Encryption_and_Decryption.Decrypt(txtdecryptinput.Text);
        }
    }
}