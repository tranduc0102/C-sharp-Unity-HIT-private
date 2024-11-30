using GameTerminal.Game.ObjectInGame.Weapons;
namespace GameTerminal.Game.ObjectInGame.Enity.Base.Enity;

public class Player : Character
{
    protected List<Weapon> weapons;
    protected Weapon currentWeapon;
    public Player()
    {
        _name = "Player";
        healthPoint = 2f;
        weapons = new List<Weapon>() { new RangeWeapon(), new MeleeWeapon() };
        Random random = new Random();
        currentWeapon = weapons[random.Next(0,weapons.Count)];
        Console.WriteLine($"Vũ khí hiện tại của bạn là: {currentWeapon.GetType().Name} và có tầm đánh là: {currentWeapon.RangeAttack}");
        rangeAttack = currentWeapon.RangeAttack;
        damageAttack = currentWeapon.DamageAttack;
    }
    public override void Move(char inputMove)
    {
        switch (inputMove)
        {
            case 'a':
                this.PosY--;
                if(this.PosY <= -1)
                {
                    this.PosY = 0;
                }
                break;
            case 'w':
                this.PosX--;
                if(this.PosX <= -1)
                {
                    this.PosX = 0;
                }
                break;
            case 'd':
                this.PosY++;
                if (this.PosY >= 10)
                {
                    this.PosY = 9;
                }
                break;
            case 's':
                this.PosX++;
                if (this.PosX >= 10)
                {
                    this.PosX = 9;
                }
                break;
            default:
                Console.WriteLine("Nhập lại");
                break;
        }
    }
    public override void TakeDamage(float damage)
    {
        healthPoint -= damage;
    }

    public override void Attack(Tile[,] grid)
    {

        Enemy target = CheckRangeAttack(grid) as Enemy;
        if (target != null)
        {
            target.TakeDamage(damageAttack);
        }
    }

    protected override Character CheckRangeAttack(Tile[,] grid)
    {
        if (PosX + rangeAttack < grid.GetLength(0) && grid[PosX + rangeAttack, PosY].IsEmpty is Enemy target1)
        {
            return target1;
        }
        if (PosX - rangeAttack >= 0 && grid[PosX - rangeAttack, PosY].IsEmpty is Enemy target2)
        {
            return target2;
        }
        if (PosY + rangeAttack < grid.GetLength(1) && grid[PosX, PosY + rangeAttack].IsEmpty is Enemy target3)
        {
            return target3;
        }
        if (PosY - rangeAttack >= 0 && grid[PosX, PosY - rangeAttack].IsEmpty is Enemy target4)
        {
            return target4;
        }
        return null;
    }
}