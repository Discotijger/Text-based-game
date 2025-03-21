using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

class Player{
    //fields
    private static int health;
    
    public static int Health
    {
        get{return health;}
        private set{ health = Math.Max(0,value); }
    }

    public static void DecreaseHealth(int amount)
    {
        Health -= amount;
    }
    
    //auto property
    public Room CurrentRoom;

    //constructor
    public Player(){
        CurrentRoom = null;

        health = 100;
    }

    
    void Damage(int amount){
        Health -= amount;
    }

    void Heal( int amount){

    }
    
    
    public static void isAlive(){
        if(health <= 0){
            Console.Clear();
            Console.WriteLine("You died");

        }
    }
}