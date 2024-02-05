using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHelper
{
    public static class FileHelper
    {

        public static string[] GetTopDirectories(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                return Directory.GetDirectories(directoryPath, "*", SearchOption.TopDirectoryOnly);
            }
            return null;
        }

        public static string[] GetAllDirectories(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                return Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories);
            }
            return null;
        }

        public static string[] GetAllFiles(string directoryPath)
        {
            string[] allDirectories = GetAllDirectories(directoryPath);

            List<string> allFiles = new List<string>();

            if (allDirectories != null)
            {
                foreach (string directory in allDirectories)
                {
                    allFiles.AddRange(GetAllFiles(directory).ToList());
                }
                return allFiles.ToArray() ;
            }
            return null;
        }

        public static string[] GetTopFiles(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                string[] files = Directory.GetFiles(directoryPath,"*",SearchOption.TopDirectoryOnly);
                return files;
            }
            return null;
        }

    }
}
