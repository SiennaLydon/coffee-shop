using UnityEngine;

public class CoffeePriceHandler : MonoBehaviour
{
   [SerializeField] private CoffeePrices coffeeData;
   [SerializeField] private CoffeeMenu selectedCoffee;

    private void Start()
    {
         float price = GetCoffeePrice(selectedCoffee);
         Debug.Log($"{selectedCoffee} costs £{price: F2}");
    }

    private float GetCoffeePrice(CoffeeMenu coffeeMenu)
    {
        switch (coffeeMenu)
        {
            case CoffeeMenu.Espresso:
                return coffeeData.espressoPrice;
            case CoffeeMenu.Latte:
                return coffeeData.lattePrice;
            case CoffeeMenu.Cappuccino:
                return coffeeData.cappuccinoPrice;
            default:
                Debug.Log("Unknown coffee type: " + coffeeMenu);
                return 0f;
        }
    }
}