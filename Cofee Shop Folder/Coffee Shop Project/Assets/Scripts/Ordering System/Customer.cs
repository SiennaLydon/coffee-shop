using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
    public static string drinkType = "Coffee";
    //This is a new keyword for us
    //Static means that it is per class, not per instance of a class
    //static or read only will hide the variable from the inspector, but it will still be accessible in code

    public string exampleVariable = "Tea";

    public UnityEvent raiseOrder;

    void Start()
    {
        RequestDrinkType(drinkType);
    }

    public void RequestDrinkType(string drinkType)
    {
        Debug.Log(drinkType);
        Debug.Log(exampleVariable);
        raiseOrder?.Invoke();
    }
   
}
