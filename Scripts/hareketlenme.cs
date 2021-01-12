using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketlenme : MonoBehaviour
{
    [SerializeField]
    private Transform b;
    private Vector3 sagda, solda;

    void Start()
    {

        b = GameObject.FindGameObjectWithTag("Vampir").transform;
        sagda = new Vector3(11f, b.position.y, b.position.z);
        solda = new Vector3(-8f, b.position.y, b.position.z);

    }

    void Update()
    {
        RaycastHit2D s = Physics2D.Raycast(solda, sagda, Vector3.Distance(solda, sagda));
        if(s.transform !=null)
        {
            if (s.transform.name != "Vampir")
            {
                transform.position = Vector3.MoveTowards(transform.position, s.transform.position, 3f * Time.deltaTime);
            }

        }
       

       
    }
}
