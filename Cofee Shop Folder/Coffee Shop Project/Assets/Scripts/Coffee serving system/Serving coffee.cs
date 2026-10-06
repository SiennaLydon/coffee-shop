using UnityEngine;

public class SpawnCoffee : MonoBehaviour
{
    public int beans = 3;
    private int refills = 0;
    private int minRefills = 1;
    [SerializeField] private string[] coffeeMenu = { "Espresso", "Latte", "Mocha" };


    void Start()
    {
        foreach (string coffee in coffeeMenu)
        {
             Debug.Log("Coffee menu: " + coffee);
        }
   

        do
        {
            Debug.Log("Serving coffee, refill number: " + refills);
            refills++;
        }
        while (refills < minRefills);

    }

    void Update()
    {

     if (Input.GetKeyDown(KeyCode.Space))

       {
             do
             {
                Debug.Log("Served a coffee. Beans left: " + beans);
                beans--;
             }
             while (beans > 0);
        }
   }

}
        
    