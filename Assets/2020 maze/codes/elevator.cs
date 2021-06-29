using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class elevator : MonoBehaviour
{
    public Animator anim;

   
    void Start()
    {
       
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider nesne)
    {
        if (nesne.tag == "PlayerTag")
        {
            anim.enabled = true;
            
            
        }
    }
}
