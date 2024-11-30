using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTerminal.Game.ObjectInGame.Enity.Base
{
    public abstract class Character
    {
        protected string _name;
        protected float healthPoint;
        protected float damageAttack;
        protected int rangeAttack;

        public int PosX;
        public int PosY;
        public float Health {  
            get=>healthPoint; 
            set=>healthPoint=value; 
        }

        public abstract void Move(char inputMove = ' ');
        public abstract void Attack(Tile[,] grid);
        public abstract void TakeDamage(float damage);
        protected abstract Character CheckRangeAttack(Tile[,] grid);
    }
}
