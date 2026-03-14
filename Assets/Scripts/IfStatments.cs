using UnityEngine;

public class IfStatments : MonoBehaviour
{

    public int health = 70;
    public int score = 120;
    public int coins = 0;

    public string playerName = "Alex";
    public string playerClass = "Wizard";

    public bool hasKey = true;
    public bool doorIsLocked = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(health > 0)
        {
            Debug.Log("Health is greater than 0, player is alive");
        }

        if(health <= 0) // -- <= is like saying "is the value of health less than or equal to 0?"
        {
            Debug.Log("Player is dead, cause health is less than or equal to 0");
        }

        if(score >= 100) // -- >= is like saying "is the value of score greater than or equal to 100?"
        {
            Debug.Log("your score is above 100");
        }

        if(score <100)
        {
            Debug.Log("your score is under 100");
        }

        if(coins == 0) //-- == is like saying "is the value of coins equal to exactlty 0?"
        {
            Debug.Log("you have no coins");
        }

        if(coins != 0) //-- != is like saying "is the value of coins not equal to exactly 0?"
        {
            Debug.Log("you have some coins");
        }

        //--STRING CHECKING

        if(playerName == "Alex") // -- string needs to be exactly Alex, alex, ALEX, etc. will not work
        {
            Debug.Log("Player name is Alex");
        }

        if(playerName != "Alex")
        {
            Debug.Log("Player name is not Alex");
        }

        if(playerClass == "Wizard")
        {
            Debug.Log("you are a Wizard");
        }

            if(playerName == "Harry")
            {
                Debug.Log("you are a Wizard harry");
            }
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
