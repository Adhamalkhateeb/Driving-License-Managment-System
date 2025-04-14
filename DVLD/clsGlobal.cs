using DVLDBussinesLayer;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD
{
    static class clsGlobal
    {
        public static clsUser CurrentUser;

        private static readonly string KeyPath = @"HKEY_CURRENT_USER\Software\DVLD";
        private static readonly string RegPath = @"Software\DVLD";
        public static bool RememberUserNameAndPassword(string UserName,string Password)
        {
            try
            {
                if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                {
                    
                    return false;
                }

               
                byte[] encryptedPasswordBytes = ProtectedData.Protect(Encoding.UTF8.GetBytes(Password),null ,DataProtectionScope.CurrentUser);

                string encryptedPassword = Convert.ToBase64String(encryptedPasswordBytes);

               
                RegistryKey key = Registry.CurrentUser.CreateSubKey(RegPath);
                key.SetValue("UserName", UserName);
                key.SetValue("Password", encryptedPassword);
                key.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }


        public static bool GetStoredCredentials(ref string UserName,ref string Password)
        {
            try
            {
               
                UserName = Registry.GetValue(KeyPath, "UserName", string.Empty) as string;

                if (!string.IsNullOrEmpty(UserName))
                {
                    string encryptedPassword = Registry.GetValue(KeyPath, "Password", string.Empty) as string;

                    if (!string.IsNullOrEmpty(encryptedPassword))
                    {
                       
                        byte[] encryptedBytes = Convert.FromBase64String(encryptedPassword);
                        byte[] decryptedBytes = ProtectedData.Unprotect(encryptedBytes, null, DataProtectionScope.CurrentUser);
                        Password = Encoding.UTF8.GetString(decryptedBytes);

                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
    }

