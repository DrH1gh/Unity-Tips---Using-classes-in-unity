using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //That while you can instantiate other classes using 'new', you shouldn't use 'new' to create new instances of your MonoBehaviour scripts.	
        Enemy enem1 = new Enemy(500, 100, "Crazy Joe");
        enem1.EnemyInfo();
        Enemy enem2 = new Enemy(500, 150, "Boom Boom, then party!");
        enem2.EnemyInfo();
        Enemy enem3 = new Enemy(1000, 50, "Lazy Bob");
        enem3.EnemyInfo();
        Debug.Log("Arr! Looking for blood.");

        Player hero = new Player("Blade the cooker", 3000, 50, 200);
        Debug.Log("*Some hero music playing...*");

        //Atack Enemy 1 with magic power - 3 times
        for (int i = 0; i < 3; i++)
        {
            int resitMagicDmg = Random.Range(100, hero.Magic);
            hero.AttackEnemy(enem1, resitMagicDmg);
        }
    }


    

}
