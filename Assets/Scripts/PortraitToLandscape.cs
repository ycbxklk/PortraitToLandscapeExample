using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
public class PortraitToLandscape : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	[DllImport("__Internal")]
	private static extern void _portraitToLandscape();

	public static void portraitToLandscape(){
		
		_portraitToLandscape ();
	}


}
