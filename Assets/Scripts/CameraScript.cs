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

	}

}
