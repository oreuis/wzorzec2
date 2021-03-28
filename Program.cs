using System;

namespace Wzorzec_2
{
    abstract class Albumy
    {

        protected String info;

        public abstract Albumy tworzAlbum();

        protected void AlbumCD()
        {
            Console.WriteLine("Jest płyta CD.");
        }
    }

    class Svt : Albumy
    {
        public Svt()
        {
            info = "Seventeen";
        }

        public void AlbumPC()
        {
            Console.WriteLine("Jest Photocard.");
        }

        public void AlbumWK()
        {
            Console.WriteLine("Jest weaving kit.");
        }

        public void AlbumPoster()
        {
            Console.WriteLine("Jest plakat.");
        }


        public override Albumy tworzAlbum()
        {
            Console.WriteLine(info);
            AlbumCD();
            AlbumPC();
            AlbumWK();
            AlbumPoster();
            return this;
        }
    }

    class Nst : Albumy
    {
        public Nst()
        {
            info = "Nu'est";
        }

        public void AlbumPoster()
        {
            Console.WriteLine("Jest plakat.");
        }

        public void AlbumMC()
        {
            Console.WriteLine("Jest minicard.");
        }


        public override Albumy tworzAlbum()
        {
            Console.WriteLine(info);
            AlbumCD();
            AlbumPoster();
            AlbumMC();
            return this;
        }
    }

    class Pristin : Albumy
    {
        public Pristin()
        {
            info = "Pristin";
        }

        public void AlbumSticker()
        {
            Console.WriteLine("Jest naklejka.");
        }

        public override Albumy tworzAlbum()
        {
            Console.WriteLine(info);
            AlbumCD();
            AlbumSticker();
            return this;
        }
    }

    class Pledis
    {
        public Albumy produkcjaCzekolady(String about)
        {
            Albumy album = null;

            if (about.Equals("Seventeen"))
            {
                album = new Svt();
            }
            else if (about.Equals("Nu'est"))
            {
                album = new Nst();
            }
            else if (about.Equals("Pristin"))
            {
                album = new Pristin();
            }
            return album.tworzAlbum();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pledis pledisent = new Pledis();
            Albumy[] tab = new Albumy[3];

            tab[0] = pledisent.produkcjaCzekolady("Seventeen");
            tab[1] = pledisent.produkcjaCzekolady("Nu'est");
            tab[2] = pledisent.produkcjaCzekolady("Pristin");
            Console.ReadLine();
        }
    }
}