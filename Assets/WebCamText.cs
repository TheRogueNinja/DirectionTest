using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamText : MonoBehaviour {

	public GameObject webCamPlane;
	// Use this for initialization
	void Start () {
		if(Application.isMobilePlatform){
			GameObject camParent = new GameObject("camParent");
			camParent.transform.position = this.transform.position;
			this.transform.parent = camParent.transform;
		}
		Input.gyro.enabled = true;
		WebCamTexture webCamT = new WebCamTexture();
		webCamPlane.GetComponent<MeshRenderer>().material.mainTexture = webCamT;
		webCamT.Play();
		
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion camRot = new Quaternion(Input.gyro.attitude.x,Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
		this.transform.localRotation = camRot;
	}
}
