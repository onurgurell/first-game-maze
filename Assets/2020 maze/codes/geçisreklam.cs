using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine;
public class geçisreklam : MonoBehaviour
{
    private InterstitialAd gecis;
    public string testgecisreklamID;
    private void Start()
    {
        this.Request();
    }

    // Update is called once per frame
    private void Request()
    {
#if UNITY_ANDROID

                string adUnitId = "ca-app-pub-5662248286314478/1549566411";
#endif
        this.gecis = new InterstitialAd(testgecisreklamID);
        this.gecis.OnAdClosed += IntersitialClosed;

        AdRequest request = new AdRequest.Builder().Build();

        this.gecis.LoadAd(request);

    }

    private void IntersitialClosed(object sender, EventArgs e)
    {
        this.Request();
    }

    public void Goster()
    {
        this.gecis.Show();
    }



}



