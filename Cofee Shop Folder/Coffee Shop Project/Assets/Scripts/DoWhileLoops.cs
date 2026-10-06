using UnityEngine;

public class DoWhileLoops : MonoBehaviour
{

    private int refills = 0;
    private int maxRefills = 3;
   
    void Start()
    {
        do
        {
            Debug.Log("Serving coffe refill number: " + refills);
            refills++;
        }
        while (refills < maxRefills);
    }

    
}
