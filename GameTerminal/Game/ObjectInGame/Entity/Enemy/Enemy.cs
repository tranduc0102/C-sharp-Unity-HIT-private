namespace GameTerminal.Game.ObjectInGame.Enity.Base.Enity;

public class Enemy : Character
{
    public override void Attack(Tile[,] grid)
    {
        Player target = CheckRangeAttack(grid) as Player;
        if (target != null)
        {
            target.TakeDamage(damageAttack);
        }
    }

    public override void Move(char none)
    {
        Random random = new Random();
    RandomX:
        int randomUpDownLeftRight = random.Next(1, 5);

        switch (randomUpDownLeftRight)
        {
            case 1:
                ++this.PosX;
                if (this.PosX >= 10)
                {
                    PosX = 9;
                    goto RandomX;
                }
                break;
            case 2:
                --this.PosY;
                if (PosY <= -1)
                {
                    PosY = 0;
                    goto RandomX;
                }
                break;
            case 3:
                ++this.PosY;
                if (PosY >= 10)
                {
                    PosY = 9;
                    goto RandomX;
                }
                break;
            case 4:
                --this.PosX;
                if (this.PosX <= -1)
                {
                    PosX = 0;
                    goto RandomX;
                }
                break;
        }

    }
    public override void TakeDamage(float damage)
    {
        healthPoint -= damage;
    }
    protected override Character CheckRangeAttack(Tile[,] grid)
    {
        if (PosX + rangeAttack < grid.GetLength(0) && grid[PosX + rangeAttack, PosY].IsEmpty is Player target1)
        {
            return target1;
        }
        if (PosX - rangeAttack >= 0 && grid[PosX - rangeAttack, PosY].IsEmpty is Player target2)
        {
            return target2;
        }
        if (PosY + rangeAttack < grid.GetLength(1) && grid[PosX, PosY + rangeAttack].IsEmpty is Player target3)
        {
            return target3;
        }
        if (PosY - rangeAttack >= 0 && grid[PosX, PosY - rangeAttack].IsEmpty is Player target4)
        {
            return target4;
        }
        return null;
    }
}