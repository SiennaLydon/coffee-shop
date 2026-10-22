using UnityEngine;

public class MilkshakeMake : MonoBehaviour
 {
   
     public static bool clickMax = false;

     void OnMouseDown()
     {
        
        if (clickMax == false)
        {
          switch (NPCOrderRan.menuItem)
           {
             case "a milkshake.":
             Debug.Log("<color=green>||Milkshake in hand||<color=grey>");
              Debug.Log("<color=green>||Click on the customer to give them their order.||<color=grey>");
              clickMax = true;
              NPCOrderRan.orderDone = true;
              break;

            default:
             break;

             
           }

        }
     }
        
}

