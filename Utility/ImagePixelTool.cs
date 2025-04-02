using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Utility.ImageTools;

namespace Utility
{
    internal static class ImagePixelTool
    {
        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        [DllImport("user32.dll")]
        public static extern int InvalidateRect(IntPtr hwnd, IntPtr rect, int bErase);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        public static extern int DeleteDC(IntPtr hdc);

        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [DllImport("gdi32.dll")]
        public static extern int BitBlt(IntPtr hdcDst, int xDst, int yDst, int w, int h, IntPtr hdcSrc, int xSrc, int ySrc, int rop);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateDIBSection(IntPtr hdc, ref BITMAPINFO bmi, uint Usage, ref IntPtr bits, IntPtr hSection, uint dwOffset);
        public struct BITMAPINFO
        {
            public uint biSize;

            public int biWidth;

            public int biHeight;

            public short biPlanes;

            public short biBitCount;

            public uint biCompression;

            public uint biSizeImage;

            public int biXPelsPerMeter;

            public int biYPelsPerMeter;

            public uint biClrUsed;

            public uint biClrImportant;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public uint[] cols;
        }

        private static int SRCCOPY = 13369376;

        private static uint BI_RGB = 0u;

        private static uint DIB_RGB_COLORS = 0u;
        public static Bitmap ConverttoBPP_ColorRibbon(Bitmap b, int bpp)
        {
            if (bpp != 1 && bpp != 8)
            {
                throw new ArgumentException("1 or 8", "bpp");
            }

            int width = b.Width;
            int height = b.Height;
            IntPtr hbitmap = b.GetHbitmap();
            BITMAPINFO bmi = default(BITMAPINFO);
            bmi.biSize = 40u;
            bmi.biWidth = width;
            bmi.biHeight = height;
            bmi.biPlanes = 1;
            checked
            {
                bmi.biBitCount = (short)bpp;
                bmi.biCompression = BI_RGB;
                bmi.biSizeImage = (uint)Math.Round((double)(((width + 7) & -8) * height) / 8.0);
                bmi.biXPelsPerMeter = 1000000;
                bmi.biYPelsPerMeter = 1000000;
                uint num = (bmi.biClrImportant = (bmi.biClrUsed = unchecked((uint)(1 << bpp))));
                bmi.cols = new uint[256];
                if (bpp == 1)
                {
                    bmi.cols[0] = MAKERGB(0, 0, 0);
                    bmi.cols[1] = MAKERGB(255, 255, 255);
                }
                else
                {
                    int num2 = (int)(unchecked((long)num) - 1L);
                    for (int i = 0; i <= num2; i++)
                    {
                        bmi.cols[i] = MAKERGB(i, i, i);
                    }
                }

                IntPtr bits = default(IntPtr);
                IntPtr intPtr = CreateDIBSection(IntPtr.Zero, ref bmi, DIB_RGB_COLORS, ref bits, IntPtr.Zero, 0u);
                IntPtr dC = GetDC(IntPtr.Zero);
                IntPtr intPtr2 = CreateCompatibleDC(dC);
                SelectObject(intPtr2, hbitmap);
                IntPtr intPtr3 = CreateCompatibleDC(dC);
                SelectObject(intPtr3, intPtr);
                BitBlt(intPtr3, 0, 0, width, height, intPtr2, 0, 0, SRCCOPY);
                Bitmap result = Image.FromHbitmap(intPtr);
                DeleteDC(intPtr2);
                DeleteDC(intPtr3);
                ReleaseDC(IntPtr.Zero, dC);
                DeleteObject(hbitmap);
                DeleteObject(intPtr);
                return result;
            }
        }

        private static uint MAKERGB(int r, int g, int b)
        {
            return checked((uint)(b & 0xFF) | (uint)((r & 0xFF) << 8) | (uint)((g & 0xFF) << 16));
        }

    }
}
