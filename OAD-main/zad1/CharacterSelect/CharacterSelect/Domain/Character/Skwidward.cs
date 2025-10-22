using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Skwidward : Entity.Character
{
    public Skwidward (string name) : base(name, CharacterClass.Skwidward )
    {
        Health = 12;
        Strength = 1;
        Intelligence = 67;
        Agility = 81;
        Lucky = 24;
        Creativity = 6;
    }
}