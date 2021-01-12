using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atesleme : MonoBehaviour
{
    public Transform mermi;
    AudioSource sesKaynagi;
    public AudioClip klib;
    void Start()
    {
        mermi = GameObject.FindGameObjectWithTag("Yıldız").transform; //Yıldız gönderecek.
        sesKaynagi = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ateslemek(); 
        }
    }
    public void ateslemek()
    {
        if (mermi != null)
        {
            Transform mermiler = Instantiate(mermi, transform.position, Quaternion.Euler(1f,1f,1f)) as Transform; //Dönüş x ekseni,y ekseni ve z eksenini etkiliyor.
            Destroy(mermiler.gameObject, 8f);
        }
        sesKaynagi.clip = klib;
        if (!sesKaynagi.isPlaying)
        {
            sesKaynagi.Play();
        }
    }
}
