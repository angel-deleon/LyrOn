using System;
namespace LyrOn.Classes
{
    public class SearchLyricResult
    {
        public string trackId { get; set; }
        public string lyricChecksum { get; set; }
        public string lyricId { get; set; }
        public string songUrl { get; set; }
        public string artistUrl { get; set; }
        public string artist { get; set; }
        public string song { get; set; }
        public string songRank { get; set; }
    }
}
