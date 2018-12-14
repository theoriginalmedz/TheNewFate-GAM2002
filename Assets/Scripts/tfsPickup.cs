using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tfsPickup : MonoBehaviour {

    public GameObject firstManGrey;
    public GameObject firstManEnabled;
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
        firstManGrey.SetActive(true);
        //geronimoGrey.SetActive(true);
        // timesTwoGrey.SetActive(true);
        // timesFourGrey.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D firstManCol)
    {
        print("collected");
        scoreScript.scoreValue += 50;
        firstManGrey.SetActive(false);
        firstManEnabled.SetActive(true);
        Destroy(gameObject);
    }
}