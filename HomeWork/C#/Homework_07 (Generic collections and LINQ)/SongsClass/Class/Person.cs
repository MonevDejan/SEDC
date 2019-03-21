using System;
using System.Collections.Generic;
using SongsClass.Enum;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsClass.Class
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public MusicGenre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(long id, string firstName, string lastName, byte age, MusicGenre genere)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = genere;
            FavoriteSongs = new List<Song> ();

            
        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine($"The person {FirstName} hates music") ;
            }
            else
            {
                foreach (Song song in FavoriteSongs)
                {
                    Console.WriteLine($"{song.Title}" );
                }

            }
        } 
    }
}
