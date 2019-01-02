using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jogar : MonoBehaviour
{

    [SerializeField] public string appId = "ca-app-pub-6000601527647342~6172913537";
    [SerializeField] private string bannerId = "ca-app-pub-6000601527647342/4128725195";
    [SerializeField] private string regularAd = "ca-app-pub-3940256099942544/1033173712";

    private InterstitialAd interstitial;

    // Start is called before the first frame update
    void Start()
    {

        

        MobileAds.Initialize(appId);
        RequestBanner();



    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)

        {
         SceneManager.LoadScene("fase");

  }

    }

    private void RequestBanner()
    {
        BannerView bannerView = new BannerView(bannerId, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }

    private void RequestInterstitial()
    {



        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(regularAd);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
       
    }







}
