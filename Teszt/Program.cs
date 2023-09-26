using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Példányosítom az osztályt
            Kor Teszt2 = new Kor(3.0);
            Teszt2.setKerulet(Teszt2.getSugar());
            Teszt2.setTerulet();
            Console.WriteLine("A {0} sugarú kör kerülete : {1}, terulete : {2}" ,Teszt2.getSugar(), Teszt2.getKerulet(), Teszt2.getTerulet());
            Console.ReadKey();
        }
    }
}
