using GameCharacterSystemTask.Domain.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace GameCharacterSystemTask.Domain.Characters;

public class Character : ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public Character(string name, int health, int attack, int defense)
    {
        Name = name;
        Health = health;
        Attack = attack;
        Defense = defense;
    }

    public virtual void AttackTarget(Character target)
    {
        if (Attack > target.Defense)
        {
            var damage = Attack - target.Defense;
            target.Health -= damage;

            Console.WriteLine($"Character {Name} attacked {target.Name}. Damage is {damage}");

        }
        else
        {
            Console.WriteLine($"Character {Name} tried to attacked {target.Name}. But {target.Name}`s defense is to high.");
        }

        CheckTargetsHealth(target);
    }

    public virtual void Defend()
    {
        Console.WriteLine($"Character {Name} is defending.");
    }

    protected void CheckTargetsHealth(Character target)
    {
        if (target.Health < 0)
        {
            Console.WriteLine($"{target.Name} is dead. {Name} wins.");
        }
    }
}