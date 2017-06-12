using UnityEngine;

// Notice you don't have to inherit from MonoBehaviour.
public class Player
{
    private string heroName;
    private int health;
    private int attack;
    private int magic;

    public int Magic { get { return magic; } set { magic = value; } }

    //This is the constructor
    public Player(string _name, int _health, int _attack, int _magic)
    {
        this.health = _health;
        this.attack = _attack;
        this.heroName = _name;
        this.magic = _magic;
    }

    //Some function, to print the information in the console.
    public void PlayerInfo()
    {
        Debug.Log("**********************************");
        Debug.Log("Hero " + this.heroName + " created! Health: " + this.health + " Attack power: " + this.attack + " Magic power: " + this.magic);
        Debug.Log("**********************************");
    }

    public void AttackEnemy(Enemy enemy, int magic_attack)
    {
        Debug.Log("Hero is attacking. Damage " + magic_attack);
        enemy.Health -= magic_attack;
        if (enemy.Health <= 0)
            Debug.Log(enemy.Name + " is dead !");
        else
            Debug.Log(enemy.Name + ", survived.");

    }

}

