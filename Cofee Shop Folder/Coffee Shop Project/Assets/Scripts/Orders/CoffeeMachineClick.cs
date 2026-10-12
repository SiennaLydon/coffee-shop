using UnityEngine;

public class CoffeeMachineClick : MonoBehaviour
{
    private int seconds = 9;
    void OnMouseDown()
    {
         if (NPCOrderRan.menuItem == "an espresso.")
         {
             seconds = 9;
             InvokeRepeating("BrewingCoffee", 1, 1);
             NPCOrderRan.orderDone = true;
         }

         else
         {
             Debug.Log("This is not a coffee order.");
         }

    }
    void BrewingCoffee()
    {
        seconds --;
        Debug.Log("Brewing coffee.... " + seconds + " seconds remaining.");
        
        if (seconds <= 1)
        {
          Debug.Log("Coffee is ready.");

          CancelInvoke("BrewingCoffee");
        }

     }

}
