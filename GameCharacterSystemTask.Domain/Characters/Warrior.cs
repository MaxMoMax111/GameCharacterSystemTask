using GameCharacterSystemTask.Domain.Interfaces;

namespace GameCharacterSystemTask.Domain.Characters;

public class Warrior : Character, IWarrior
{
    public Warrior(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {
    }

    public override void Defend()
    {
        Defense += 5;

        Console.WriteLine($"Warrior {Name} is defending and gains 5 defense.");
    }

    public void Charge(Character target)
    {
        Console.WriteLine($"Warrior {Name} has charged to character {target.Name}");
    }
}