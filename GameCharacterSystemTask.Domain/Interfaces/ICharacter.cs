using GameCharacterSystemTask.Domain.Characters;

namespace GameCharacterSystemTask.Domain.Interfaces;

internal interface ICharacter
{ 
    string Name { get; set; }
    int Health { get; set; }
    int Attack { get; set; }
    int Defense { get; set; }

    void AttackTarget(Character target);
    void Defend();
}