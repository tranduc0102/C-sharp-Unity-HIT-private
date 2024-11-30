using GameTerminal.Game.ObjectInGame.Enity.Base;
using GameTerminal.Game.ObjectInGame.Enity.Base.Enity;
using System;

namespace GameTerminal;

public class GameManager
{
    private Character player;
    private List<Character> enemies;
    private bool turn = true;
    private GridManager gridManager;
    public void StartBattle()
    {
        Console.WriteLine("Bắt đầu trận chiến!");
        SpawnEnity();
        gridManager.InitializeGrid();
        while (true)
        {
            if (turn)
            {
                TurnPlayer();
            }
            else
            {
                TurnEnemy();
            }
            if (CheckWinOrLose())
                break;
        }
    }
    private void SpawnEnity()
    {
        player = new Player();
        enemies = new List<Character>();
        enemies.Add(new MeleeEnemy());
        enemies.Add(new MeleeEnemy());
        Random random = new Random();

        player.PosX = random.Next(0, 10);
        player.PosY = random.Next(0, 10);
        foreach (var enemy in enemies)
        {
        Back:
            enemy.PosX = random.Next(0, 10);
            enemy.PosY = random.Next(0, 10);
            if (enemy.PosX == player.PosX && enemy.PosY == player.PosY)
            {
                goto Back;
            }
        }
        gridManager = new(10, 10, enemies, player);
    }
    private void TurnEnemy()
    {
        Console.WriteLine("--- Lượt quái di chuyển ---");

        for (int i = enemies.Count - 1; i >= 0; i--)
        {
            var enemy = enemies[i];

            if (enemy.Health > 0)
            {
                enemy.Move('n');
                Console.Clear();
                gridManager.UpdateGrid(enemies, player);
                enemy.Attack(gridManager.Grid);
                Thread.Sleep(2000);
            }
            else
            {
                enemies.RemoveAt(i);
            }
        }

        turn = true;
    }

    private void TurnPlayer()
    {
        Console.WriteLine("--- Lượt người di chuyển ---");
        char inputMove = Console.ReadKey().KeyChar;
        player.Move(inputMove);
        Thread.Sleep(2000);
        Console.Clear();
        // Console.WriteLine(player.PosX+"   "+ player.PosY);
        player.Attack(gridManager.Grid);
        gridManager.UpdateGrid(enemies,player);
        Thread.Sleep(2000);
        turn = false;
    }

    private bool CheckWinOrLose()
    {
        bool playersDead = player.Health <= 0;
        bool allEnemiesDead = enemies.TrueForAll(e => e.Health <= 0);

        if (playersDead)
        {
            Console.WriteLine("Người chơi thua cuộc!");
            return true;
        }

        if (allEnemiesDead)
        {
            gridManager.UpdateGrid(enemies, player);
            Console.WriteLine("Người chơi chiến thắng!");
            return true;
        }

        return false;
    }
}