using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPCOrderRan : MonoBehaviour
{
    public static string menuItem = "nothing.";
    public static bool givenOrder = true;
    public static bool orderDone = false;
    public static int customersServed = 0;
    public static bool clickMax = false;


    private string[] Menu = {"an espresso.", "a latte.", "a mocha.",  "a milkshake.", "a packet of crisps."};

    void Start()
    {
        Debug.Log("<color=green>||Click on the customer to take their order.||<color=grey>");
    }

    void OnMouseDown()
    {
        
        if (givenOrder == true)
        {
            menuItem = Menu[Random.Range(0, Menu.Length)];
            Debug.Log("<color=white>Customer: Hello, I would like " + menuItem + "<color=grey>");
            givenOrder = false;


            switch (menuItem)
             {
                 case "an espresso.":
                 case "a latte.":
                 case "a mocha.":
                    Debug.Log("<color=green>||Use the coffee machine to make " + menuItem + "||<color=grey>");
                    break;

                case "a donut.":
                    Debug.Log("<color=green>||Grab a donut from the display and give it to the customer.||<color=grey>");
                    break;

                case "a muffin.":
                    Debug.Log("<color=green>||Grab a muffin from the display and give it to the customer.||<color=grey>");
                    break;

                case "a milkshake.":
                    Debug.Log("<color=green>||Grab a milkshake and give it to the customer.||<color=grey>");
                    break;

                case "a packet of crisps.":
                    Debug.Log("<color=green>||Grab some crisps from the crate and give them to the customer.||<color=grey>");
                    break;

                case "a toastie.":
                    Debug.Log("<color=green>||Make a toastie using the toasting machine.||<color=grey>");
                    break;

                case "a cookie.":
                    Debug.Log("<color=green>||Grab a cookie from the display and give it to the customer.||<color=grey>");
                    break;
             }

         }

        else if (orderDone == true)
        {
            Debug.Log("<color=white>Customer: Thank you for my order.<color=grey>");
            customersServed ++;
            givenOrder = false;
            clickMax = false;
            

            if (customersServed == 1)
            {
                Debug.Log("<color=green>||Well done! You have served " + customersServed + " customer.||<color=grey>");
                Destroy(gameObject);
                LogicController.customerSpawned = false;
                givenOrder = true;
                orderDone = false;

            }
            else
            {   
                 Debug.Log("<color=green>||Well done! You have served " + customersServed + " customers.||<color=grey>");
                 Destroy(gameObject);
                 LogicController.customerSpawned = false;
                 givenOrder = true;
                 orderDone = false;
                
                
            }  

            
        }

        else
        {
            Debug.Log("<color=white>Customer: I have already given my order, I wanted " + menuItem + ". <color=grey>");
        }

        


        //DaySwapandSum.daySwap();


    }


        
}








