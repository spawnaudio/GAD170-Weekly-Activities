using JetBrains.Annotations;
using UnityEngine;

public class DebuggingAndOperations : MonoBehaviour
{
    public string openingMessage = "Game Start!";

    public int enemyCount = 8;
    public int gold = 53;
    public int partyMembers = 4;

    public int bonusGold = 20;
    public int costOfSwords = 35;

    public int baseDamage =  10;
    public int comboHits = 3; // how many hits form a combo

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(openingMessage); // A debug can take a string value.
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
