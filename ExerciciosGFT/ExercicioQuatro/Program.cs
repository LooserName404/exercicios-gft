using System;

namespace ExercicioQuatro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá, bem-vindo!");

            int repeticoes = 0;
            bool temErros = false;
            do
            {
                temErros = false;
                Console.Write("Digite um número pra gente tocar a música: ");
                if (!int.TryParse(Console.ReadLine(), out repeticoes))
                {
                    Console.WriteLine("Digite um número válido!");
                    temErros = true;
                }
            } while (temErros);

            if (repeticoes == 1)
            {
                Console.WriteLine("Um elefante incomoda muita gente!");
            }
            else
            {
                string incomodam = "";
                for (int i = 1; i <= repeticoes; i++)
                {
                    incomodam += "Incomodam ";
                }
                Console.WriteLine("{0} elefantes {1}muito mais!", repeticoes, incomodam);
            }
        }
    }
}