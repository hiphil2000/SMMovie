using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SM_Movie.Utils
{
    class ImgurUtil
    {
        string clientId = "fac816a4e48478f";
        string clientSecret = "28ea31931180baa835054a7f32ff58055fff1565";

        public string uploadToImgur(byte[] imageData)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Set("Authorization", "Client-ID " + clientId);

                System.Collections.Specialized.NameValueCollection reqparm = new System.Collections.Specialized.NameValueCollection();
                reqparm.Add("image", Convert.ToBase64String(imageData));
                reqparm.Add("type", "base64");
                byte[] responsebytes = client.UploadValues("https://api.imgur.com/3/image", "POST", reqparm);
                string responsebody = Encoding.UTF8.GetString(responsebytes);
                JObject response = JObject.Parse(responsebody);
                return response["data"]["link"].ToString();
            }
        }
    }
}
