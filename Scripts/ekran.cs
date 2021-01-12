using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ekran : MonoBehaviour
{
    [SerializeField]

    SpriteRenderer sa;

    void Start()
    {

        sa = this.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        ekranAyari();
    }

    public void ekranAyari()
    {
        this.transform.localScale = new Vector3(1f, 1f, 1f);
        float boy = Screen.height;
        float en = Screen.width;
        float resimEn = sa.bounds.size.x;
        float resimBoy = sa.bounds.size.y;
        float kameraYuksekligi = 1.50f* Camera.main.orthographicSize * 2.0f;
        float kameraGenisligi = kameraYuksekligi * en / boy;

        this.transform.localScale = new Vector2(kameraYuksekligi/(resimBoy), kameraGenisligi/(resimEn));


    }
}