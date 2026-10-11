using UnityEngine;

public class NPCOrderRan : MonoBehaviour
{
    private string[] Menu = {"a donut", "an espresso", "a latte", "a mocha", "a hot chocolate", "a muffin", "a milkshake", "crisps", "a toastie"};

    void OnMouseDown()
    {
        string menuItem = Menu[Random.Range(0, Menu.Length)];
        Debug.Log("Hello, I would like " + menuItem );
        
    }
}








