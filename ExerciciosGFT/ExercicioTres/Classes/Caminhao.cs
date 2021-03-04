namespace ExercicioTres.Classes
{
    public class Caminhao : Transporte
    {
        public Caminhao(Carga carga) : base(carga)
        {
        }

        public override double CalculaFrete(int distancia)
        {
            double valorSobrePeso = _carga.GetPeso() * 0.02;
            double valorSobreValorCarga = _carga.GetValor() * 0.03;
            double valorPorDistancia = distancia * 2;
            double valorTotal = valorSobrePeso + valorSobreValorCarga + valorPorDistancia;

            if (_carga.GetValor() > 40000)
            {
                valorTotal -= valorTotal * 0.25;
            }

            return valorTotal;
        }
    }
}