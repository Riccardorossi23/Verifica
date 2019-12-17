using System;

namespace main
{
    public class Veifica
    {
            public static void Media()
            {
            Console.WriteLine("inserisci a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci b:");
            int b = int.Parse(Console.ReadLine());
            double Media = (a + b) / 2;
            Console.WriteLine(Media);
            }
}
