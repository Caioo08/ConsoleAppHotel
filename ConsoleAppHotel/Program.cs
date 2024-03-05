using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor da diária: ");
            double diaria = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de adultos: ");
            int n_adul = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de crianças: ");
            int n_cria = int.Parse(Console.ReadLine());

            double v_dia = (diaria * n_adul) + (diaria * (n_cria * 0.5));

            Console.WriteLine("O valor da diária será: " + v_dia.ToString("C"));
            Console.Write("Informe o número de dias: ");
            int v_bruto = int.Parse(Console.ReadLine());

            double v_total = v_bruto * v_dia;

            Console.WriteLine("O valor total será: " + v_total.ToString("C"));

            Console.Write("Informe o número de parcelas: ");
            int n_par = int.Parse(Console.ReadLine());

            double total = v_total / n_par;

            Console.Write("O valor de cada parcela será: "+ total.ToString("C"));


            Console.ReadKey();
        }
    }
}
