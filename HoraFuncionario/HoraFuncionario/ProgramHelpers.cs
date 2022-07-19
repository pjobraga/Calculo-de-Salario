﻿using System.Globalization;

namespace horaFun
{
    internal static class ProgramHelpers
    {
        static void Main(string[] args)
        {
            int numFun, horaTrab;
            float valHora, salFun;

            Console.WriteLine("\nEntre com o numero do funcionario: ");
            numFun = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com as horas trabalhadas: ");
            horaTrab = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com valor das horas trabalhadas: ");
            valHora = (float)double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numFun > 0 && numFun < 10)
            {
                salFun = valHora * horaTrab;
            }
            else
            {
                Console.WriteLine("Entre com numero valido de funcionario...");
                
            }


            Console.WriteLine("NUMERO FUNCIONARIO: " + numFun);
            Console.WriteLine("Salario do funcionario = U$ " + salFun.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}