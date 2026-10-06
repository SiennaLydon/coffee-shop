using UnityEngine;

public class CoffeeMachineOn : MonoBehaviour

{

bool coffeeMachineOn = true;

    void Start()
    {
        if (coffeeMachineOn)
        {
            Debug.Log("Brewing coffee...");
        }
    }
}
