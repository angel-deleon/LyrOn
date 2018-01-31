using System;
using System.IO;

namespace LyrOn.Classes
{
    public class Song
    {
        private string name;
        private string artist;
        private string album;
        private Uri artWork;
        private string lyrics;

        public Song(string name, string artist, string album, Uri artWork, string lyrics)
        {
            this.name = name;
            this.artist = artist;
            this.album = album;
            this.artWork = artWork;
            this.lyrics = lyrics;
        }

        public Song(GetLyricResult result) {
            this.name = result.lyricSong;
            this.artist = result.lyricArtist;
            this.album = result.lyricArtist;
            this.artWork = new Uri(result.lyricCovertArtUrl);
            this.lyrics = result.lyric;
        }

        public string Name 
        { 
            get 
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }

        public string Artist 
        { 
            get 
            {
                return artist;
            }
            set 
            {
                artist = value;
            }
        }

        public string Album
        { 
            get 
            {
                return album;
            }
            set 
            {
                album = value;
            }
        }

        public Uri ArtWork 
        {
            get 
            {
                return artWork;
            }
            set 
            {
                artWork = value;
            }
        }

        public string Lyrics 
        {
            get 
            {
                return lyrics;
            }
            set 
            {
                lyrics = value;
            }
        }

        private string getFirstLyricsLines(int count) {
            StringReader stringReader = new StringReader(lyrics);
            string firstLines = "", line;
            int index = 0;
            while (index++ < count && (line = stringReader.ReadLine()) != null) 
            {
                if (firstLines.Length != 0) 
                {
                    firstLines += Environment.NewLine;
                }
                firstLines += line;
            }
            return firstLines;
        }

        public override string ToString()
        {
            return string.Format("[Song: name={0}, artist={1}, album={2}, artWork={3}]{4}[lyrics={5}]", 
                                 name, artist, album, artWork, 
                                 Environment.NewLine, 
                                 getFirstLyricsLines(5));
        }

    }
}
