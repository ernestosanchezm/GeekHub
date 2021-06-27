using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GeekHub.Helpers
{
    public static class ConvertHelper
    {
        public static Bitmap ToBitmap(string pathImg,string nameImg,string extension) {
            try
            {
                string imageUrl = pathImg + "/" + nameImg+"."+extension;
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(imageUrl);
                Bitmap bitmap;
                bitmap = new Bitmap(stream);
                return bitmap;
            } 
            catch { return null; }
         
        }
    }
}
