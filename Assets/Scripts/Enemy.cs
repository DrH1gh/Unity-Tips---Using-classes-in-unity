using UnityEngine;


// Notice you don't have to inherit from MonoBehaviour.
public class Enemy
{

    private int health;
    private int attack;
    private string name;

    public int Health { get { return health; } set { health = value; } }
    public string Name { get { return name; }  }

    //This is the constructor
    public Enemy(int _health, int _attack, string _name)
    {
        this.health = _health;
        this.attack = _attack;
        this.name = _name;
    }

    //Some function, to print the information in the console.
    public void EnemyInfo()
    {
        Debug.Log("Enemy " + this.name + " created! Health: " + this.health + " Attack power: " + this.attack);
    }

}

