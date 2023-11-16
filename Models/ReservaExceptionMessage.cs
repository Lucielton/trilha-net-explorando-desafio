namespace DesafioProjetoHospedagem.Models
{
    public class ReservaExceptionMessage 
    {
        private string Value { get; set; }
        public string DisplayName { get; set; }

        public static readonly ReservaExceptionMessage  TipoSuiteValorInvalido = new ("TipoSuiteValorInvalido", "Valor inválido para TipoSuite.");

        public ReservaExceptionMessage() { }

        private ReservaExceptionMessage(string value, string displayName) { 
            Value = value;
            DisplayName = displayName;
        }
    }
}