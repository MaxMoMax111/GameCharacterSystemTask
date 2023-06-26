using GameCharacterSystemTask.Domain.Characters;

namespace GameCharacterSystemTask.Domain.Interfaces;

public interface IMage
{ 
    void CastSpell(Character target);
}