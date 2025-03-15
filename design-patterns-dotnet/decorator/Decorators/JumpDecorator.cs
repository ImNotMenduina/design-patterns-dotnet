using decorator.Interface;

namespace decorator.Decorators
{
    class JumpDecorator : CharacterDecorator
    {
        public JumpDecorator(Character character) : base(character)
        {
            base.Jump = true;
        }
        public override string MoveLeft()
        {
            return $"{Character.MoveLeft()} + Jump";
        }
        public override string MoveRight()
        {
            return $"{Character.MoveRight()} + Jump";
        }
    }
}
