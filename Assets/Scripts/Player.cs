using UnityEngine;

// Notice you don't have to inherit from MonoBehaviour.
public class Player
{
    private string heroName;
    private int health;
    private int attack;
    private float magic;

    //This is the constructor
    public Player(string _name, int _health, int _attack, float _magic)
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

}

