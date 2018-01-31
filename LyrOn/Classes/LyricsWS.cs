using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LyrOn.Classes
{
    public class LyricsWS
    {

        private static string urlServiceBase = "http://api.chartlyrics.com/apiv1.asmx";
        private static string searchLyric = urlServiceBase + "/SearchLyric";
        private static string searchLyricText = urlServiceBase + "/SearchLyricText";
        private static string getLyric = urlServiceBase + "/GetLyric";

        private string buildSearchString(string artist, string song) {
            string url = searchLyric + "?artist=" + artist + "&song=" + song;
            return url;
        }

        private string buildSearchString(string text) {
            string url = searchLyricText + "?lyricText" + text;
            return url;
        }

        private string buildGetString(string lyricId, string lyricCheckSum) {
            string url = getLyric + "?lyricId" + lyricId + "&lyricCheckSum" + lyricCheckSum;
            return url;
        }

        public async Task<List<SearchLyricResult>> ListSongsByArtistAndName(string artist, string song) {
            List<SearchLyricResult> list = new List<SearchLyricResult>();
            if (NetworkCheck.IsInternet()) {
                Uri geturi = new Uri(buildSearchString(artist, song));
                HttpClient client = new HttpClient();
                HttpResponseMessage responseGet = await client.GetAsync(geturi);
                string response = await responseGet.Content.ReadAsStringAsync();

                // Parseo del XML
                XDocument doc = XDocument.Parse(response);
                foreach(var item in doc.Descendants("SearchLyricResult")) {
                    SearchLyricResult result = new SearchLyricResult();
                    result.trackId = item.Element("TrackId").Value.ToString();
                    result.lyricChecksum = item.Element("LyricChecksum").Value.ToString();
                    result.lyricId = item.Element("LyricId").Value.ToString();
                    result.songUrl = item.Element("SongUrl").Value.ToString();
                    result.artistUrl = item.Element("ArtistUrl").Value.ToString();
                    result.artist = item.Element("Artist").Value.ToString();
                    result.song = item.Element("Song").Value.ToString();
                    result.songRank = item.Element("SongRank").Value.ToString();
                    list.Add(result);
                }
            }
            return list;
        }

        public async Task<List<SearchLyricResult>> ListSongsByText(string text)
        {
            List<SearchLyricResult> list = new List<SearchLyricResult>();
            if (NetworkCheck.IsInternet())
            {
                Uri geturi = new Uri(buildSearchString(text));
                HttpClient client = new HttpClient();
                HttpResponseMessage responseGet = await client.GetAsync(geturi);
                string response = await responseGet.Content.ReadAsStringAsync();

                // Parseo del XML
                XDocument doc = XDocument.Parse(response);
                foreach (var item in doc.Descendants("SearchLyricResult"))
                {
                    SearchLyricResult result = new SearchLyricResult();
                    result.trackId = item.Element("TrackId").Value.ToString();
                    result.lyricChecksum = item.Element("LyricChecksum").Value.ToString();
                    result.lyricId = item.Element("LyricId").Value.ToString();
                    result.songUrl = item.Element("SongUrl").Value.ToString();
                    result.artistUrl = item.Element("ArtistUrl").Value.ToString();
                    result.artist = item.Element("Artist").Value.ToString();
                    result.song = item.Element("Song").Value.ToString();
                    result.songRank = item.Element("SongRank").Value.ToString();
                    list.Add(result);
                }
            }
            return list;
        }

        public async Task<GetLyricResult> GetSong(string lyricId, string lyricCheckSum) {
            GetLyricResult result = new GetLyricResult();
            if (NetworkCheck.IsInternet())
            {
                Uri geturi = new Uri(buildGetString(lyricId, lyricCheckSum));
                HttpClient client = new HttpClient();
                HttpResponseMessage responseGet = await client.GetAsync(geturi);
                string response = await responseGet.Content.ReadAsStringAsync();

                // Parseo del XML
                XDocument doc = XDocument.Parse(response);
                var item = doc.Element("GetLyricResult");
                result.trackId = item.Element("TrackId").Value.ToString();
                result.lyricChecksum = item.Element("LyricChecksum").Value.ToString();
                result.lyricId = item.Element("LyricId").Value.ToString();
                result.lyricSong = item.Element("LyricSong").Value.ToString();
                result.lyricArtist = item.Element("LyricArtist").Value.ToString();
                result.lyricUrl = item.Element("LyricUrl").Value.ToString();
                result.lyricCovertArtUrl = item.Element("LyricCovertArtUrl").Value.ToString();
                result.lyricRank = item.Element("LyricRank").Value.ToString();
                result.lyricCorrectUrl = item.Element("LyricCorrectUrl").Value.ToString();
                result.lyric = item.Element("Lyric").Value.ToString();
            }
            return result;
        }

    }
}
