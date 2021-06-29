using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{

    public AudioSource voicerrr;
    public GameObject pausep;

  


    public void buttton(string tıkla)
    {
        if (tıkla == "pause")
        {
            pausep.SetActive(true);
            Time.timeScale = 0;
            voicerrr.Pause();
        }
        else if (tıkla == "resume")
        {
            pausep.SetActive(false);
            Time.timeScale = 1;
            voicerrr.Play();
        }

        else if (tıkla == "menu")
        {
            Application.LoadLevel(0);
            Time.timeScale = 1;
        }
        else if (tıkla == "next level")
        {
            Application.LoadLevel(Application.loadedLevel + 1);
            Time.timeScale = 1;
            pausep.SetActive(false);
        }
        else if (tıkla == "tekrar")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;

        }
       


}
   

}
