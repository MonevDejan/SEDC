using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongsClass.Class;
using SongsClass.Enum;

namespace FavoriteSongs
{
    //Task
    #region
    /*
       Task 1
        Create a class Song with the following properties: Title, Length and, MusicGenre
        MusicGenre is enum with - Rock, Hip_Hop, Techno and Classical
        Create a class Person with the following properties: Id, FirstName, LastName, Age, FavoriteMusicType (MusicGenre enum) and FavoriteSongs
        FavoriteSongs is a list of Songs
        Create a method called GetFavSongs() that will print out all the titles of their favorite songs or write a message that this person hates music if there are no favorite songs in their list

        Task 2
        Select the person Jerry and add all the songs which start with the letter B
        Select the person Maria and add all the songs with length longer than 6 mins
        Select the person Jane and add all the songs that are of MusicGenre Rock
        Select the person Stefan and add all songs shorter than 3 mins and of MusicGenre Hip-Hop
        Select all persons from the persons array that have 4 or more songs

    */


    #endregion


    class Program
    {
        static void Main()
        {
            Song fisrtSong = new Song("What I must do", 255, MusicGenre.Hip_Hop);
            Song secondSong = new Song("Nevermind", 192, MusicGenre.Techno);

            List < Song > goodSongs = new List<Song>() { fisrtSong, secondSong };
            

            Person dejan = new Person(1, "Dejan", "Monev", 28, MusicGenre.Classical);
            Person trajce = new Person(2, "Trajce", "Manev", 42, MusicGenre.Hip_Hop);

            dejan.FavoriteSongs = goodSongs;
            dejan.GetFavSongs();
            trajce.GetFavSongs();
            Console.WriteLine("_________________________________________________________");

            List<Person> FansArray = new List<Person>();

            //fans
            Person Jerry = new Person(1,"Jerry", "Tompson", 78, MusicGenre.Rock);
            Person Stefan = new Person(2,"Stefan", "Stefanoski", 28, MusicGenre.Techno);
            Person Maria = new Person(3,"Maria", "Campbel", 43, MusicGenre.Classical);
            Person Jane = new Person(4,"Jane", "Doe", 28, MusicGenre.Techno);

            //songs
            Song song1 = new Song("Bohemian Rhapsody", 367, MusicGenre.Rock);
            Song song2 = new Song("Stairway To Heaven", 480, MusicGenre.Rock);
            Song song3 = new Song("Riders On The Storm", 430, MusicGenre.Rock);
            Song song4 = new Song("Not Fade Away", 108, MusicGenre.Rock);
            Song song5 = new Song("Breaking Glass", 111, MusicGenre.Rock);
            Song song6 = new Song("Welcome To The Jungle", 275, MusicGenre.Rock);
            Song song7 = new Song("Walk Of Life", 266, MusicGenre.Rock);
            Song song8 = new Song("Smoke on the Water", 340, MusicGenre.Rock);
            Song song9 = new Song("93 'til Infinity", 209, MusicGenre.Techno);
            Song song10 = new Song("Fight the Power", 321, MusicGenre.Techno);
            Song song11 = new Song("The Message", 363, MusicGenre.Techno);
            Song song12 = new Song("Butterfly Effect", 213, MusicGenre.Techno);
            Song song13 = new Song("No Fear", 182, MusicGenre.Techno);
            Song song14 = new Song("Hereditary", 340, MusicGenre.Techno);
            Song song15 = new Song("Bounce Back", 226, MusicGenre.Techno);
            Song song16 = new Song("The Four Seasons", 2520, MusicGenre.Classical);
            Song song17 = new Song("Canon in D major", 376, MusicGenre.Classical);
            Song song18 = new Song("Swan Lake", 461, MusicGenre.Classical);
            Song song19 = new Song("Symphony No. 5", 425, MusicGenre.Classical);
            Song song20 = new Song("Ride of the Valkyries", 608, MusicGenre.Classical);
            Song song21 = new Song("The Magic Flute", 458, MusicGenre.Classical);
            Song song22 = new Song("Carmen Suite No.1", 721, MusicGenre.Classical);
            Song song23 = new Song("Planet E", 420, MusicGenre.Techno);
            Song song24 = new Song("Phasor", 368, MusicGenre.Techno);
            Song song25 = new Song("Counting Comets", 242, MusicGenre.Techno);
            Song song26 = new Song("Cold Summer", 358, MusicGenre.Techno);
            Song song27 = new Song("Destroyer", 359, MusicGenre.Techno);
            Song song28 = new Song("Phalanx", 307, MusicGenre.Techno);
            Song song29 = new Song("Vision", 693, MusicGenre.Techno);
            Song song30 = new Song("Chain Reaction", 181, MusicGenre.Techno);

            List<Song> songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
                                    song8, song9, song10, song11, song12, song13, song14,
                                    song15, song16, song17, song18, song19, song20,
                                    song21, song22, song23, song24, song25, song26, song27, song28, song29, song30 };

            FansArray.Add(Jerry);
            FansArray.Add(Stefan);
            FansArray.Add(Maria);
            FansArray.Add(Jane);

            
            Jerry.FavoriteSongs = songs.Where(x => x.Title.ElementAt(0) == 'B').ToList();
            Jerry.GetFavSongs();

            Console.WriteLine("_________________________________________________________");
            Maria.FavoriteSongs = songs.Where(x => x.Length > 360).ToList();
            Maria.GetFavSongs();

            Console.WriteLine("_________________________________________________________");
            Jane.FavoriteSongs = songs.Where(x => x.Genere == MusicGenre.Rock).ToList();
            Jane.GetFavSongs();

            Console.WriteLine("_________________________________________________________");
            Stefan.FavoriteSongs = songs.Where(x => x.Length < 180).Where(x => x.Genere == MusicGenre.Hip_Hop).ToList();
            Stefan.GetFavSongs();

            Console.WriteLine("_________________________________________________________");
            List<Person> PersonWth4orMoreSongs = FansArray.Where(x => x.FavoriteSongs.Count >= 4).ToList();

            foreach (Person person in PersonWth4orMoreSongs)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }
}
