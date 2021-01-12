using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gorusAcisi : MonoBehaviour
{
    [HideInInspector]
    public Vector3 sag;
    public Vector3 sol;
    public Transform sa;
    public Transform basik;
   
    void Start()
    {
        sa = GameObject.FindGameObjectWithTag("Vampir").transform;
        basik = GameObject.FindGameObjectWithTag("Yürek").transform;
        transform.position = new Vector3(transform.position.x, sa.position.y, sa.position.z);
        sag = new Vector3(11f,transform.position.y,transform.position.z);
        sol = new Vector3(-8f, transform.position.y, transform.position.z);
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
        RaycastHit2D a = Physics2D.Raycast(transform.position, sag, Vector3.Distance(transform.position,sag)); //Işınsal olarak devam edecek.
        RaycastHit2D b = Physics2D.Raycast(transform.position, sol,Vector3.Distance(transform.position,sol));
        Debug.Log(a.collider.name);
        Debug.Log(b.collider.name);
        if(a.collider.tag=="Vampir" || b.collider.tag=="Vampir")
        {
            Debug.Log("Hedef saptandı"); // 8 Ocak 2021 Cuma
            if(basik !=null)
            {
                
                    Transform uretim = Instantiate(basik, transform.position, Quaternion.identity) as Transform;
                    uretim.position = Vector3.MoveTowards(transform.position, b.collider.transform.position, 3f * Time.deltaTime);
                    Destroy(uretim.gameObject,10f);
                    
                
            }
        }
        
    }
}
