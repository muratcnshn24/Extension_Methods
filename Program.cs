using System;

namespace Extension_Methods
{

    public static class SrtingExtension
    {
        public static int KelimeSayisi(this string s) =>
            s.Split().Length;

    }


    class Program
    {
        static void Main(string[] args)
        {
            string s = "Merhaba Güzel Dünya";   //keilme yazdikca veya cıkardikca kelime sayisini veriyor.
            Console.WriteLine($"{s.KelimeSayisi()}");
        }
    }
}
