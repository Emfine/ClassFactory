using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;

namespace Iguana.Winform.Common
{
    public class GlobalSetting
    {
        public static float DefaultFontSize { get { return 9f; } }
        public static Font DefaultFont { get { return new Font("Microsoft YaHei", 9f); } }
        public static Color DefaultBackgroundColor { get { return Color.FromArgb(232, 255, 232); } }
        public static Color DefaultTitleColor { get { return Color.Turquoise; } }
        private static PrivateFontCollection picIconFontCollection = new PrivateFontCollection();
        public static PrivateFontCollection PicIconFontCollection
        {
            get
            {
                try
                {
                    if (picIconFontCollection != null && picIconFontCollection.Families.Length == 0)
                    {
                        var strPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Resources/fontawesome-webfont.ttf");
                        picIconFontCollection.AddFontFile(strPath);
                        var url = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Resources/ionicons.ttf");
                        picIconFontCollection.AddFontFile(url);
                    }
                    return picIconFontCollection;
                }
                catch
                {
                    return picIconFontCollection;
                }
            }
        }
    }
}