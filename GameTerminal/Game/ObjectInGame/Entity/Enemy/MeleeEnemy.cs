using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameTerminal.Game.ObjectInGame.Enity.Base.Enity
{
    public class MeleeEnemy : Enemy   
    {
        public MeleeEnemy()
        {
            _name = "Meleee";
            healthPoint = 2f;
            rangeAttack = 1;
            damageAttack = 1f;
        }
    }
}
