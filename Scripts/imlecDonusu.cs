using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imlecDonusu : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer giydirici;
    bool sagaBak = true;
    void Start()
    {
        giydirici = this.GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        Vector3 fark = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Kamera ile farenin ortak noktası 
        Vector3 fareHedefi = fark - transform.position;
        if(fareHedefi.x >=0 && !sagaBak)
        {
            giydirici.flipX = true;
            sagaBak = true;
        }
        if(fareHedefi.x<0 && sagaBak)
        {
            giydirici.flipX = false;
            sagaBak = false;
        }
    }

}
