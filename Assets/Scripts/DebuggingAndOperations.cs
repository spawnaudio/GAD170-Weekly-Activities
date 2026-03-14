using UnityEngine;

public class DebuggingAndOperations : MonoBehaviour
{
    public string openingMessage = "Game Start!";

    public int enemyCount = 8;
    public int gold = 53;
    public int partyMembers = 4;

    public int bonusGold = 20;
    public int costOfSword = 35;

    public int baseDamage =  10;
    public int comboHits = 3; // how many hits form a combo

    //--FLOATS

    public float criticalMultiplier = 1.5f;
    public float distanceToTreasure = 30f;
    public float timeToReach = 5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        // () - paranthesis = define order of operations
        // {} - curly braces = define scope
        // [] - square brackets = accessing an element of a collection



        Debug.Log(openingMessage); // A debug can take a string value.

        //--CURRENT STATS

        Debug.Log("Enemies in the area " + enemyCount);
        Debug.Log("Starting Gold is: " + gold);
        Debug.Log("party Member count is: " + partyMembers);

        Debug.Log("You find a bonus " + bonusGold + " gold");
        gold = gold + bonusGold;
        
        // gold += bonusGold; - is the shortcut version of the above
        // gold++; - basically the shortcut version to add 1 gold

        Debug.Log("Gold after picking up the bonus gold is: " +gold);

        Debug.Log("You Buy a sword for " + costOfSword + " gold");
        gold = gold - costOfSword; // an example of subtration between variables

        //gold -= costOfSword; // shortcut version of the above

        Debug.Log(" Gold left after buying a sword: " + gold);

        //--MULTIPLICATION

        Debug.Log("Base damage: " + baseDamage);
        Debug.Log("Combo hits done: " + comboHits);
        Debug.Log("The total combo damage of (base multiplied by combo hits): " + (baseDamage * comboHits));


        //--DIVISION

        Debug.Log("Sharing gold equally amoun party members");
        Debug.Log("Each party member gets (gold / party members: " + (gold / partyMembers));
        
        // in theory - this should be 9.5 gold each. But because this is an integer, when we divide an int by an int, we get int back

        // % = modulo, basically left over
        // 4 party memebrs, 38 gold, 

        Debug.Log("Left over gold (gold % party members) " + (gold % partyMembers));


        Debug.Log("Distance to the treasure is: " + distanceToTreasure + "m");
        Debug.Log("The time to reach the treasure is: " + timeToReach + "s");
        Debug.Log("travel speed (distance/time) " + (distanceToTreasure / timeToReach));

        Debug.Log("Critical hit multiplier " + criticalMultiplier);
        Debug.Log("critical hit damage (baseDamage * criticalMultiplier): " + (baseDamage * criticalMultiplier));

        Debug.Log("Adventure Ends :) ");


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
