using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
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
            n = int.Parse(Console.ReadLine());
            if (n != 0)
                c++;
        } while (n != 0);
        return c;
    }
    //esercizio5
    public static int Somma(int n)
    {
        if (n == 0)
            return 0;
        return Somma(n - 1) + n;
    }
    //esercizio6
    public static double Calcolatrice(double a,double b,char op)
    {
        double ris;
        switch (op)
        {
            case '+': ris = a + b;break;
            case '-': ris = a - b; break;
            case '*': ris = a * b; break;
            case '/': ris = a / b; break;
            default:
                throw new Exception("operazione non valida");

        }
        return ris;
    }
    //esercizio7
    public static void Operazioni()
    {
        char op;
        do
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            op = Console.ReadLine()(0);
            if (op != 'q')
            {
                double ris = Calcolatrice(a, b, op);
                Console.WriteLine(ris);
            }
            while (op != 'q')
            }
        }
    }
    //esercizio8
    public static double sconto(int quantità,double prezzo,double iva)
    {
        double totale = prezzo * quantità;
        double sconto;
        if (totale > 100)
            sconto = 0.15;
        else if (quantità >= 30)
            sconto = 0.10;
        totale;= totale-totale * sconto;
        totale += totale + iva;
        return totale


    }
    //esercizio 9
    public static void StampaFibonacci(int n)
    {
        for (int i = 0; i <= n; i++)
            Console.WriteLine(fibonacci(i) + "");
        Console.WriteLine();
    }
    private static int fibonacci(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return fibonacci(n - 2) + fibonacci(n - 1);
    }
}
