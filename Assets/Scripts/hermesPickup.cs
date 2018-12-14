using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hermesPickup : MonoBehaviour
{

    public GameObject hermesGrey;
    public GameObject hermesEnabled;
    // hermesGrey,
    //  firstManGrey, 
    // geronimoGrey, 
    //   timesTwoGrey, 
    //   timesFourGrey,
    // hermesEnabled,
    // firstManEnabled, 
    //  geronimoEnabled,
    //  timesTwoEnabled, 
    //  timesFourEnabled;

    private void Start()
    {
        hermesGrey.SetActive(true);
        //firstManGrey.SetActive(true);
       // geronimoGrey.SetActive(true);
       // timesTwoGrey.SetActive(true);
       // timesFourGrey.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D hermes)
    {
        print("collected");
        scoreScript.scoreValue += 50;
        hermesGrey.SetActive(false);
        hermesEnabled.SetActive(true);
        Destroy(gameObject);

    }
}
	