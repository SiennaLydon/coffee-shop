using UnityEngine;

public class CoffeeMachineClick : MonoBehaviour
{
    private int seconds = 9;
   
    public static bool clickMax = false;

    void OnMouseDown()
    {
        if (clickMax == false)
        {
            
         switch (NPCOrderRan.menuItem)
         {
             case "an espresso.":
             case "a latte.":
             case "a mocha.":
                InvokeRepeating("BrewingCoffee", 1, 1);
                 NPCOrderRan.orderDone = true;
                 clickMax = true;
                 break;

             default:
                Debug.Log("||This is not a coffee order.||");
                break;
         }

        }

          
    }

    void BrewingCoffee()
    {
        seconds --;
        Debug.Log("||Brewing coffee.... " + seconds + " seconds remaining.||");
        
        if (seconds <= 1)
        {
          Debug.Log("||Coffee is ready.||");
          Debug.Log("||Click on the customer to give them their order.||");


          CancelInvoke("BrewingCoffee");
        }

     }

}
