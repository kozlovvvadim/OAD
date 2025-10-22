namespace CharacterSelect.Domain.Character;
using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;
public sealed class Denis : Entity.Character
{
    public Denis (string name) : base(name, CharacterClass.Denis)
    {
        Health = 1;
        Strength = 4;
        Intelligence = -2;
        Agility = 4;
        Lucky = 24;
        Creativity = 6;
    }
}