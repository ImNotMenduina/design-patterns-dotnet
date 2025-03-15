using Builder.Model;

namespace Builder.Builder
{
    public class EnemyBuilder
    {
        private readonly Enemy _enemy;
        public EnemyBuilder()
        {
            _enemy = new Enemy();
        }
        public EnemyBuilder SetName(string name)
        {
            _enemy.Name = name;
            return this;
        }
        public EnemyBuilder SetPower(int power)
        {
            _enemy.Power = power;
            return this;
        }
        public EnemyBuilder SetMana(int mana)
        {
            _enemy.Mana = mana;
            return this;
        }
        public EnemyBuilder SetHealth(int health)
        {
            _enemy.Health = health;
            return this;
        }
        public Enemy Build()
        {
            return _enemy;
        }
    }
}
