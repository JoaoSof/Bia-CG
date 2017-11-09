using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		GetComponent<Rigidbody> ().velocity = new Vector3(0,0,0);
	}

	public void Subir(){
		GetComponent<Rigidbody> ().AddForce (Vector3.up*250);
	}

	public void Avancar(){
		GetComponent<Rigidbody> ().AddForce (Vector3.forward *250);
	}

	public void Voltar(){
		GetComponent<Rigidbody> ().AddForce (Vector3.back *250);
	}

	public void Esquerda(){
		GetComponent<Rigidbody> ().AddForce (Vector3.left *250);
	}

	public void Direita(){
		GetComponent<Rigidbody> ().AddForce (Vector3.right *250);
	}
}
