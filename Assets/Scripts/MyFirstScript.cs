
using UnityEngine;
/* 
'using' is defining a Library
public' is accesws type, public means that it can be accessed by anyone, private meaning that it can access by this class only
'class' - think blueprint, or container of instructions to run. 
{ } - is defined as 'SCOPE' or the body of the class, where we will write our code
*/
public class MyFirstScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /// <summary>
    /// This function gets called on the first frame of the game.
    /// </summary>
    [Header("This is my health variables")]
    [Space(20)] 
    [Tooltip("this is the players health")]
    public int health = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
