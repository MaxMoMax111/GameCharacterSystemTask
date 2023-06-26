using GameCharacterSystemTask.Domain.Interfaces;

namespace GameCharacterSystemTask.Domain.Characters;

public class Dragon : Character, IDragon
{
    public Dragon(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {
    }

    public void BreatheFire(Character target)
    {
        var fireDamage = Attack * 3;

        if (fireDamage > target.Defense)
        {
            var damage = fireDamage - target.Defense;
            target.Health -= damage;

            Console.WriteLine($"Dragon {Name} breathed the fire on {target.Name}. Damage is {damage}");
        }
        else
        {
            Console.WriteLine($"Dragon {Name} tried to breathed the fire on {target.Name}. But {target.Name}`s defense is to high.");
        }

        CheckTargetsHealth(target);
    }

    public override void Defend()
    {
        Defense += 20;

        Console.WriteLine($"Dragon {Name} is defending and gains 20 defense");
    }
}