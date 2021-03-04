using System;
using ExercicioTres.Classes;

namespace ExercicioTres
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá, bem-vindo!");

            string[] numerosLidos;
            double valorCarga = 0;
            double pesoCarga = 0;
            int distancia = 0;
            bool temErros = false;

            do
            {
                Console.WriteLine("Digite o peso da carga, o peso da carga e a distância a ser percorrida (em quilômetros), respectivamente, separados por espaço: ");
                numerosLidos = Console.ReadLine().Split(' ');
                if (numerosLidos.Length != 3)
                {
                    Console.WriteLine("Argumentos inválidos!");
                    temErros = true;
                    continue;
                }

                if (!double.TryParse(numerosLidos[0], out pesoCarga) || pesoCarga <= 0)
                {
                    Console.WriteLine("O valor da carga é inválido!");
                    temErros = true;
                }

                if (!double.TryParse(numerosLidos[1], out valorCarga) || valorCarga <= 0)
                {
                    Console.WriteLine("O peso da carga é inválido!");
                    temErros = true;
                }

                if (!int.TryParse(numerosLidos[2], out distancia) || distancia <= 0)
                {
                    Console.WriteLine("A distância a ser percorrida (em KM) é inválida!");
                    temErros = true;
                }
            } while (temErros);

            Carga carga = new Carga();
            carga.SetPeso(pesoCarga);
            carga.SetValor(valorCarga);

            Transporte vagao = new Vagao(carga);
            Transporte caminhao = new Caminhao(carga);
            
            Console.WriteLine("Peso = {0} | Valor = {1} | Distância = {2}km", carga.GetPeso(), carga.GetValor(), distancia);
            Console.WriteLine("Frete Vagão: ${0:0.00} | Frete Caminhão: ${1:0.00}", vagao.CalculaFrete(distancia), caminhao.CalculaFrete(distancia));
        }
    }
}