using decorator.Interface;

namespace decorator.Decorators
{
    class FlyDecorator : CharacterDecorator
    {
        public FlyDecorator(Character character) : base(character)
        {
            base.Fly = true;
        }
        public override string MoveLeft()
        {
            return $"{Character.MoveLeft()} + Fly";
        }
        public override string MoveRight()
        {
            return $"{Character.MoveRight()} + Fly";
        }
    }
}
