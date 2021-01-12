using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uretme : MonoBehaviour
{
    public Transform ree;
    public float sure = 0f;
    public AudioSource sesKaynagi;
    public AudioClip klib;
    void Start()
    {
        ree = GameObject.FindGameObjectWithTag("Azrail").transform;
        sesKaynagi = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        sure += Time.deltaTime;
        if (ree != null)
        {
            if (sure >= 6f)
            {
                Transform azrailler = Instantiate(ree, transform.position, Quaternion.identity) as Transform;
                Destroy(azrailler.gameObject, 8f);
                sure = 0f;
            }
        }
        sesKaynagi.clip = klib;
        if(!sesKaynagi.isPlaying)
        {
            sesKaynagi.Play();
        }

    }
}
