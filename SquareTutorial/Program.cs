using System;
using System.Collections.Generic;
using System.Linq;
using SquareModel;

namespace ConsoleApp1Main
{
    class Program
    {
        private static List<Square> getArii()
        {

            Square patrat1 = new Square(1);
            Square patrat2 = new Square(2);
            Square patrat3 = new Square(3);
            Console.WriteLine("Enter square4 l: ");
            Square patrat4 = new Square(Int32.Parse(Console.ReadLine()));

            List<Square> lista = new List<Square>();
            lista.Add(patrat1);
            lista.Add(patrat2);
            lista.Add(patrat3);
            lista.Add(patrat4);

            return lista;
        }

        private static Boolean findArie(List<Square> lista, int arie)
        {
            //LINQ = Language Integrated Query
            var found = lista.FirstOrDefault(patrat => patrat.calcArie() == arie);
            if (found != null)
            {
                return true;
            }
            return false;
        }

        private static Boolean findLatura(List<Square> lista, int laturaToFind)
        {
            var found = from latura in lista
                        where laturaToFind is 3
                        select latura;
            if (laturaToFind == 3)
            {
                return true;
            }
            return false;
        }

        private static void tranzitColor()
        {
            Console.WriteLine("Color of square is " + Square.colorInfo);
            Square.transformColor();
            Console.WriteLine("Color of square changed to " + Square.colorInfo);
        }

        static void Main(string[] args)
        {
            int arieToFind = 16;
            int laturaToFind = 5;
            var list = getArii();
            foreach (Square patrat in list)
            {
                Console.WriteLine(patrat.calcArie());
            }
            tranzitColor();
            Console.WriteLine("Do we have a square with arie " + arieToFind + ": " + findArie(list, arieToFind));
            Console.WriteLine("Do we have a square with latura " + laturaToFind + ": " + findLatura(list, laturaToFind));
        }
    }
}
