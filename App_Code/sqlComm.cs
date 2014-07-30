using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

/// <summary>
/// sqlComm의 요약 설명입니다.
/// </summary>
public class sqlComm
{
	public sqlComm()
	{
		//
		// TODO: 여기에 생성자 논리를 추가합니다.
		//
	}

    private SqlConnection sqlCn = new SqlConnection();

    public void OpenConnection(string connectionString)
    {
        sqlCn.ConnectionString = connectionString;
        sqlCn.Open();
    }
    public void CloseConnection()
    {
        sqlCn.Close();
    }
    //Encrypt Password
    public string Encryptdata(string password)
    {
        string strmsg = string.Empty;
        byte[] encode = new byte[password.Length];
        encode = Encoding.UTF8.GetBytes(password);
        strmsg = Convert.ToBase64String(encode);
        return strmsg;
    }
    //Decrypt Password
    public string Decryptdata(string encryptpwd)
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

    public string errorMsg { get; set; }

    public void InsertClients(string company, string firstName, string lastName, string tel,
        string fax, string mobile, string add1, string add2, string email)
    {

        //building staff insert sql
        string sql = string.Format("Insert Into Clients" +
            "(C_Company, C_FirstName, C_LastName, C_Tel, " +
            "C_Fax, C_Mobile, C_Add1, C_Add2, C_Email) values" +
            "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
            company, firstName, lastName, tel, fax, mobile, add1, add2, email);
        try
        {
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception)
        {
            errorMsg = "Fail to creating new user.";

        }

    }

    public void EditClients(int id, string company, string firstName, string lastName, string tel,
        string fax, string mobile, string add1, string add2, string email)
    {

        //building staff update sql
        string sql = string.Format("Update Clients set " +
            "C_Company = '{0}', C_FirstName = '{1}', C_LastName = '{2}', C_Tel = '{3}', " +
            "C_Fax = '{4}', C_Mobile = '{5}', C_Add1 = '{6}', C_Add2 = '{7}', " +
            "C_Email = '{8}' where C_ID = {9}",
            company, firstName, lastName, tel, fax, mobile, add1, add2, email, id);
        try
        {
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception)
        {
            errorMsg = "Fail to update new user.";

        }

    }

    public void DeleteClients(int C_ID)
    {

        //building staff update sql
        string sql = string.Format("Delete from Clients where C_ID = {0}", C_ID);
        try
        {
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception)
        {
            errorMsg = "Fail to Delete";

        }

    }

    public void InsertStaffs(string id, string pwd, string firstName, string lastName, string role,
        string dob, string add1, string add2, string contact, string email)
    {
        
        //building staff insert sql
        string sql = string.Format("Insert Into Staffs" +
            "(S_UserID, S_Pwd, S_FirstName, S_LastName, S_DOB, " +
            "S_Role, S_Address1, S_Address2, S_Contact, S_Email) values" +
            "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
            id, pwd, firstName, lastName, dob, role, add1, add2, contact, email);
        try
        {
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception)
        {
            errorMsg = "Fail to creating new user.";

        }

    }

    public void EditStaffs(int S_ID, string pwd, string firstName, string lastName, string role,
        string dob, string add1, string add2, string contact, string email)
    {

        //building staff update sql
        string sql = string.Format("Update Staffs set " +
            "S_Pwd = '{0}', S_FirstName = '{1}', S_LastName = '{2}', S_DOB = '{3}', " +
            "S_Role = '{4}', S_Address1 = '{5}', S_Address2 = '{6}', S_Contact = '{7}', " +
            "S_Email = '{8}' where S_ID = {9}",
            pwd, firstName, lastName, dob, role, add1, add2, contact, email, S_ID);
        try
        {
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception)
        {
            errorMsg = "Fail to update new user.";

        }

    }

    public void DeleteRecord(int S_ID, string tableName, string fieldName)
    {

        //building staff update sql
        string sql = string.Format("Delete from {0} where {1} = {2}", tableName,fieldName, S_ID);
        try
        {
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception)
        {
            errorMsg = "Fail to Delete";

        }

    }

    public void DeleteRole(int index)
    {

        //building staff update sql
        string sql = string.Format("Delete from Roles where R_Index = {0}", index);
        try
        {
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception)
        {
            errorMsg = "Fail to update new user.";

        }

    }

    public void InsertRoles(string Role)
    {

        //building staff insert sql
        string sql = string.Format("INSERT INTO Roles (R_Index,R_Roles) VALUES ((Select Max(R_Index)+1 from Roles), '{0}')", Role);
        try
        {
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception)
        {
            errorMsg = "Fail to creating new user.";

        }

    }
}