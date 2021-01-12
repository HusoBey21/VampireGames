using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    [SerializeField]
   private Animator animator;
    private float saglik;
    void Start()
    {
        float kisitlama = Mathf.Clamp(transform.position.x, -8.48f, 8f);
        transform.position = new Vector3(kisitlama, transform.position.y, transform.position.z);
        animator = this.GetComponent<Animator>();
        saglik = this.GetComponent<can>().saglik;
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float kisitlama = Mathf.Clamp(transform.position.x, -8.48f, 8f);
        transform.position = new Vector3(kisitlama, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown("left"))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 150f, transform.eulerAngles.z);
            transform.position += new Vector3(-1f, 0f, 0f) * 3f;
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown("right"))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0f, transform.eulerAngles.z);

            transform.position += new Vector3(1f, 0f, 0f) * 3f;
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.eulerAngles = new Vector3(0f, 0f, transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.eulerAngles = new Vector3(150f, 150f, transform.position.z);
        }
        if(Input.GetKeyDown("space"))
        {
            animator.enabled = true;
            animator.SetBool("isJumping", true);
            
        }
        if (Input.GetKeyUp("space"))
        {
            animator.enabled = true;
            animator.SetBool("isJumping", false);
            animator.enabled = false;
        }
        if(Input.GetKeyDown("escape"))
        {
            PlayerPrefs.SetFloat("saglik", saglik);
        }

    }
}
