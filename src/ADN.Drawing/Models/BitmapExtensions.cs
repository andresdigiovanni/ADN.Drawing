using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace ADN.Drawing
{
    /// <summary>
    /// A static class of extension methods for <see cref="Bitmap"/>.
    /// </summary>
    public static class BitmapExtensions
    {
        /// <summary>
        /// Crop a Bitmap.
        /// </summary>
        /// <param name="source">Bitmap to crop.</param>
        /// <param name="section">Section to crop the bitmap.</param>
        /// <returns>Croped image.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var originalBitmap = (Bitmap)Bitmap.FromFile("polar-bear.png");
        /// int width = 320;
        /// int height = 180;
        /// int x = 200;
        /// int y = 200;
        /// var rectangle = new Rectangle(new Point(x, y), new Size(width, height));
        /// var cropedBitmap = originalBitmap.CropImage(rectangle);
        /// </code>
        /// </example>
        public static Bitmap CropImage(this Bitmap source, Rectangle section)
        {
            var bitmap = new Bitmap(section.Width, section.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
                return bitmap;
            }
        }

        /// <summary>
        /// Resize a Bitmap.
        /// </summary>
        /// <param name="source">Bitmap to resize.</param>
        /// <param name="width">New width.</param>
        /// <param name="height">New height.</param>
        /// <param name="pixelFormat">Specifies the format of the color data for each pixel in the image.</param>
        /// <returns>Resized bitmap.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var originalBitmap = (Bitmap)Bitmap.FromFile("polar-bear.png");
        /// int width = 320;
        /// int height = 180;
        /// var resizedBitmap = originalBitmap.Resize(width, height);
        /// </code>
        /// </example>
        public static Bitmap Resize(this Bitmap source, int width, int height, PixelFormat pixelFormat = PixelFormat.Format32bppRgb)
        {
            Bitmap bitmap = new Bitmap(width, height, pixelFormat);
            bitmap.SetResolution(source.HorizontalResolution, source.VerticalResolution);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(source, 0, 0, width, height);
                return bitmap;
            }
        }

        /// <summary>
        /// Resize the canvas of a Bitmap.
        /// </summary>
        /// <param name="bitmap">Bitmap to resize.</param>
        /// <param name="width">New width.</param>
        /// <param name="height">New height.</param>
        /// <param name="pixelFormat">Specifies the format of the color data for each pixel in the image.</param>
        /// <returns>Resized bitmap.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var originalBitmap = (Bitmap)Bitmap.FromFile("polar-bear.png");
        /// int width = 320;
        /// int height = 180;
        /// var resizedBitmap = originalBitmap.ResizeCanvas(width, height);
        /// </code>
        /// </example>
        public static Bitmap ResizeCanvas(this Bitmap bitmap, int width, int height, PixelFormat pixelFormat = PixelFormat.Format32bppRgb)
        {
            Bitmap temp = new Bitmap(width, height, pixelFormat);
            temp.SetResolution(bitmap.HorizontalResolution, bitmap.VerticalResolution);
            Graphics g = Graphics.FromImage(temp);
            g.DrawImageUnscaled(bitmap, 0, 0, width, height);

            return temp;
        }

        /// <summary>
        /// Set background of a Bitmap.
        /// </summary>
        /// <param name="source">Bitmap to change background.</param>
        /// <param name="color">Background color.</param>
        /// <param name="pixelFormat">Specifies the format of the color data for each pixel in the image.</param>
        /// <returns>Bitmap with the background changed.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var originalBitmap = (Bitmap)Bitmap.FromFile("polar-bear.png");
        /// var backgroundColor = Color.FromName("yellow");
        /// var backgroundBitmap = originalBitmap.SetBackgroundColor(backgroundColor);
        /// </code>
        /// </example>
        public static Bitmap SetBackgroundColor(this Bitmap source, Color color, PixelFormat pixelFormat = PixelFormat.Format32bppRgb)
        {
            Bitmap bitmap = new Bitmap(source.Width, source.Height, pixelFormat);
            bitmap.SetResolution(source.HorizontalResolution, source.VerticalResolution);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.Clear(color);
                g.DrawImage(source, Point.Empty);
                return bitmap;
            }
        }

        /// <summary>
        /// Convert a Bitmap into an array. Where the first dimension corresponds to the colors R, G and B.
        /// </summary>
        /// <param name="bitmap">Bitmap to transform.</param>
        /// <returns>RGB array corresponding to the Bitmap.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var image = (Bitmap)Bitmap.FromFile("polar-bear.png");
        /// var imageRGB = image.ToArrayRGB();
        /// </code>
        /// </example>
        public static int[,,] ToArrayRGB(this Bitmap bitmap)
        {
            var arrayRGB = new int[3, bitmap.Width, bitmap.Height];

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var pixel = bitmap.GetPixel(x, y);
                    arrayRGB[0, x, y] = pixel.R;
                    arrayRGB[1, x, y] = pixel.G;
                    arrayRGB[2, x, y] = pixel.B;
                }
            }

            return arrayRGB;
        }

        /// <summary>
        /// Convert a grayscale image array to Bitmap.
        /// </summary>
        /// <param name="image">Grayscale image array.</param>
        /// <returns>Grayscale Bitmap.</returns>
        public static Bitmap ToBitmap(this int[,] image)
        {
            var bitmap = new Bitmap(image.GetLength(0), image.GetLength(1));

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var pixel = Color.FromArgb(image[i, j], image[i, j], image[i, j]);
                    bitmap.SetPixel(i, j, pixel);
                }
            }

            return bitmap;
        }

        /// <summary>
        /// Convert a RGB array into a Bitmap.
        /// </summary>
        /// <param name="image">RGB array to transform. Where the first dimension corresponds to the color R, G and B.</param>
        /// <returns>Transformed Bitmap.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var image = (Bitmap)Bitmap.FromFile("polar-bear.png");
        /// var imageRGB = image.ToArrayRGB();
        /// var origImage = imaRGB.ToBitmap();
        /// </code>
        /// </example>
        public static Bitmap ToBitmap(this int[,,] image)
        {
            var bitmap = new Bitmap(image.GetLength(1), image.GetLength(2));

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var pixel = Color.FromArgb(image[0, i, j], image[1, i, j], image[2, i, j]);
                    bitmap.SetPixel(i, j, pixel);
                }
            }

            return bitmap;
        }
    }
}
