using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engeller : MonoBehaviour
{
    public Transform sagdaki, soldaki;
     void Start()
    {
        sagdaki = GameObject.FindGameObjectWithTag("Geri Dönüş").transform;
        soldaki = GameObject.FindGameObjectWithTag("İleri Dönüş").transform;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Geri Dönüş")
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x,0f,transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position,soldaki.position,3f); //Geri dönüş sağlanması adına 

            Debug.Log("Soldaki");
        }
        if(collision.gameObject.tag=="İleri Dönüş")
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 150f, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, sagdaki.position, 3f); //Geri dönüş sağlanması adına yaptığım kod
            Debug.Log("Sağdaki");

        }
    }
}
