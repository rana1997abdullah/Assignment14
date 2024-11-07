using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player("Rana",70);
        Enemy enemy1 = new Enemy("Hussam",100);
        Player player2 = new Player();
        Enemy enemy2 = new Enemy();
        Debug.Log("Name for player1 name = " + player1.Name);
        Debug.Log("Health for player1 health = " + player1.Health);
        Debug.Log("Name for enemy1 name = " + enemy1.Name);
        Debug.Log("Health for enemy1 health = " + enemy1.Health);
        //the full health is not more 100
        player1.Heal(20);
        Debug.Log("Health for player1 after Heal the full health is not more 100 health = " + player1.Health);
        //the full calculated health is more 100 
         // but the max value is 100 so it will return 100 
         player1.Heal(40);
        Debug.Log("Health for player1 after Heal the full calculated health is more 100 health = " + player1.Health);
        
        enemy1.Attack(10);
        Debug.Log("Health after attacking enemy1 health = " + enemy1.Health);
        ///here in case if we do not send the name and health of player or enemy
        /// i added it for general
        /// 
        player2.Name = "player2";
        Debug.Log("Name for player2 name = " + player2.Name);
        
        Debug.Log("Health for player2 health = " + player2.Health);
        Debug.Log("Name for enemy2 name = " + enemy2.Name);
        Debug.Log("Health for enemy2 health = " + enemy2.Health);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
