using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OnlineRadioDatabase
{
    internal class Song
    {
        private string artistName;
        private string songName;
        private bool invalidSong;
        private TimeSpan time;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName)
        {
            this.ArtistName = artistName;
            this.SongName = songName;   
            this.InvalidSong = true;
        }

        internal string ArtistName
        {
            get => artistName;
            set
            {
                if (value.Length < 3 || value.Length > 20)
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");

                artistName = value;
            }
        }

        internal string SongName
        {
            get => songName;
            set
            {
                if (value.Length < 3 || value.Length > 30)
                    throw new ArgumentException("Song name should be between 3 and 30 symbols.");

                songName = value;
            }
        }

        internal int Minutes
        {
            get => minutes;
            set
            {
                if(value < 0 || value > 14)
                    throw new ArgumentException("Song minutes should be between 0 and 14.");

                minutes = value;
            }
        }

        internal int Seconds
        {
            get => seconds;
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Song seconds should be between 0 and 59.");

                seconds = value;
            }
        }

        internal bool InvalidSong
        {
            get => invalidSong;
            set => invalidSong = value;
        }

        internal TimeSpan Time
        {
            get => time;
        }

        public string AddTimeLength(string minutes, string seconds)
        {
            TimeSpan minTime = TimeSpan.Parse("00:00:00");
            TimeSpan maxTime = TimeSpan.Parse("00:14:59");

            this.Minutes = int.Parse(minutes);
            this.Seconds = int.Parse(seconds);

            TimeSpan time = TimeSpan.Parse($"00:{minutes}:{seconds}");
            if (time < minTime || time > maxTime)
                throw new ArgumentException("Invalid song length.");

            this.time = time;

            return "Song added.";
        }

        public void ValidLength(string[] inputLength)
        {
            if (inputLength.Length < 2 || inputLength.Length > 2)
                throw new ArgumentException("Invalid song length.");

            if(inputLength.Any(a => a.Any(e => !char.IsDigit(e))))
                throw new ArgumentException("Invalid song length.");
        }
    }
}
