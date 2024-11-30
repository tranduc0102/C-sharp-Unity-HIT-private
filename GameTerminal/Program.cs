using GameTerminal.Game.ObjectInGame.Enity.Base.Enity;
using GameTerminal.Game.ObjectInGame.Enity.Base;
using System.Security.Cryptography;

namespace GameTerminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new();
            gameManager.StartBattle();
        }
    }
}
