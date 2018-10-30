using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[Serializable]
public abstract class Building
{
    protected int posX;
    protected int posY;
    protected int Health;
    protected int Faction;
    protected string Symbol;

    public Building() { }
    abstract public bool isDead();
    abstract public string toString();
}

