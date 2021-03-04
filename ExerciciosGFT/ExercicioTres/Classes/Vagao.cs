namespace ExercicioTres.Classes
{
    public class Vagao : Transporte
    {
        public Vagao(Carga carga) : base(carga)
        {
        }

        public override double CalculaFrete(int distancia)
        {
            double valorSobrePeso = _carga.GetPeso() * 0.07;
            double valorSobreValorCarga = _carga.GetValor() * 0.01;
            double valorPorDistancia = distancia * 0.5;
            double valorTotal = valorSobrePeso + valorSobreValorCarga + valorPorDistancia;
            if (_carga.GetPeso() < 15000)
            {
                valorTotal += 5000;
            }

            return valorTotal;
        }
    }
}