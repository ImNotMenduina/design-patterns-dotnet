using decorator.Interface;

namespace decorator.NovaPasta
{
    class Hero : Character
    {
        public Hero(string? name, float health, float mana, float power) : base(name, health, mana, power) { }
    }
}
