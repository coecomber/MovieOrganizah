using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;

namespace MovieOrganizer_2Leggo.Foto
{
    public class ImageLoader
    {
        public System.Drawing.Image LoadImageFromURL(string url)
        {
            System.Drawing.Image image;
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            using (var stream = response.GetResponseStream())
            {
                image = System.Drawing.Image.FromStream(stream);
            }
            return image;
        }
    }
}