using UnityEngine;

public class CoffeeBeans : MonoBehaviour


{
    bool coffeeBeansAvailable = false;

    void Start()
    {
       if(coffeeBeansAvailable)
       {
           Debug.Log("Coffee brewing started.");
       }
         else
       {
            Debug.Log("No coffee beans available.");
        }
     }
 }

