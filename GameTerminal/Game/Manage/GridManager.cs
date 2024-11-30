using GameTerminal.Game.ObjectInGame.Enity.Base;
using GameTerminal.Game.ObjectInGame.Enity.Base.Enity;
using System;
namespace GameTerminal;

public class GridManager
{
    private int xWide;
    private int yHigh;

    private List<Character> enemies;
    private Character player;

    public Tile[,] Grid;
    public GridManager(int xWide, int yHigh,List<Character> enemies,Character player)
    {
        this.xWide = xWide;
        this.yHigh = yHigh;
        this.player = player;
        this.enemies = enemies;
        Grid = new Tile[xWide, yHigh];
    }
    public void InitializeGrid()
    {
        SpawnGrid();
        CheckEntities();
        DisplayGrid();
    }
    private void SpawnGrid()
    {
        for (int i = 0; i < xWide; i++)
        {
            for (int j = 0; j < yHigh; j++) {
                Grid[i, j] = new Tile();
            }
        }
    }
    private void CheckEntities()
    {
        foreach (var enemy in enemies)
        {
            if (Grid[enemy.PosX, enemy.PosY].IsEmpty == null)
            {
                Grid[enemy.PosX, enemy.PosY].IsEmpty = enemy;
            }
        }

        if (Grid[player.PosX, player.PosY].IsEmpty == null)
        {
            Grid[player.PosX, player.PosY].IsEmpty = player;
        }
    }
    private void DisplayGrid()
    {
        for (int i = 0; i < xWide; i++)
        {
            for (int j = 0; j < yHigh; j++)
            {
                if (Grid[i, j].IsEmpty is Player)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("0 ");
                }
                else if (Grid[i, j].IsEmpty is MeleeEnemy)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("1 ");
                }
                else
                {
                    Console.ResetColor();
                    Console.Write("X ");
                }

            }
            Console.WriteLine();
        }
    }
    public void UpdateGrid(List<Character> enemies, Character player)
    {
        for (int i = 0; i < xWide; i++)
        {
            for (int j = 0; j < yHigh; j++)
            {
                Grid[i, j].IsEmpty = null;
            }
        }

        this.player = player;
        this.enemies = enemies;

        foreach (var enemy in enemies)
        {
            if (Grid[enemy.PosX, enemy.PosY].IsEmpty == null)
            {
                if(enemy.Health == 0)
                {
                    Grid[enemy.PosX, enemy.PosY].IsEmpty = null;
                }
                else
                {
                    Grid[enemy.PosX, enemy.PosY].IsEmpty = enemy;
                }
            }
        }

        if (Grid[player.PosX, player.PosX].IsEmpty == null)
        {
            if(player.Health == 0)
            {
                Grid[player.PosX, player.PosY].IsEmpty = null;
            }
            else
            {
                Grid[player.PosX, player.PosY].IsEmpty = player;
            }
        }
        DisplayGrid();
    }
}