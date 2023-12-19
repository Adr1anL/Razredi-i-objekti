using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeogradskiNeboderi beogradskiNeboderi = new BeogradskiNeboderi(200, 100);

            Console.WriteLine(beogradskiNeboderi.ToString());

            Console.ReadKey();
        }
    }
}
