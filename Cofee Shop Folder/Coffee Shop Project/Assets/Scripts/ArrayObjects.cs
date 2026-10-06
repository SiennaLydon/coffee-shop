using UnityEngine;
using System.Collections.Generic;

public class ArraayObjects : MonoBehaviour
{
    public GameObject[] gameObject;
    public List<GameObject> gameObjectList = new List<GameObject>();

    void Start()
    {
        foreach (GameObject obj in gameObjectList)
        {
           Debug.Log("GameObject in List: " + obj.name);
        }
    }

    
    void Update()
    {
        
    }
}
