using GameCharacterSystemTask.Domain.Interfaces;

namespace GameCharacterSystemTask.Domain.Characters;

public class Mage : Character, IMage
{
    public Mage(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {
    }

    public void CastSpell(Character target)
    {
        var spellsDamage = Attack * 1.5;

        if (spellsDamage > target.Defense)
        {
            var damage = spellsDamage - target.Defense;
            target.Health -= (int)damage;

            Console.WriteLine($"Mage {Name} cast the spell to {target.Name}. Damage is {damage}");
        }
        else
        {
            Console.WriteLine($"Mage {Name} tried to cast the spell to {target.Name}. But {target.Name}`s defense is to high.");
        }

        CheckTargetsHealth(target);
    }

    public sealed override void Defend()
    {
        base.Defend();
    }
}