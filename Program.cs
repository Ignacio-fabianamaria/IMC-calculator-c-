using System;

namespace ImcCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu peso (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            altura = altura / 100.0; // Convertendo para metros

            double imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc.ToString("0.00"));

            if (imc < 18.5)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Você está em situação de MAGREZA");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Você está em situação de NORMALIDADE");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Você está em situação de SOBREPESO");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Você está em situação de OBESIDADE");
            }

            Console.ResetColor();
            Console.Write("\nReferência:\n");
            Console.Write("🛑 MAGREZA: Abaixo de 18,5\n");
            Console.Write("🟢 NORMALIDADE: Entre 18,5 e 24,9\n");
            Console.Write("🟡 SOBREPESO: Entre 25,0 e 29,9\n");
            Console.Write("🛑 OBESIDADE: Entre 25,0 e 29,9\n");

        }
    }
}

