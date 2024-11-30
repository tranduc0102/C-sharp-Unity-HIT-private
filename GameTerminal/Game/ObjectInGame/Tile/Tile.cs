using GameTerminal.Game.ObjectInGame.Enity.Base;

namespace GameTerminal;

public class Tile
{
    private Character isEmpty;

    public Character IsEmpty
    {
        get { return isEmpty; }
        set { isEmpty = value; }
    }

}