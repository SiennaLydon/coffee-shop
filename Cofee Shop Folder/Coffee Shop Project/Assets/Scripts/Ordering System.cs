using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //camel Casing i.e variables -> first letter lowercase, each new word starts with a capital letter
    private float _costOfCoffee = 4;

    private int coffeeAmountOrdered;

    public float totalOrderCost;

//Pascal Casing i.e Method, Classes, Properties -> first letter of each word is capitalized
    public void AmountPlaced(int coffeeAmountOrdered)
   {
       totalOrderCost = coffeeAmountOrdered * _costOfCoffee;
       Debug.Log("Your order cost today is" + "£" + totalOrderCost);
   }
    
   
}

//Access Modifiers
//void -> private void
//void
//public void -> public void

//if public, can be seen outside of the class (script)
//if private, cannot be seem outside of the class (script)