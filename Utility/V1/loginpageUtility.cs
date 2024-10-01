using Microsoft.AspNetCore.Identity.Data;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using WMSCOREAPI.Models.V1.Request;


namespace WMSCOREAPI.Utility.V1
{
    public class loginpageUtility
    {
        SqlParameter[] param;
        DBActivity obj;
        public loginpageUtility()
        {
            obj = new DBActivity();
        }
        public async Task<JsonElement> Getlogin(GetloginRequest req)
        {
            string EncrypPassword = "|@|" + encryptstring(req.Password);
            param = new SqlParameter[]
                    {
                        new SqlParameter("@UserName", req.UserName),
                        new SqlParameter("@Password", req.Password),
                        new SqlParameter("@EncrypPassword", EncrypPassword)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mobile_LoginPage", param));



            //TokenAuthUtility tokenObj = new TokenAuthUtility();
            //string GetToken = tokenObj.GenerateTokenCode();
            //string EncrypPassword = "|@|" + encryptstring(req.Password);
            //param = new SqlParameter[]
            //        {
            //            new SqlParameter("@UserName", req.UserName),
            //            new SqlParameter("@Password", req.Password),
            //            new SqlParameter("@EncrypPassword", EncrypPassword),
            //            new SqlParameter("@Token", GetToken),
            //        };
            //return obj.ConvertDataSetToJObject(obj.Return_DataSet("MobileLoginWithToken", param));


        }
        public static string encryptstring(string encryptString)
        {
            string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }
        public string ResetPassword(Models.V1.Request.ResetPasswordRequest req)
        {
            string EncrypOldPassword = "";
            string getOldPassword = req.OldPassword;
            string substr = getOldPassword.Substring(0, 3);
            if (substr.Trim() == "|@|")
            {
                EncrypOldPassword = req.OldPassword;
            }
            else
            {
                EncrypOldPassword = "|@|" + encryptstring(req.OldPassword);
            }
            // string EncrypOldPassword = "|@|" + encryptstring(req.OldPassword);
            string EncrypNewPassword = "|@|" + encryptstring(req.NewPassword);
            param = new SqlParameter[]
                    {

                        new SqlParameter("@UserID", Int64.Parse(req.UserID)),
                        new SqlParameter("@OldPassword", EncrypOldPassword),
                        new SqlParameter("@NewPassword", EncrypNewPassword),
                        new SqlParameter("@UserName", req.UserName),
                    };
            return obj.Return_ScalerValue("Sp_ResetPassword", param);
        }
        public static string Decryptstring(string encryptString)
        {
            string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            encryptString = encryptString.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    encryptString = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return encryptString;
        }
        public async Task<JsonElement> ForgetPassword(ForgetPasswordRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@UserName", req.UserName),
                        new SqlParameter("@EmailID", req.EmailID),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_ForgetPassword", param));
        }
        public async Task<JsonElement> GetCompanyLogo(GetlogoRequest req)
        {
            param = new SqlParameter[]
                  {
                        new SqlParameter("@CompanyId", req.CompanyID)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("GetCompanyLogo", param));
        }

        public async Task<JsonElement> GetCustLott(GetCustLott req)
        {
            param = new SqlParameter[]
                  {
                        new SqlParameter("@custid", req.custid),
                        new SqlParameter("@Userid", req.Userid)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("MobCustLott", param));
        }
    }

}

