using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClickHermes : MonoBehaviour
{

    public playerScript pScript;
    public GameObject hermesGrey;
  
   
    void Start()
    {
        
        hermesGrey.SetActive(false);
        
        

    }

    void Update()
    {
       
    }


    public void changeSpeed()
    {
        StartCoroutine(mySpeed());
        
        
    }

    IEnumerator mySpeed()
    {
        hermesGrey.SetActive(true);
        pScript.movementSpeed += 5f;
        print("speedchange");
        yield return new WaitForSeconds(5f);
        pScript.movementSpeed -= 5f;
        print("speeddefault");
        
        
        
        
    }



       

//IEnumerator myTime()
   // {
        //yield return new WaitForSeconds(2); First attempt
        // print("done");
        // print("starting");
        //float timer = 0f; Seconds attempt
        //float time = 5f; 
        //while (timer < time) 
        // {
        //   pScript.movementSpeed = 5;
        // timer += Time.deltaTime;
        //yield return null;

        //    }

        //  StopAllCoroutines(); 

      //  pScript.movementSpeed += 5;
      //  print("clicked");

      //  if (waitFor5Seconds) third attempt
      //  {
       //     yield return new WaitForSeconds(5f);
            
     //   }

      
        //print("speeddefault");
      //  yield break;


   // }

}

