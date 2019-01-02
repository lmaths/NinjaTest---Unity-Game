using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Again : MonoBehaviour
{
    private InterstitialAd interstitial;

   
    public void ChangeScene(string sceneName)
    {
        if (this.interstitial.IsLoaded()) {
            this.interstitial.Show();
        } else
        
        SceneManager.LoadScene(sceneName);
    }

    private void RequestInterstitial()
    {

        string adUnitId = "ca-app-pub-3940256099942544/1033173712";


        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
        this.interstitial.Show();
    }
}
