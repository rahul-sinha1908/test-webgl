using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class CameraScript : MonoBehaviour {

	private WebCamTexture mCamera = null;
	public Material material;

	[DllImport ("TestLibrary")]
	public static extern int add(int x, int y);

	// Use this for initialization
	void Start ()
	{
			Debug.Log ("Script has been started");
			
			mCamera = new WebCamTexture ();
			material.mainTexture = mCamera;
			mCamera.Play ();

			Debug.Log("Print Value : "+add(10, 10));
	
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.F))
		{
			// Get highest resolution supported by the current screen.
			var resolution = Screen.resolutions[Screen.resolutions.Length - 1];
			
			// The last parameter "true" denotes if it should be fullscreen or not.
			Screen.SetResolution(resolution.width, resolution.height, true);
		}
	}

}
