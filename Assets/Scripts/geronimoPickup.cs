using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class geronimoPickup : MonoBehaviour
{

    public GameObject geronimoGrey;
    public GameObject geronimoEnabled;
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
        //hermesGrey.SetActive(true);
        //firstManGrey.SetActive(true);
        geronimoGrey.SetActive(true);
        // timesTwoGrey.SetActive(true);
        // timesFourGrey.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D geronimoCol)
    {
        print("collected");
        scoreScript.scoreValue += 50;
        geronimoGrey.SetActive(false);
        geronimoEnabled.SetActive(true);
        Destroy(gameObject);
    }
}