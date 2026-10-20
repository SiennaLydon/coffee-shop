using UnityEngine;

public enum CoffeeMenu
{
    Espresso,
    Latte,
    Cappuccino
}

[CreateAssetMenu(fileName = "CoffeeData", menuName = "Coffee/CoffeeData")]

public class CoffeePrices : ScriptableObject
{
    public float espressoPrice = 2.50f;
    public float lattePrice = 3.50f;
    public float cappuccinoPrice = 3.00f;
}