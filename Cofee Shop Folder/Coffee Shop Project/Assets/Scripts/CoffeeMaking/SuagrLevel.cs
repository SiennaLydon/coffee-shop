using UnityEngine;

public class SuagrLevel : MonoBehaviour
{
    int sugarLevel = 2;
    
    void Start()
    {
       if (sugarLevel == 1)
       {
           Debug.Log("Coffee with one spoon of sugar.");
        
       }
       else if (sugarLevel == 2)
       {
           Debug.Log("Coffee with two spoons of sugar.");
       }
       else if (sugarLevel == 3)
       {
           Debug.Log("Coffee with three spoons of sugar.");
       }
       else
       {
           Debug.Log("Black coffee, no sugar.");
       }
    }
}
