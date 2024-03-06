// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // instancier un object de la classe Rectangle
            Rectangle rec = new Rectangle(4.9f, 8.6f, "violet");
            Console.WriteLine(rec.Couleur);


            Console.ReadKey();
        }
    }
}
