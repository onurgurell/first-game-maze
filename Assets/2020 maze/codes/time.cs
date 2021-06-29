using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{
    public float zaman, verilen_zaman;

    public Text Timer;
    public GameObject gameover;
    public AudioSource voicerrr;

    void Start()
    {
        zaman = verilen_zaman;
    }

    
    void  Update()
    {
        zaman -= Time.deltaTime;

        Timer.text = zaman.ToString("f2");

        if (zaman <= 0)
        {
            gameover.SetActive(true);
            voicerrr.Pause();
            Invoke("gameover", 5f);
           
        }
    }
    
    
}
