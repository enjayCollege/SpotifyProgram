using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web.Enums;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using SpotifyAPI.Web.Models;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth; 

namespace SpotifyLibrary
{
    public class Spotify
    {
        public const string MyAuth = "BQD85kIuk-wJQutvbd7nqu29KBarjJbFIkkpPV7_x7ZNoNKoKVC4NwEgdf7kh0Ieu-vQsLj8crZSm5nM4NlDTIVFUpMzHyDEW-6EOOPK7w6A3tcxIT7p8MwAP-OqE4kE_C1yqlGIawwI5R3YhNesyeKMF0o8nsISeBSxw55wdeO4Dkl3Ht6fcyYl-5SenZNchTSQrc5a6iq_hiOMJpMn30SkvxAueHVgezkRc5OsZ2EN5dPzjTJs2yMmmhaGCAIl-IKwfy_rZdCd1Nxd";

        public static void Welcome()
        {
            Console.WriteLine("-------- Welcome To Nathan's Playlist Generator ------- ");
        }

        public static async void ShowName()
        {
            
            //Console.WriteLine("Enter your OAuth Token: ");
            //string OAuthKey = Console.ReadLine().Trim();

            SpotifyWebAPI api = new SpotifyWebAPI
            {
                //access token needs to be up to date
                AccessToken = "BQD85kIuk-wJQutvbd7nqu29KBarjJbFIkkpPV7_x7ZNoNKoKVC4NwEgdf7kh0Ieu-vQsLj8crZSm5nM4NlDTIVFUpMzHyDEW-6EOOPK7w6A3tcxIT7p8MwAP-OqE4kE_C1yqlGIawwI5R3YhNesyeKMF0o8nsISeBSxw55wdeO4Dkl3Ht6fcyYl-5SenZNchTSQrc5a6iq_hiOMJpMn30SkvxAueHVgezkRc5OsZ2EN5dPzjTJs2yMmmhaGCAIl-IKwfy_rZdCd1Nxd",

                //const token type
                TokenType = "Bearer"
            };

            PrivateProfile profile = await api.GetPrivateProfileAsync();
           
            Console.WriteLine("\nThe account you have entered is called: "+profile.DisplayName);
            
        }

        private static SpotifyWebAPI _spotify;

        public static async void ShowTrack()
        {
            _spotify = new SpotifyWebAPI()
            {
                UseAuth = false,
            };

            FullTrack track = _spotify.GetTrack("3Hvu1pq89D4R0lyPBoujSv");
            Console.WriteLine($"Track name = {track}");

            //FullArtist artist = _spotify.GetArtist($"Artist = {"1KpCi9BOfviCVhmpI4G2sY"}");
            //Console.WriteLine(artist);

        }

    }
}
