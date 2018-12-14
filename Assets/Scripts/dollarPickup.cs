using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dollarPickup : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D money)
    {
        print("collected");
        scoreScript.scoreValue += 100;
        Destroy(gameObject);
        
    }
   
}