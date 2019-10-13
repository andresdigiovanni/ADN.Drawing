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
        /// var resizedBitmap = originalBitmap.ResizeCanvas(width, height);
        /// </code>
        /// </example>
        public static Bitmap ResizeCanvas(this Bitmap source, int width, int height, PixelFormat pixelFormat = PixelFormat.Format32bppRgb)
        {
            Bitmap bitmap = new Bitmap(width, height, pixelFormat);
            bitmap.SetResolution(source.HorizontalResolution, source.VerticalResolution);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImageUnscaled(source, 0, 0, width, height);
                return bitmap;
            }
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
    }
}
