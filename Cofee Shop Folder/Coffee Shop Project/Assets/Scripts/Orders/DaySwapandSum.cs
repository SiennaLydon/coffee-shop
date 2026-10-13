using UnityEngine;
using System.Collections;

public class DaySwapandSum : MonoBehaviour
{
    private int customerGoal = 4;
    private int day = 1;
    private int daySwapMin = 1;

    public static int totalEarnings = 0;

    private void Start()
    {
        if (NPCOrderRan.customersServed == customerGoal)
        {
            StartCoroutine(DaySwap());

        }


    }
        
    private IEnumerator DaySwap()
    {
        
        {
            yield return new WaitForSeconds(2f);
            Debug.Log("||You have reasched the customer goal for today. The shop is now closed.||");
            customerGoal ++;

            yield return new WaitForSeconds(2f);
            Debug.Log("||Tomorrow, the customer goal will be " + customerGoal + ".||");

            yield return new WaitForSeconds(2f);
            Debug.Log("||Total earnings: £" + totalEarnings + " ||");

            yield return new WaitForSeconds(2f);
            day ++;
            Debug.Log("||Day " + day + " has begun...||");
            
        }

        
    }

}
