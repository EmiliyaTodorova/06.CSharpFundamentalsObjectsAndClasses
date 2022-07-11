using System;
using System.Collections.Generic;

namespace _3.Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numbeOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for(int i = 0; i < numbeOfSongs; i++)
            {
                string[] tokens = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);
                string typeList = tokens[0];
                string name = tokens[1];    
                string time = tokens[2];

                Song newSong = new Song()
                {
                    Name = name,
                    Time = time,
                    TypeList = typeList,
                };
                songs.Add(newSong);

            }
            string command = Console.ReadLine();
            if (command == "all")
            {
                foreach(Song song in songs)
                {
                Console.WriteLine(song.Name);
                }
            } else
            {
                List<Song> filtredSongs = songs.FindAll(song => song.TypeList == command);
                foreach (Song song in filtredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            
        }
    }
}
