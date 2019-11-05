using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    class VerificaRossi
    {
        public static void Max()
        {
            Console.WriteLine("inserisci il primo numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero");
            int b = int.Parse(Console.ReadLine());
            int max = Math.Max(a, b);
            Console.WriteLine(max);
        }
    
    }
    //esercizio2
    public static void Media()
    {
        Console.WriteLine("inserisci a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("inserisci b:");
        int b = int.Parse(Console.ReadLine());
        double Media = (a + b) / 2;
        Console.WriteLine(Media);
    }
    //esercizio3
    public static void Scambio(ref uint a,ref uint b)
    {
       var c = a;
        a = b;
        b = c;
    }
    //esercizio4
    public static int ContaNumeri()
    {
        int c = 0;
        int n;
        do
        {
            n = int.Parse(Console.ReadLine();
            if (n != 0)
                c++;
        } while (n != 0);
        return c;
    }
}
