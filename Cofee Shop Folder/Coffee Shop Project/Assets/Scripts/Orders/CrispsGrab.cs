using UnityEngine;

public class CrispsGrab : MonoBehaviour
 {

     void OnMouseDown()
     {
        
        if (NPCOrderRan.clickMax == false)
        {
          switch (NPCOrderRan.menuItem)
           {
             case "a packet of crisps.":
             Debug.Log("<color=green>||Crisps in hand||<color=grey>");
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

