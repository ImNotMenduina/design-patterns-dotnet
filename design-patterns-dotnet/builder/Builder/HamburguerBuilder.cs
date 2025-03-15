using Builder.Model;

namespace Builder.Builder
{
    public class HamburguerBuilder
    {
        private readonly Hamburguer _hamburguer;

        public HamburguerBuilder()
        {
            _hamburguer = new Hamburguer();
        }
        public HamburguerBuilder SetPao(string pao)
        {
            _hamburguer.Pao = pao;
            return this;
        }
        public HamburguerBuilder SetCarne(string carne)
        {
            _hamburguer.Carne = carne;
            return this;
        }
        public HamburguerBuilder SetQueijo()
        {
            _hamburguer.Queijo = true;
            return this;
        }
        public HamburguerBuilder SetSalada()
        {
            _hamburguer.Salada = true;  
            return this;
        }
        public HamburguerBuilder SetBacon()
        {
            _hamburguer.Bacon = true;
            return this;
        }
        public HamburguerBuilder SetBatataPalha()
        {
            _hamburguer.BatataPalha = true;
            return this;
        }
        public Hamburguer Build()
        {
            return _hamburguer;
        }
    }
}
