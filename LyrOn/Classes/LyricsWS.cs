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
            string url = searchLyricText + "?lyricText=" + text;
            return url;
        }

        private string buildGetString(string lyricId, string lyricCheckSum) {
            string url = getLyric + "?lyricId=" + lyricId + "&lyricCheckSum=" + lyricCheckSum;
            return url;
        }

        private List<SearchLyricResult> parseXmlSearchResult(string xml) {
            XDocument doc = XDocument.Parse(xml);
            XNamespace ns = "http://api.chartlyrics.com/";
            List<SearchLyricResult> list = new List<SearchLyricResult>();
            foreach(var child in doc.Descendants(ns + "SearchLyricResult")) {
                if  (child.Element(ns + "TrackId") != null) {
                    SearchLyricResult result = new SearchLyricResult();
                    result.trackId = child.Element(ns + "TrackId").Value.ToString();
                    result.lyricChecksum = child.Element(ns + "LyricChecksum").Value.ToString();
                    result.lyricId = child.Element(ns + "LyricId").Value.ToString();
                    result.songUrl = child.Element(ns + "SongUrl").Value.ToString();
                    result.artistUrl = child.Element(ns + "ArtistUrl").Value.ToString();
                    result.artist = child.Element(ns + "Artist").Value.ToString();
                    result.song = child.Element(ns + "Song").Value.ToString();
                    result.songRank = child.Element(ns + "SongRank").Value.ToString();
                    list.Add(result);
                }
            }
            return list;
        }

        private GetLyricResult parseXmlLyricResult(string xml) {
            XDocument doc = XDocument.Parse(xml);
            XNamespace ns = "http://api.chartlyrics.com/";
            GetLyricResult result = new GetLyricResult();
            var item = doc.Element(ns + "GetLyricResult");
            if (item.Element(ns + "TrackId") != null) {
                result.trackId = item.Element(ns + "TrackId").Value.ToString();
                result.lyricChecksum = item.Element(ns + "LyricChecksum").Value.ToString();
                result.lyricId = item.Element(ns + "LyricId").Value.ToString();
                result.lyricSong = item.Element(ns + "LyricSong").Value.ToString();
                result.lyricArtist = item.Element(ns + "LyricArtist").Value.ToString();
                result.lyricUrl = item.Element(ns + "LyricUrl").Value.ToString();
                result.lyricCovertArtUrl = item.Element(ns + "LyricCovertArtUrl").Value.ToString();
                result.lyricRank = item.Element(ns + "LyricRank").Value.ToString();
                result.lyricCorrectUrl = item.Element(ns + "LyricCorrectUrl").Value.ToString();
                result.lyric = item.Element(ns + "Lyric").Value.ToString();
            }
            return result;
        }

        private async Task<string> CallRestWS(Uri geturi) {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseGet = await client.GetAsync(geturi);
            string response = await responseGet.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<List<SearchLyricResult>> ListSongs(string artist, string song) {
            // armar la uri del método get
            Uri geturi = new Uri(buildSearchString(artist, song));
            // ejecutar la llamada
            string response = await CallRestWS(geturi);
            // Parseo del XML
            return parseXmlSearchResult(response);
        }

        public async Task<List<SearchLyricResult>> ListSongs(string text)
        {
            // armar la uri del método get
            Uri geturi = new Uri(buildSearchString(text));
            // ejecutar la llamada
            string response = await CallRestWS(geturi);
            // Parseo del XML
            return parseXmlSearchResult(response);
        }

        public async Task<GetLyricResult> GetSong(string lyricId, string lyricCheckSum) {
            // armar la uri del método get
            Uri geturi = new Uri(buildGetString(lyricId, lyricCheckSum));
            // ejecutar la llamada
            string response = await CallRestWS(geturi);
            // Parseo del XML
            return parseXmlLyricResult(response);
        }

    }
}
