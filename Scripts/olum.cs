using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olum : MonoBehaviour
{
    public float can = 100f;
   
    public void canKaybet(float zarar)
    {
        can -= zarar;
        if(can<=0)
        {
            can = 0;
            this.gameObject.SetActive(false);
        }else
        {
            this.gameObject.SetActive(true);
        }
    }
}
