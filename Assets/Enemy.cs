using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health)
    {
        this.Name = name;
        this.Health = health;
    }
    public Enemy() : this("", 0)
    {

    }
    public void Attack(int amount)
    {
        Health -= amount;
    }
}
