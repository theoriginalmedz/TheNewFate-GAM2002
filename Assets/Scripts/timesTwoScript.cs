using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timesTwoScript : MonoBehaviour {


    // hermesGrey,
    //  firstManGrey, 
    // geronimoGrey, 
    public GameObject timesTwoGrey;
    //   timesFourGrey,
    // hermesEnabled,
    // firstManEnabled, 
    //  geronimoEnabled,
    public GameObject timesTwoEnabled; 
    //  timesFourEnabled;

    private void Start()
    {
        //hermesGrey.SetActive(true);
        //firstManGrey.SetActive(true);
        // geronimoGrey.SetActive(true);
        timesTwoGrey.SetActive(true);
        // timesFourGrey.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D two)
    {
        print("collected");
        scoreScript.scoreValue += 50;
        timesTwoGrey.SetActive(false);
        timesTwoEnabled.SetActive(true);
        Destroy(gameObject);

    }
}
