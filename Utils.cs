using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_facturation_software
{
    internal static class Utils
    {
        public static void download_image(string url, string image_name)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFileAsync(new Uri(url), string.Format(@"C:\Users\isaia\Desktop\Development\University\5to-trimestre\restaurant-facturation-software\statics\{0}", image_name));
            }
        }
    }
}
