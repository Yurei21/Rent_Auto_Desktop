using System;
using System.Drawing;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace Car_Rental_System
{
    public class BarcodeGenerator
    {
        public static int GenerateRandomBarcode()
        {
            Random rand = new Random();
            return rand.Next(100000000, 999999999);
        }

        public static Bitmap GenerateBarcode(string text, int width = 300, int height = 100)
        {
            try
            {
                BarcodeWriter<Bitmap> writer = new BarcodeWriter<Bitmap>
                {
                    Format = BarcodeFormat.CODE_128,
                    Options = new EncodingOptions
                    {
                        Width = width,
                        Height = height,
                        Margin = 10
                    }
                };

                return writer.Write(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating barcode: {ex.Message}");
                return null;
            }
        }
    }
}
