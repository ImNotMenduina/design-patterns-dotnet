using decorator.Interface;

namespace decorator.Decorators
{
    class SpeedDecorator : CharacterDecorator
    {
        public SpeedDecorator(Character character) : base(character)
        {
            base.Speed = true;
        }
        public override string MoveLeft()
        {
            return $"{Character.MoveLeft()} + 10% speed";
        }

        public override string MoveRight()
        {
            return $"{Character.MoveRight()} + 10% speed";
        }
    }
}
