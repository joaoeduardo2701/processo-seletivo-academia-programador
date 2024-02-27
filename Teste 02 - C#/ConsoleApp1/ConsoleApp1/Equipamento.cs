namespace ConsoleApp1
{
    internal class Equipamento
    {
        public string NomeEquipamento { get; set; }
        public double PrecoAquisicao { get; set; }
        public int NumeroSerie { get; set; }
        public string DataFabricacao { get; set; }
        public string NomeFabricante { get; set; }

        public Equipamento()
        {
        }
        public Equipamento(string nomeEquipamento, double precoAquisicao, int numeroSerie, string dataFabricacao, string nomeFabricante)
        {
            NomeEquipamento = nomeEquipamento;
            PrecoAquisicao = precoAquisicao;
            NumeroSerie = numeroSerie;
            DataFabricacao = dataFabricacao;
            NomeFabricante = nomeFabricante;
        }
    }
}
