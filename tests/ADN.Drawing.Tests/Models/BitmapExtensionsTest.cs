using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ADN.Drawing.Tests
{
    public class BitmapExtensionsTest
    {
        [Theory]
        [InlineData("polar-bear-640-423.jpg", "polar-bear-crop.jpg", 250, 200, 250, 100)]
        public void CropImage(string origImgFile, string expectedImgFile, int width, int height, int x, int y)
        {
            var origImg = (Bitmap)Bitmap.FromFile(Path.Combine("assets", origImgFile));
            var expectedImg = (Bitmap)Bitmap.FromFile(Path.Combine("assets", expectedImgFile));

            var rectangle = new Rectangle(new Point(x, y), new Size(width, height));
            var resultImg = origImg.CropImage(rectangle);

            var expectedBytesImg = ImageToBytes(expectedImg, ImageFormat.Jpeg);
            var resultBytesImg = ImageToBytes(resultImg, ImageFormat.Jpeg);
            Assert.Equal(expectedBytesImg, resultBytesImg);
        }

        [Theory]
        [InlineData("polar-bear-640-423.jpg", "polar-bear-320x212.jpg", 320, 212)]
        public void Resize(string origImgFile, string expectedImgFile, int width, int height)
        {
            var origImg = (Bitmap)Bitmap.FromFile(Path.Combine("assets", origImgFile));
            var expectedImg = (Bitmap)Bitmap.FromFile(Path.Combine("assets", expectedImgFile));

            var resultImg = origImg.Resize(width, height);

            var expectedBytesImg = ImageToBytes(expectedImg, ImageFormat.Jpeg);
            var resultBytesImg = ImageToBytes(resultImg, ImageFormat.Jpeg);
            Assert.Equal(expectedBytesImg, resultBytesImg);
        }

        [Theory]
        [InlineData("polar-bear-640-423.jpg", "polar-bear-resized-canvas-320x212.jpg", 320, 212)]
        public void ResizeCanvas(string origImgFile, string expectedImgFile, int width, int height)
        {
            var origImg = (Bitmap)Bitmap.FromFile(Path.Combine("assets", origImgFile));
            var expectedImg = (Bitmap)Bitmap.FromFile(Path.Combine("assets", expectedImgFile));

            var resultImg = origImg.ResizeCanvas(width, height);

            var expectedBytesImg = ImageToBytes(expectedImg, ImageFormat.Jpeg);
            var resultBytesImg = ImageToBytes(resultImg, ImageFormat.Jpeg);
            Assert.Equal(expectedBytesImg, resultBytesImg);
        }

        [Theory]
        [InlineData("polar-bear-2.png", "polar-bear-2-yellow.png", "yellow")]
        public void SetBackgroundColor(string origImgFile, string expectedImgFile, string colorName)
        {
            var origImg = (Bitmap)Bitmap.FromFile(Path.Combine("assets", origImgFile));
            var expectedImg = (Bitmap)Bitmap.FromFile(Path.Combine("assets", expectedImgFile));

            var resultImg = origImg.SetBackgroundColor(Color.FromName(colorName));

            var expectedBytesImg = ImageToBytes(expectedImg, ImageFormat.Png);
            var resultBytesImg = ImageToBytes(resultImg, ImageFormat.Png);
            Assert.Equal(expectedBytesImg, resultBytesImg);
        }

        private static byte[] ImageToBytes(Bitmap bitmap, ImageFormat imageFormat)
        {
            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, imageFormat);

            return stream.GetBuffer();
        }
    }
}
