using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;
public class adsbanner : MonoBehaviour
{

    private BannerView banner;
 


    public string idAndroid = "";
   

    private void Start()
    {
        
        this.RequestBanner();
        
    }

    public void RequestBanner()
    {

        #if UNITY_ANDROID

                string id = idAndroid;
        #endif
        banner = new BannerView(id, AdSize.Banner, AdPosition.Top);

        AdRequest request = new AdRequest.Builder().Build();

        banner.LoadAd(request);
        banner.Show();

    }

    //------------------------------


   
}
