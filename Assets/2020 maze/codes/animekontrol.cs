using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animekontrol : MonoBehaviour
{

    public Animator anim;
    float InputX;
    public float InputY;

    void Start()
    {
       
        anim = this.gameObject.GetComponent<Animator>();
    }

    
    void Update()
    {
       
        InputY = Input.GetAxis("Vertical");
        InputX = Input.GetAxis("Vertical");
        anim.SetFloat("InputY", InputY);
        anim.SetFloat("InputX", InputX);


            
    }
    




}
