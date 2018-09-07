using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	private WebCamTexture mCamera = null;
	public Material material;

	// Use this for initialization
	void Start ()
	{
			Debug.Log ("Script has been started");
			
			mCamera = new WebCamTexture ();
			material.mainTexture = mCamera;
			mCamera.Play ();
	
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
