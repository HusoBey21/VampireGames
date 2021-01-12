using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilerle : MonoBehaviour
{
    public Transform samimi;
    public Transform sagHareket, solHareket;
    void Start()
    {
        samimi = GameObject.FindGameObjectWithTag("Vampir").transform; // 3 Ocak 2021 Pazar
        solHareket = GameObject.FindGameObjectWithTag("Geri Dönüş").transform;
        sagHareket = GameObject.FindGameObjectWithTag("İleri Dönüş").transform;
    }
     


    // Update is called once per frame
    void Update()
    {
        float kelepce = Mathf.Clamp(Input.mousePosition.x,solHareket.position.x,(sagHareket.position.x +1f));
        
        Vector3 fareKonumu = new Vector3(kelepce,samimi.position.y,Input.mousePosition.z);

        RaycastHit2D s = Physics2D.Raycast(transform.position, sagHareket.position, Vector3.Distance(transform.position, sagHareket.position));
        Debug.Log(s.transform.name);
        Debug.Log("Fare konumu:" + fareKonumu);
        Debug.Log("Gerçek Fare Konumu" + Input.mousePosition);
        if(s.transform !=null)
        {
            if (s.transform.name != samimi.name)
            {
                transform.position = Vector3.MoveTowards(transform.position, fareKonumu, 3f * Time.deltaTime);
            }
        }
        
        
    }
}

