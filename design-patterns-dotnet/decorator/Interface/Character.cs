namespace decorator.Interface
{
    abstract class Character
    {
        public string? Name { get; set; }
        public float Health { get; set; }
        public float Mana { get; set; }
        public float Power { get; set; }
        public bool Jump { get; set; } = false;
        public bool Speed { get; set; } = false;
        public bool Fly {  get; set; } = false;

        protected Character(string? name, float health, float mana, float power)
        {
            Name = name;
            Health = health;
            Mana = mana;
            Power = power;
        }

        public virtual string Punch() { return $"{Name} is punching"; }
        public virtual string Kick() { return $"{Name} is kicking"; }
        public virtual string MoveRight() { return $"{Name} is moving right"; }
        public virtual string MoveLeft() { return $"{Name} is moving left"; }
    }
}
