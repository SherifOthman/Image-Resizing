using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;

namespace Image_Converter
{
    public static class ImageProcessing
    {
        public static Size GetImageSize(string imagePath)
        {
            using (var fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var image = Image.FromStream(fileStream, false, false))
                {
                    // Check and correct image orientation
                    if (image.PropertyIdList.Contains( 0x0112)) // 0x0112 is the EXIF tag for orientation
                    {
                        var orientation = (int)image.GetPropertyItem(0x0112).Value[0];
                        if (orientation >= 2 && orientation <= 8)
                        {
                            // Swap width and height if needed
                            return new Size(image.Height, image.Width);
                        }
                    }

                    // If no correction needed, return the original size
                    return image.Size;
                }
            }
        }

        public static Dictionary<Size, Queue<string>> GetImagesSize(string[] images, CancellationToken token)
        {

            Dictionary<Size, Queue<string>> imagesSize = new Dictionary<Size, Queue<string>>();


            foreach (string item in images)
            {

                Size imageSize = GetImageSize(item);

                if (imagesSize.ContainsKey(imageSize))
                {
                    imagesSize[imageSize].Enqueue(item);
                }
                else
                {
                    Queue<string> newSizeImages = new Queue<string>();
                    newSizeImages.Enqueue(item);
                    imagesSize.Add(imageSize, newSizeImages);
                }

                token.ThrowIfCancellationRequested();
            }

            return imagesSize;
        }

    }
}
