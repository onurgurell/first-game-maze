using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class kontrol2 : MonoBehaviour
{

    Rigidbody rb;

    int puan = 0;
    public Text puan_goster;

    public Animator anim;





    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mask" )
        {
            puan++;
            Destroy(other.gameObject);
            puan_goster.text = ": " + puan;


        }
        else if (puan >= 10)
        {
            if (other.gameObject.tag == "tasıma")
            {
                anim.enabled = true;
            }

        }
        

    }

}