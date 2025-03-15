namespace Builder.Model
{
    public class Hamburguer
    {
        public string? _pao;
        public string? Pao
        {
            set { 
                _pao = value;
            }
            get => _pao;
        }
        public string? Carne { get; set; }
        public bool Queijo { get; set; }
        public bool Bacon {  get; set; }
        public bool Salada { get; set; }
        public bool BatataPalha { get; set; }

        public string GetMessage()
        {
            return $"Pão {_pao}, " +
                $"Carne {Carne}, " +
                $"Queijo {Queijo}, " +
                $"Bacon {Bacon}, " +
                $"Salada {Salada}, " +
                $"Batata Palha {BatataPalha}.";
        }
    }
}
