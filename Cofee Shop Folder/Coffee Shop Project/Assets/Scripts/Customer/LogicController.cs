using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicController : MonoBehaviour

{

    [SerializeField] private GameObject customerPrefab;
    [SerializeField] private Transform SpawnPoint;
    public static bool customerSpawned = true;

    void Update()
    {
        
        if (customerSpawned == false)
        {
            customerSpawned = true;
            StartCoroutine(SpawnCustomer());

        }

        IEnumerator SpawnCustomer()
         {
               yield return new WaitForSeconds(2f);
               Instantiate(customerPrefab, SpawnPoint.position, SpawnPoint.rotation);
              
         }
        
    }

}



