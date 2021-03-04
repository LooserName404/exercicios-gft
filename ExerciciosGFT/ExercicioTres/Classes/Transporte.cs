namespace ExercicioTres.Classes
{
    public abstract class Transporte
    {

        public Transporte(Carga carga)
        {
            _carga = carga;
        }
        
        protected Carga _carga { get; set; }

        public abstract double CalculaFrete(int distancia);
    }
}