using GameCharacterSystemTask.Domain.Characters;

namespace GameCharacterSystemTask.Domain.Interfaces;

public interface IWarrior
{
    public void Charge(Character target);
}