using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ad : MonoBehaviour
{

    private InterstitialAd interstitial;


    [SerializeField] public string appId = "ca-app-pub-3940256099942544~3347511713";
    [SerializeField] private string bannerId = "ca-app-pub-3940256099942544/6300978111";
    [SerializeField] private string regularAd = "ca-app-pub-3940256099942544/1033173712";

    // Start is called before the first frame update
    void Start()
    {




        RequestInterstitial();




    }

    // Update is called once per frame
    void Update()
    {

    }

    private void RequestInterstitial()
    {



        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(regularAd);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
        this.interstitial.Show();
    }

    private void RequestBanner()
    {
        BannerView bannerView = new BannerView(bannerId, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }
}