using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOMBA : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		GetComponent<Rigidbody>().AddForce(Vector3.right * 200f);
	}

}
