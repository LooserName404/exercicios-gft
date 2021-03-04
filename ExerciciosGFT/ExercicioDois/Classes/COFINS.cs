using ExercicioDois.Interfaces;

namespace ExercicioDois.Classes
{
    public class COFINS : Imposto
    {
        public double CalculaImposto(double valor)
        {
            return valor > 12000 ? valor * 0.04 : 0;
        }
    }
}