using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdsController : MonoBehaviour {
	private const bool AD_ENABLED = false;

	string adUnitId = "ca-app-pub-2075382024956161/5666235130";
	BannerView banner;
	// Use this for initialization
	void Start () {
		if (!AD_ENABLED)
			return;

		banner = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
		banner.LoadAd(request);
	}
	
	// Update is called once per frame
	void OnDestroy () {
		if (!AD_ENABLED)
			return;

		if (banner != null)
			banner.Hide ();
	}
}
