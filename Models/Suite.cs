namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite 
        { 
            get { return TipoSuite; }
            set
            {
                if (value != "Premium" && value != "Luxo" && value != "Simples")
                    throw new ArgumentException(ReservaExceptionMessage.TipoSuiteValorInvalido.DisplayName);
            } 
        }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}