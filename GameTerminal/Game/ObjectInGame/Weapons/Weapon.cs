namespace GameTerminal.Game.ObjectInGame.Weapons
{
    public class Weapon
    {
        protected float damageAttack;
        protected int rangeAttack;

        public float DamageAttack
        {
            get { return damageAttack; }
        }
        public int RangeAttack
        {
            get { return rangeAttack; }
        }
    }
}