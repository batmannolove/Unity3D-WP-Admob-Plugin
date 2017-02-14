using UnityEngine;
using System.Collections;
using Prime31;
using Prime31.WinPhoneAdMob;



public class WinPhoneAdMobDemoUI : MonoBehaviourGUI
{
#if UNITY_WP8
	
	void Start()
	{
				WinPhoneAdMob.createBanner( "ca-app-pub-6962962754220734/5837644807", AdFormat.Banner, AdHorizontalAlignment.Center, AdVerticalAlignment.Top, true );

	}

#endif
}