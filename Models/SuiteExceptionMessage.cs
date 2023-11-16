namespace DesafioProjetoHospedagem.Models
{
    public class SuiteExceptionMessage 
    {
        private string Value { get; set; }
        public string DisplayName { get; set; }

        public static readonly SuiteExceptionMessage   CapacidadeMenorQueHospedes = new ("CapacidadeMenorQueHospedes", "Capacidade menor que o número de hóspedes.");

        public SuiteExceptionMessage () { }

        private SuiteExceptionMessage (string value, string displayName) { 
            Value = value;
            DisplayName = displayName;
        }
    }
}