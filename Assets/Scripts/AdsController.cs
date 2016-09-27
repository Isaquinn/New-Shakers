using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdsController : MonoBehaviour {
	string adUnitId = "INSERT_ANDROID_BANNER_AD_UNIT_ID_HERE";
	BannerView banner;
	// Use this for initialization
	void Start () {
		banner = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
		banner.LoadAd(request);
	}
	
	// Update is called once per frame
	void OnDestroy () {
		if (banner != null)
			banner.Hide ();
	}
}
