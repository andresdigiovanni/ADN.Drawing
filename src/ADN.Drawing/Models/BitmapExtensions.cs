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
        /// Resize a Bitmap.
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
        /// var resizedBitmap = originalBitmap.Resize(width, height);
        /// </code>
        /// </example>
        public static Bitmap Resize(this Bitmap bitmap, int width, int height, PixelFormat pixelFormat = PixelFormat.Format32bppRgb)
        {
            Bitmap temp = new Bitmap(width, height, pixelFormat);
            temp.SetResolution(bitmap.HorizontalResolution, bitmap.VerticalResolution);
            Graphics g = Graphics.FromImage(temp);
            g.DrawImage(bitmap, 0, 0, width, height);

            return temp;
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
        /// <param name="bitmap">Bitmap to change background.</param>
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
        public static Bitmap SetBackgroundColor(this Bitmap bitmap, Color color, PixelFormat pixelFormat = PixelFormat.Format32bppRgb)
        {
            Bitmap temp = new Bitmap(bitmap.Width, bitmap.Height, pixelFormat);
            temp.SetResolution(bitmap.HorizontalResolution, bitmap.VerticalResolution);
            Graphics g = Graphics.FromImage(temp);
            g.Clear(color);
            g.DrawImage(bitmap, Point.Empty);

            return temp;
        }
    }
}
