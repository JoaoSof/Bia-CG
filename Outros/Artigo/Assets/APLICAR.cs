using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APLICAR : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		GetComponent<Rigidbody>().AddForce(Vector3.up * 500f);
		//GetComponent<Rigidbody>().AddForce(-transform.forward * 500f);

	}
}
