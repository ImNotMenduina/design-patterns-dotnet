namespace Builder.Model
{
    public class Enemy
    {
        public string? _name;
        public int Power { get; set; }
        public int Mana { get; set; }
        public float Health { get; set; }
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string GetEnemyInformation()
        {
            return $"Name {_name}, " +
                $"Power {Power}, " +
                $"Mana {Mana}, " +
                $"Health {Health}";
        }
    }
}
