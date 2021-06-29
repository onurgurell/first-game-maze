using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class loadingscreen : MonoBehaviour
{
    public Text progress_text;
    public Slider slider_p;
    public GameObject loadingScreenObj;

    AsyncOperation async;

    public void LoadScreenExemple(int LVL)
    {
        StartCoroutine(LoadingScreen(LVL));
    }


    IEnumerator LoadingScreen(int lvl)
    {
        async = SceneManager.LoadSceneAsync(lvl);

        loadingScreenObj.SetActive(true);

        async.allowSceneActivation = false;

        while (async.isDone == false)
        {
            float progress = Mathf.Clamp01(async.progress / 0.9f);
            slider_p.value = async.progress;

            if (async.progress == 0.9f)
            {
                slider_p.value = 1f;
                async.allowSceneActivation = true;
            }
            progress_text.text = progress * 100 + "%";



            yield return null;
        }
    }
}
