using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ImageConverterLib
{
    public static class ImageHelper
    {
        public static int GetNewWidth(int originalWidth, int originalHeight, int newHeight)
        {
            return Convert.ToInt32(Math.Round((originalWidth / (double)originalHeight) * newHeight));
        }

        public static int GetNewHeight(int originalWidth, int originalHeight, int newWidth)
        {
            return Convert.ToInt32(Math.Round((originalHeight / (double)originalWidth) * newWidth));
        }

        public static string[] GetImagesFromDirectory(string directoryPath, CancellationToken token)
        {

            if (Directory.Exists(directoryPath))
            {
                string[] files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
               
                List<string> Images = new List<string>();

                foreach (string file in files)
                {

                    if (IsImageByExtension(file))
                    {
                        Images.Add(file);
                    }

                    token.ThrowIfCancellationRequested();
                }

                if (Images.Count > 0)
                {
                    return Images.ToArray();
                }
            }

            return null;
        }

        static async Task<bool> IsImageByHeader(string filePath)
        {
            try
            {
                byte[] header = new byte[4];
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    await fs.ReadAsync(header, 0, header.Length).ConfigureAwait(false);
                }

                // JPEG: 0xFFD8, PNG: 0x89504E47, GIF: 0x47494638, BMP: 0x424D
                return (header[0] == 0xFF && header[1] == 0xD8) ||
                       (header[0] == 0x89 && header[1] == 0x50 && header[2] == 0x4E && header[3] == 0x47) ||
                       (header[0] == 0x47 && header[1] == 0x49 && header[2] == 0x46 && header[3] == 0x38) ||
                       (header[0] == 0x42 && header[1] == 0x4D);
            }
            catch (Exception)
            {
                return false; // Handle exceptions, e.g., if the file does not exist
            }
        }

        public static bool IsImageByExtension(string filePath)
        {
            string[] validExtensions = { ".jpg", ".png", ".gif", ".bmp", ".jpeg" };

            string fileExtension = Path.GetExtension(filePath).ToLower();

            foreach (string extension in validExtensions)
            {
                if (fileExtension == extension)
                {
                    return true;
                }
            }

            return false;
        }

    }
}




