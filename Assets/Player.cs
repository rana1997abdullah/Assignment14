using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
   public Player(string name, int health)
   {
      this.Name = name;
      this.Health = health;
   }
   public Player() : this("", 0)
   {

   }
   public void Heal(int amount)
   {
      Health += amount;
   }
}
