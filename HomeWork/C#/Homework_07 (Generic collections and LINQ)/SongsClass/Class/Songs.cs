using System;
using SongsClass.Enum;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsClass.Class
{
    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public MusicGenre Genere { get; set; }

        public Song(string title, int lenght, MusicGenre genere)
        {
            Title = title;
            Length = lenght;
            Genere = genere;
        }

    }
}
