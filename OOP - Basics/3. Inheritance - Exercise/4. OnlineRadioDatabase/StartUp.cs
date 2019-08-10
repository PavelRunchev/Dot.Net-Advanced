using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace OnlineRadioDatabase
{
    class StartUp
    {
        static void Main()
        {
            List<Song> playList = new List<Song>();
            int amountSongs = int.Parse(Console.ReadLine());
            for (int i = 0; i < amountSongs; i++)
            {
                try
                {
                    string[] inputSong = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

                    if(inputSong.Length < 3 || inputSong.Length > 3)
                        throw new ArgumentException("Invalid song.");
                   
                    string artistName = inputSong[0];
                    string songName = inputSong[1];
                    string[] length = inputSong[2].Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

                    Song song = new Song(artistName, songName);
                    //check for valid formar!
                    song.ValidLength(length);
                    Console.WriteLine(song.AddTimeLength(length[0], length[1]));
                    playList.Add(song);
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }             
            }

            Console.WriteLine($"Songs added: {playList.Count}");            
            TimeSpan totalTime = new TimeSpan(playList.Sum(t => t.Time.Ticks));
            Console.WriteLine($"Playlist length: {totalTime.Hours}h {totalTime.Minutes}m {totalTime.Seconds}s");                       
        }
    }
}
