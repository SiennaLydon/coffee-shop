using UnityEngine;

public class NPCOrderRan : MonoBehaviour
{
    public static string menuItem = "nothing.";
    public static bool givenOrder = true;
    public static bool orderDone = false;
    private string[] Menu = {"a donut.", "an espresso.", "a latte.", "a mocha.", "a hot chocolate.", "a muffin.", "a milkshake.", "crisps.", "a toastie.", "a cookie."};

    void OnMouseDown()
    {
        if (givenOrder == true)
        {
            menuItem = Menu[Random.Range(0, Menu.Length)];
            Debug.Log("Hello, I would like " + menuItem );
            givenOrder = false;
        }

        else if (orderDone == true)
        {
            Debug.Log("Thank you for my order.");

            //Get rid of customer after order is given
        }

        else
        {
            Debug.Log("I have already given my order.");
        }
    }
}








