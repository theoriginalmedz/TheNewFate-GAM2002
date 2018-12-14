using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tfsOnClick : MonoBehaviour {


    public Rigidbody2D rgbd2d;
    public GameObject firstManGrey;
    
    void Start()
    {
        
        firstManGrey.SetActive(false);
      


    }

    void Update()
    {
       
    }


    public void changeGravity()
    {
        StartCoroutine(myGravity());
        
        
    }

    IEnumerator myGravity()
    {
        firstManGrey.SetActive(true);
        rgbd2d.gravityScale -= .06f;
        print("gravitychange");
        yield return new WaitForSeconds(5f);
        rgbd2d.gravityScale += .06f;
        print("gravitydefault");
        
        
        
        
    }
}
