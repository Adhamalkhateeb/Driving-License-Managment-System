using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DVLD
{
    internal class clsManipulateImages
    {
        private static string GenerateGuid()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        public static bool CreateFolderIfNotExist(string FloderPath)
        {
            if(!Directory.Exists(FloderPath))
            {
                try
                {
                    Directory.CreateDirectory(FloderPath);
                    return true;

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;
        }

        private static string ReplaceFileNameWithGuid(string Filepath)
        {
            FileInfo FI = new FileInfo(Filepath);
            return GenerateGuid() + FI.Extension.ToString() ;
        }

        public static bool CopyImageToProjectImageFolder(ref string sourceFile)
        {
            string Destination = @"C:\Adham\Course 19 Full real Project\DVLD_Images\";
            if(!CreateFolderIfNotExist(Destination))
            {
                return false;
            }

            string destinationFile = Destination + ReplaceFileNameWithGuid(sourceFile);

            try
            {
                File.Copy(sourceFile, destinationFile);
                
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            sourceFile = destinationFile;
            return true;
        }
  
    }
}
