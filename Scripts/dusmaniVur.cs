using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmaniVur : MonoBehaviour
{
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
       
        if(collision.gameObject.name=="Azrail")
        {
            
            collision.gameObject.GetComponent<olum>().canKaybet(3f); //3f can kaybet
            collision.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            Debug.Log("Dokunduk");

        }
    }

  
}
   