using System;
using ExercicioDois.Classes;
using ExercicioDois.Interfaces;

namespace ExercicioDois
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá, bem-vindo!");

            string valorLido;
            double valor;
            bool temErros;
            do
            {
                temErros = false;
                Console.Write("Digite um valor para calcular os impostos aplicados: ");
                valorLido = Console.ReadLine();
                if (!double.TryParse(valorLido, out valor))
                {
                    Console.WriteLine("Digite um valor numérico válido!");
                    temErros = true;
                }
            } while (temErros);

            Imposto icms = new ICMS();
            Imposto ipi = new IPI();
            Imposto cofins = new COFINS();

            double valorIcms = icms.CalculaImposto(valor);
            double valorIpi = ipi.CalculaImposto(valor);
            double valorCofins = cofins.CalculaImposto(valor);
            
            Console.WriteLine("O valor do ICMS é: {0:0.0000}", valorIcms);
            Console.WriteLine("O valor do IPI é: {0:0.0000}", valorIpi);
            if (valorCofins == 0.00)
            {
                Console.WriteLine("O COFINS não se aplica sobre esse valor");
            }
            else
            {
                Console.WriteLine("O valor do COFINS é: {0:0.0000}", valorCofins);
            }

            Console.WriteLine("------------------------------------------");
            double valorTotal = valor + valorIcms + valorIpi + valorCofins;
            Console.WriteLine("O valor total com os impostos é: {0:0.0000}", valorTotal);
        }
    }
}