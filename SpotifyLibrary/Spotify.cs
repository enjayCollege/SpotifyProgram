using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using SpotifyAPI.Web.Models;

namespace SpotifyLibrary
{
    public class Spotify
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello");
        }

        public static async void Example()
        {
            SpotifyWebAPI api = new SpotifyWebAPI
            {
                AccessToken = "BQBd2F1mg89VXRW6A8cDsGl6sKOmkh6semAAA7mcN18SicdVKJnJcbTPuLP6uMoQW5H9WeqNxi15KMuydiomGpELG6H62MKGXwovcujcRPrAfOGtonfV82ZJfyhsGU8Bh2SRJfNY-0JjQTpKb9sewcy0ANtWqESK8iEkhdxi9P__NHaLk7PfudYaYaHB3_U2NvfoE0UJyS39YDLSAcp63C5f_X3PcMihzO7h8Xs3fMQXjMF-h7_O8baPozJfVQmVviibHs6KJzOarIBjYtykRtS4JjB7Q393syM",
                TokenType = "Bearer"
            };

            PrivateProfile profile = await api.GetPrivateProfileAsync();

            if (!profile.HasError())
            {
                Console.WriteLine(profile.DisplayName);
            }
            
        }
       
    }
}
