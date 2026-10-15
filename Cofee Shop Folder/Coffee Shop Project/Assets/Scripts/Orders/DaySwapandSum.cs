// using UnityEngine;
// using System.Collections;

// public class DaySwapandSum : MonoBehaviour
// {
//     private int customerGoal = 1;
//     private int day = 1;
   
//     public static int totalEarnings = 0;

//     public static void daySwap()
//     {
//         if (NPCOrderRan.customersServed == customerGoal)
//         {
//             StartCoroutine(DaySum());

//         }

//     }
        
//     private IEnumerator DaySum()
//     {
        
//             yield return new WaitForSeconds(2f);
//             Debug.Log("<color=green>||You have reached the customer goal for today. The shop is now closed.||<color=grey>");
//             customerGoal ++;

//             yield return new WaitForSeconds(2f);
//             Debug.Log("<color=green>||Tomorrow, the customer goal will be " + customerGoal + ".||<color=grey>");

//             yield return new WaitForSeconds(2f);
//             Debug.Log("<color=green>||Total earnings: £" + totalEarnings + " ||<color=grey>");

//             yield return new WaitForSeconds(2f);
//             day ++;
//             Debug.Log("<color=green>||Day " + day + " has begun...||<color=grey>");
            

        
//     }

// }
