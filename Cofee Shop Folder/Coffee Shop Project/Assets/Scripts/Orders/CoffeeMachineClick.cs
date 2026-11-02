using UnityEngine;

public class CoffeeMachineClick : MonoBehaviour
{
    private int seconds = 6;

    void OnMouseDown()
    {
        
        if (NPCOrderRan.clickMax == false)
        {
            
         switch (NPCOrderRan.menuItem)
         {
             case "an espresso.":
             case "a latte.":
             case "a mocha.":
                seconds = 6;
                InvokeRepeating("BrewingCoffee", 1, 1);
                NPCOrderRan.orderDone = true;
                NPCOrderRan.clickMax = true;
                break;

             default:
                Debug.Log("<color=green>||This is not a coffee order.||<color=grey>");
                break;
         }

        }

          
    }

    void BrewingCoffee()
    {
        seconds --;
        Debug.Log("<color=green>||Brewing coffee.... " + seconds + " seconds remaining.||<color=grey>");
        
        if (seconds <= 1)
        {
          Debug.Log("<color=green>||Coffee is ready.||<color=grey>");
          Debug.Log("<color=green>||Click on the customer to give them their order.||<color=grey>");


          CancelInvoke("BrewingCoffee");
        }

     }

}
