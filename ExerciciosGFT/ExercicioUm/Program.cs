using System;
using System.Linq;

namespace ExercicioUm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá, bem-vindo!");

            string[] numerosLidos;
            int[] numeros;
            bool temErros;
            do
            {
                temErros = false;
                Console.Write("Digite cinco números separados por espaço: ");
                numerosLidos = Console.ReadLine().Split(' ');
                numeros = new int[5];
                if (numerosLidos.Length == 5)
                {
                    for (int i = 0; i < numerosLidos.Length; i++)
                    {
                        if (!int.TryParse(numerosLidos[i], out numeros[i]))
                        {
                            Console.WriteLine("A opção {0} - \"{1}\" é inválida.", i, numerosLidos[i]);
                            temErros = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("É necessário digitar exatamente cinco números para continuar. Números digitados: {0}", numerosLidos.Length);
                    temErros = true;
                }
            } while (temErros);
            
            int primeiro = numeros.First();
            
            if (numeros.All(n => n == primeiro))
            {
                Console.WriteLine("Os cinco números possuem o mesmo valor: {0}", primeiro);
                return;
            }

            int maior = numeros.Max();
            int menor = numeros.Min();
            
            Console.WriteLine("O maior número é: {0}", maior);
            Console.WriteLine("O menor número é: {0}", menor);
        }
    }
}