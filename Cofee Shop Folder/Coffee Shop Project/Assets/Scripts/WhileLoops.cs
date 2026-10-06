using UnityEngine;

public class WhileLoops : MonoBehaviour
{
   private int beans = 3;

    void Start()
    {
        while (beans > 0)
        {
            Debug.Log("Served a coffee. Beans left: " + beans);
            beans--;
        }
    }

}
