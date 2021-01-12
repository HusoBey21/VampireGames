using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canAl : MonoBehaviour
{
    public float sure;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="Vampir")
        {
            collision.gameObject.GetComponent<can>().canKaybi(4f); // 4flik bir can kaybı oluşacak
            sure += Time.deltaTime;
            if(sure >=6f)  //6 saniye ve üstünde süre olursa süreyi sıfırlıyoruz.
            {
                collision.gameObject.GetComponent<can>().canKazan();
                sure = 0f;
            }
        }
    }

}
