using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTerminal.Game.ObjectInGame.Weapons
{
    public class RangeWeapon:Weapon
    {
        public RangeWeapon() {
            this.rangeAttack = 2;
            this.damageAttack = 1;
        }
    }
}
