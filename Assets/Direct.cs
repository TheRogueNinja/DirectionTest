using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direct : MonoBehaviour {

	public GameObject Arrow;
	private Transform currentLoc = null, directLoc = null;
	// Use this for initialization
	void Start () {
		//currentLoc.position = Arrow.transform.position;
		Debug.Log(Arrow.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		//directLoc.position = Input.mousePosition;
		Debug.Log(Input.mousePosition);
		transform.rotation = Quaternion.FromToRotation(Arrow.transform.position,Input.mousePosition);
	}
}
