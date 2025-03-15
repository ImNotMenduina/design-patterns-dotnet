using decorator.Interface;

namespace decorator.Decorators
{
    abstract class CharacterDecorator : Character
    {
        protected Character Character;
        public CharacterDecorator(Character character) : base(character.Name, character.Health, character.Mana, character.Power)
        {
            Character = character;
        }
    }
}
