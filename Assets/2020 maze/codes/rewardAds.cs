using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine;
using UnityEngine.UI;

public class rewardAds : MonoBehaviour
{
    private RewardBasedVideoAd adReward;

    private string idReward;
    public GameObject gamescreen;
    

    [SerializeField] Button BtnReward;
    [SerializeField] Text TxtPoints;
    public AudioSource voicerrr;
 
    void Start()
    {
       
        TxtPoints.text = PlayerPrefs.GetInt("points").ToString();
        idReward = "ca-app-pub-3940256099942544/5224354917";
        adReward = RewardBasedVideoAd.Instance;

        

    }
    #region Reward video methof ----------

    public void RequestRewardAd()
    {
        AdRequest request = AdRequestBuild();
        adReward.LoadAd(request, idReward);


        adReward.OnAdLoaded += this.HandleOnRewardedAdLoaded;

        adReward.OnAdRewarded += this.HandleOnRewarded;
        adReward.OnAdClosed += this.HandleOnRewardedAdClosed;
    }

    public void ShowRewardAd()
    {
        if (adReward.IsLoaded())
        {
            adReward.Show();
        }
    }
    public void HandleOnRewardedAdLoaded(object sender, EventArgs args)
    {
        ShowRewardAd();

    }

    public void HandleOnRewarded(object sender, EventArgs args)
    {
        int points = PlayerPrefs.GetInt("points");
        points += 10;
        PlayerPrefs.SetInt("points", points);
        TxtPoints.text = points.ToString();

    }
    public void HandleOnRewardedAdClosed(object sender, EventArgs args)
    {
        BtnReward.interactable = true;
        BtnReward.GetComponentInChildren<Text>().text = "More Times";

        adReward.OnAdLoaded -= this.HandleOnRewardedAdLoaded;
        adReward.OnAdRewarded -= this.HandleOnRewarded;
        adReward.OnAdClosed -= this.HandleOnRewardedAdClosed;

        
    }
    #endregion

    public void OnGetMorePointsClicked()
    {
        BtnReward.interactable = false;

        RequestRewardAd();

        gamescreen.SetActive(false);
        Time.timeScale = 1;
        voicerrr.Play();
        

    }
    AdRequest AdRequestBuild()
    {
        return new AdRequest.Builder().Build();

    }
    void OnDestroy()
    {
        adReward.OnAdLoaded -= this.HandleOnRewardedAdLoaded;
        adReward.OnAdRewarded -= this.HandleOnRewarded;

        adReward.OnAdClosed -= this.HandleOnRewardedAdClosed;
        

    }
    
}