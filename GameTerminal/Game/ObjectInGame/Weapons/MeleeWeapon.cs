using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTerminal.Game.ObjectInGame.Weapons
{
    public class MeleeWeapon:Weapon
    {
        public MeleeWeapon() {
            this.rangeAttack = 1;
            this.damageAttack = 1;
        }
    }
}
