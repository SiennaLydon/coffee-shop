using UnityEngine;

public class NPCOrderRan : MonoBehaviour
{
    public static string menuItem = "nothing.";
    public static bool givenOrder = true;
    public static bool orderDone = false;
    public static int customersServed = 4;

    private string[] Menu = {"a donut.", "an espresso.", "a latte.", "a mocha.", "a hot chocolate.", "a muffin.", "a milkshake.", "a packet of crisps.", "a toastie.", "a cookie."};

    void Start()
    {
        Debug.Log("||Click on the customer to take their order.||");
    }

    void OnMouseDown()
    {
        
        if (givenOrder == true)
        {
            menuItem = Menu[Random.Range(0, Menu.Length)];
            Debug.Log("Customer: Hello, I would like " + menuItem );
            givenOrder = false;


            switch (menuItem)
             {
                 case "an espresso.":
                 case "a latte.":
                 case "a mocha.":
                    Debug.Log("||Use the coffee machine to make " + menuItem + "||");
                    break;

                case "a hot chocolate.":
                    Debug.Log("||Use the hot chocolate machine to make a hot chocolate.||");
                    break;

                case "a donut.":
                    Debug.Log("||Grab a donut from the display and give it to the customer.||");
                    break;

                case "a muffin.":
                    Debug.Log("||Grab a muffin from the display and give it to the customer.||");
                    break;

                case "a milkshake.":
                    Debug.Log("||Make a milkshake using the milkshake machine.||");
                    break;

                case "a packet of crisps.":
                    Debug.Log("||Grab some crisps from the display and give them to the customer.||");
                    break;

                case "a toastie.":
                    Debug.Log("||Make a toastie using the toasting machine.||");
                    break;

                case "a cookie.":
                    Debug.Log("||Grab a cookie from the display and give it to the customer.||");
                    break;
             }

         }

        else if (orderDone == true)
        {
            Debug.Log("Customer: Thank you for my order.");
            customersServed++;
            givenOrder = false;
            CoffeeMachineClick.clickMax = false;

            if (customersServed == 1)
            {
                Debug.Log("||Well done! You have served " + customersServed + " customer.||");
            }
            else
                Debug.Log("||Well done! You have served " + customersServed + " customers.||");
                //wait 3 seconds, then delete old customer and bring in new customer
        }

        else
        {
            Debug.Log("Customer: I have already given my order. ");
        }
    }
}








