using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesazaltmayükseltme : MonoBehaviour
{
    public AudioSource AudioSource;

    private float musicvolume = 1f;

    void Start()
    {
        AudioSource.Play();
    }


    void Update()
    {
        AudioSource.volume = musicvolume;
    }

    public void updateVolume(float volume)
    {

        musicvolume = volume;

    }

}
