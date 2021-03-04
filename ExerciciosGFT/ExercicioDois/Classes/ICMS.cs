using ExercicioDois.Interfaces;

namespace ExercicioDois.Classes
{
    public class ICMS : Imposto
    {
        public double CalculaImposto(double valor)
        {
            return valor * 0.27;
        }
    }
}