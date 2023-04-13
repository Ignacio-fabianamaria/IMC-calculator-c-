using System;

namespace ImcCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Digite o seu peso (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Peso lido do console: " + peso);

            Console.Write("Digite a sua altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Altura lida do console: " + altura);

            double imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc.ToString("0.00"));
        }
    }
}

