using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SkyhighConnectedLayer;
using System.Configuration;
using System.Data;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    private string Encryptdata(string password)
    {
        string strmsg = string.Empty;
        byte[] encode = new byte[password.Length];
        encode = Encoding.UTF8.GetBytes(password);
        strmsg = Convert.ToBase64String(encode);
        return strmsg;
    }

    private string Decryptdata(string encryptpwd)
    {
        string decryptpwd = string.Empty;
        UTF8Encoding encodepwd = new UTF8Encoding();
        Decoder Decode = encodepwd.GetDecoder();
        byte[] todecode_byte = Convert.FromBase64String(encryptpwd);
        int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
        char[] decoded_char = new char[charCount];
        Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
        decryptpwd = new String(decoded_char);
        return decryptpwd;
    }

    
    
    //string strpassword = Encryptdata(TextBox1.Text); //Enc

    //string strpassword = Decryptdata(TextBox2.Text); //Dec
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox3.Text = Encryptdata(TextBox1.Text);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox4.Text = Decryptdata(TextBox2.Text);
    }
}