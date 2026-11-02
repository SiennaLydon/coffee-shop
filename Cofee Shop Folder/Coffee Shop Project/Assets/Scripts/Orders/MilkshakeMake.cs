using UnityEngine;

public class MilkshakeMake : MonoBehaviour
 {
   

     void OnMouseDown()
     {
        
        if (NPCOrderRan.clickMax == false)
        {
          switch (NPCOrderRan.menuItem)
           {
             case "a milkshake.":
             Debug.Log("<color=green>||Milkshake in hand||<color=grey>");
              Debug.Log("<color=green>||Click on the customer to give them their order.||<color=grey>");
              NPCOrderRan.clickMax = true;
              NPCOrderRan.orderDone = true;
              break;

            default:
             break;

             
           }

        }
     }
        
}

