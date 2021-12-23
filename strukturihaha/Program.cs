using System;
using System.Linq;
namespace strukturihaha
{
    class Program
    {
        struct Artist
        {
            public string Autor;
            public int Page;
            public int Tirazh;
            public DateTime Year;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сколько книг:");
            int k = int.Parse(Console.ReadLine());
            Artist[] artists = new Artist[k];
            for (int i = 0; i < artists.Length; i++)
            {
                Console.WriteLine("Введите имя автора:");
                artists[i].Autor = Console.ReadLine();
                Console.WriteLine("Количество страниц:");
                artists[i].Page = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите тираж:");
                artists[i].Tirazh = int.Parse(Console.ReadLine());
                Console.WriteLine("Год выпуска:");
                artists[i].Year = Convert.ToDateTime(Console.ReadLine());
            }
            foreach (Artist item in artists)
            {
                if (item.Page > 150)
                {
                    Console.WriteLine(item.Autor+", "+item.Page+", "+item.Tirazh+", "+item.Year);
                }
            }
        }
    }
}
