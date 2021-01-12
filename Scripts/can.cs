using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class can : MonoBehaviour
{
    [SerializeField]
    public float saglik = 100f;
    float zaman = 0f;
    public Text metin;
    void Start()
    {
        metin = GameObject.FindGameObjectWithTag("Metin").GetComponent<Text>();
    }
    
    public void canKazan()
    {
        zaman += Time.deltaTime;
        if(zaman >=6f)
        {
            saglik += 10f;
            if(saglik >= 100f)
            {
                saglik = 100f;
            }
            zaman = 0f;
            metin.text = "Health:" + saglik.ToString();
        }

    }
     void Update()
    {
        canKazan();
        
    }
    public void canKaybi(float hasar)
    {
        saglik -= hasar;
        if(saglik <=0)
        {
            saglik = 0;
            SceneManager.LoadScene(0); //Yeniden başlamayı sağlayacağız.
        }
        metin.text = "Health:" + saglik.ToString();

    }

}
