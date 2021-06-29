using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class levelcomp : MonoBehaviour
{
    public GameObject Endscrn;

    public AudioSource voicerrr;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider nesne)
    {
        if (nesne.gameObject.tag == "PlayerTag")
        {
            Invoke("level", 3.5f);
        }
    }

    public void level()
    {
        Endscrn.SetActive(true);
        Time.timeScale = 0;
        voicerrr.Pause();
    }



}
