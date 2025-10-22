using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Goobkabob : Entity.Character
{
    public Goobkabob(string name) : base(name, CharacterClass.Goobkabob)
    {
        Health = 203;
        Strength = 44;
        Intelligence = 6;
        Agility = 1;
        Lucky = 24;
        Creativity = 6;
    }
}