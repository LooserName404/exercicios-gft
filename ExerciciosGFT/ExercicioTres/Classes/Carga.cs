namespace ExercicioTres.Classes
{
    public class Carga
    {
        private double _valor { get; set; }
        private double _peso { get; set; }

        public double GetValor()
        {
            return _valor;
        }

        public double GetPeso()
        {
            return _peso;
        }

        public void SetValor(double valor)
        {
            _valor = valor;
        }

        public void SetPeso(double peso)
        {
            _peso = peso;
        }
    }
}