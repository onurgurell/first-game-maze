using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine;
using UnityEngine.UI;

public class odulreklami : MonoBehaviour
{
    private RewardBasedVideoAd rAd;

    private string id;

    public Text coinText;
    public Button rewardButton;

    private void start()
    {

        coinText.text = PlayerPrefs.GetInt("coin").ToString();

        rewardButton.interactable = false;
        id = "ca-app-pub-3940256099942544/5224354917";
        rAd = RewardBasedVideoAd.Instance;
        this.RequestAds();

        rAd.OnAdRewarded += VideoRewarded;
        rAd.OnAdClosed += VideoClosed;
    }

    private void RequestAds()
    {
        AdRequest request =new AdRequest.Builder().Build();

        this.rAd.LoadAd(request, id);
    }
    private void VideoRewarded(object sender, EventArgs e)
    {
        Reward();
    }
    private void VideoClosed(object sender, EventArgs e)
    {
        RequestAds();
    }
    public void ShowAds()
    {
        this.rAd.Show();
    }
    private void Reward()
    {
        int coin = PlayerPrefs.GetInt("coin");
        coin += 30;
        PlayerPrefs.SetInt("coin", coin);

        coinText.text = coin.ToString();
        rewardButton.interactable = false;
    }
    private void Update()
    {
        if (rAd.IsLoaded())
        {
            rewardButton.interactable = true;
        }
        else
        {
            rewardButton.interactable = false;
        }
    }
}
