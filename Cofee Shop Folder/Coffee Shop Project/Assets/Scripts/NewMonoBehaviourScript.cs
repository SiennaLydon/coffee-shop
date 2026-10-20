using UnityEngine;

public enum CoffeeType
{
    Espresso,
    Latte,
    Cappuccino,
    
}

[CreateAssetMenu(fileName = "CoffeeData", menuName = "Coffee/CoffeeData")]
public class CoffeeData : ScriptableObject
{
    public float espressoPrice = 2.00f;
    public float lattePrice = 3.50f;
    public float cappuccinoPrice = 3.00f;

}