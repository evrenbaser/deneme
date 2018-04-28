using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(yashesapla(1980));
            Console.WriteLine(yashesapla(DateTime.Now.Year-10));
           
            Console.ReadKey();
        }

        //static int değer döndüren datetime formatında parametre alan bir metot 
        static int yashesapla(DateTime tarih)
        {
            int sonuc;
            int dogumyili = tarih.Year;
            sonuc = DateTime.Now.Year - dogumyili;
            return sonuc;
        }
        static int yashesapla(int yil)
        {
            int sonuc;
            sonuc = DateTime.Now.Year - yil;
            return sonuc;
        }
    }
}
