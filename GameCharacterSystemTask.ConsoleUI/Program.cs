using GameCharacterSystemTask.Domain.Characters;

var arthur = new Warrior("Arthur", 500, 25, 20);
var merlin = new Mage("Merlin", 400, 10, 10);
var smaug  = new Dragon("Smaug", 1000, 50, 30);

arthur.AttackTarget(merlin);
smaug.BreatheFire(arthur);
arthur.Defend();
merlin.AttackTarget(smaug);
smaug.AttackTarget(smaug);
smaug.BreatheFire(arthur);
arthur.AttackTarget(smaug);
smaug.BreatheFire(merlin);
merlin.CastSpell(smaug);
arthur.AttackTarget(smaug);
smaug.BreatheFire(merlin);