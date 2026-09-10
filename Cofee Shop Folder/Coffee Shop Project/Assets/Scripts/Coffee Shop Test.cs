using UnityEngine;

public class CoffeeShop : MonoBehaviour
{
    public int amountOrdered = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      Debug.Log("Hello World");
      Debug.Log("I have ordered");
      Debug.Log(amountOrdered + " Coffees");
      amountOrdered++;
      Debug.Log("oops, i actually ordered " + amountOrdered + " coffees");
    }
}
