using System;
using System.Globalization;
using System.Threading;

namespace konzolos_formazott_adatakiiras
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *          -- NUMERIKUS --
             *          
             * A kiirando adat karakterszélességét az azonosító után írhatjuk vesszővel elválasztva
             * Ha pozitív értéket adtunk meg, az adatot ebben a szélességben jobbra igazítva írja, 
             *  ha negatív értéket adunk meg, akkor balra igazítja,
             * 
             */
            string[] names = { "Adam", "Bridgette", "Carla", "Daniel", "Ebenezer", "Francine", "George" };
            decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80, 16.75m };

            Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
            for (int ctr = 0; ctr < names.Length; ctr++)
                Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);

            Console.WriteLine("\n\nDátumok\n_______");
            DateTime date = DateTime.Today;
            Console.WriteLine("D => {0:D}", date);
            Console.WriteLine("d => {0:d}", date);
            Console.WriteLine("F => {0:F}", date);
            Console.WriteLine("f => {0:f}", date);
            Console.WriteLine("G => {0:G}", date);
            Console.WriteLine("g => {0:g}", date);

            /*
             *          -- Pénzügyi és egyéb nemzeti --
             *          
             *  using System.Globalization;!!!
             */
            string[] cultureNames = { "en-US", "fr-FR", "hu-HU", "de-DE" };
            Decimal value = 1043.17m;


            Console.OutputEncoding = System.Text.Encoding.UTF8;
            foreach (var culture in cultureNames)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture);
                Console.WriteLine("The current culture is {0}", Thread.CurrentThread.CurrentCulture.Name);
                Console.WriteLine(CultureInfo.CurrentCulture.DisplayName);
                Console.WriteLine(value.ToString("C2"));
                Console.WriteLine("D => {0:D}", date);
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
