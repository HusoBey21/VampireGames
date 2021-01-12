using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solaGidis : MonoBehaviour
{

    public bool sagSol;
    SpriteRenderer spriteRenderer;
    public Vector3 hareket;
    public Transform nesne, nesneiki;

    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        hareket = transform.position;
        nesne = GameObject.FindGameObjectWithTag("Geri Dönüş").transform;
       


    }



    void Update()
    {
        if (sagSol)
        {
            transform.Translate(new Vector3(3f * Time.deltaTime, 0f, 0f));
            spriteRenderer.flipX = true;
        }
        else
        {
            transform.Translate(new Vector3(-3f * Time.deltaTime, 0f, 0f));
            spriteRenderer.flipX = false;
        }

    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(nesne.tag))
        {
            sagSol = true;
        }
        else
        {
            sagSol = false;
        }
    }
}

