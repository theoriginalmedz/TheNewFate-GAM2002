using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class geronimoOnClick : MonoBehaviour
{

    public playerScript pScript;
    public GameObject geronimoGrey;
    

    void Start()
    {

        geronimoGrey.SetActive(false);


    }

    void Update()
    {

    }


    public void changeJump()
    {
        StartCoroutine(myJump());


    }

    IEnumerator myJump()
    {
        geronimoGrey.SetActive(true);
        pScript.jumpingForce += 5f;
        print("jumpingChange");
        yield return new WaitForSeconds(5f);
        pScript.jumpingForce -= 5f;
        print("jumpingnormal");




    }

}

