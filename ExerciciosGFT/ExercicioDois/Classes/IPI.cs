using ExercicioDois.Interfaces;

namespace ExercicioDois.Classes
{
    public class IPI : Imposto
    {
        public double CalculaImposto(double valor)
        {
            double percentual = valor < 20000 ? 0.07 : 0.19;
            return valor * percentual;
        }
    }
}