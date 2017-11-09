using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RODAR : MonoBehaviour {
	float x = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.RotateAround (Vector3.up, x);
		//transform.Translate (0.1f, 0, 0);

		//if(Input.GetKeyDown("e"))
			//x += x + 0.1f;
	}

	public void RodarDireita(){
		transform.Rotate (new Vector3(0, 10f, 0));
	}

	public void RodarEsquerda(){
		transform.Rotate (new Vector3(0, -10f, 0));
	}
}
