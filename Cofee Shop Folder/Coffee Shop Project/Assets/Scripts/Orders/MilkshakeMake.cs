// using UnityEngine;

// public class MilkshakeMake : MonoBehaviour
// {
//     private int seconds = 9;
   
//     public static bool clickMax = false;

//     void OnMouseDown()
//     {
//         if (clickMax == false)
//         {
            
//          switch (NPCOrderRan.menuItem)
//          {
//              case "a milkshake.":
//                 InvokeRepeating("Making Milkshake", 1, 1);
//                  NPCOrderRan.orderDone = true;
//                  clickMax = true;
//                  break;

//              default:
//                 Debug.Log("<color=green>||This is not a milkshake order.||<color=grey>");
//                 break;
//          }

//         }

          
//     }

//     void MakingMilkshake()
//     {
//         seconds --;
//         Debug.Log("<color=green>||Making milkshake.... " + seconds + " seconds remaining.||<color=grey>");
        
//         if (seconds <= 1)
//         {
//           Debug.Log("<color=green>||Milkshake is ready.||<color=grey>");
//           Debug.Log("<color=green>||Click on the customer to give them their order.||<color=grey>");


//           CancelInvoke("MakingMilkshake");
//         }

//      }

// }

