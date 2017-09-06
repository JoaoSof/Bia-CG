using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {

	public GameObject Body1,Body2,Body3, Body4,Body5,Body6;
	Rigidbody rb1,rb2,rb3,rb4,rb5,rb6;
	public float ks = 2.0f;
	public float kd = 0.2f;

	public bool clicado = false;
	public float angle1 = 0.0f;
	public float angle2 = 0.0f;
	public float angle3 = 0.0f;
	public float angle4 = 0.0f;
	public float angle5 = 0.0f;
	public float angle6 = 0.0f;

	void Awake(){
		rb1 = Body1.GetComponent<Rigidbody>();
		rb2 = Body2.GetComponent<Rigidbody>();
		rb3 = Body3.GetComponent<Rigidbody>();
		rb4 = Body4.GetComponent<Rigidbody>();
		rb5 = Body5.GetComponent<Rigidbody>();
		rb6 = Body6.GetComponent<Rigidbody>();
	}
		
	// Update is called once per frame
	void Update () {
		//Vector3 force1 = 30*ks*(desiredPos - rb1.position) - 30*kd*(rb1.velocity);
		//rb1.AddForce(force1);
		//float torque1 = 30*ks*(angle1 - Body1.GetComponent<HingeJoint>().angle) - kd*(Body1.GetComponent<HingeJoint>().velocity);
		//rb1.AddTorque(Vector3.forward * torque1);

		float torque2 = 30*ks*(angle2 - Body2.GetComponent<HingeJoint>().angle) - kd*(Body2.GetComponent<HingeJoint>().velocity);
		rb1.AddTorque(Vector3.forward * torque2);
		rb2.AddTorque(Vector3.forward * torque2);
		float torque3 = 30*ks*(angle3 - Body3.GetComponent<HingeJoint>().angle) - kd*(Body3.GetComponent<HingeJoint>().velocity);
		rb3.AddTorque(Vector3.forward * torque3);

		float torque5 = 30*ks*(angle5 - Body5.GetComponent<HingeJoint>().angle) - kd*(Body5.GetComponent<HingeJoint>().velocity);
		rb5.AddTorque(Vector3.forward * torque5);
		float torque6 = 30*ks*(angle6 - Body6.GetComponent<HingeJoint>().angle) - kd*(Body6.GetComponent<HingeJoint>().velocity);
		rb6.AddTorque(Vector3.forward * torque6);

	}

	public void ThrowObjectWithForce( float Power ){

		if (clicado == false) {
			print ("Entrei aqui");
			angle1 = 190.0f;
			angle2 = -52.34f;
			angle3 = -0.9f;

			angle4 = -190.0f;
			angle5 = 52.34f;
			angle6 = 0.9f;
			clicado = true;

		}else {
			print ("Não entrei aqui");
			angle1 = 190.0f;
			angle2 = 85.1f;//34.3f;
			angle3 = 72.15f;//43.3f;

			angle4 = -190.0f;
			angle5 = -85.1f;//34.3f;
			angle6 = -72.15f;//43.3f;

			clicado = false;

		}


		//Vector3 force = new Vector3 ( 1, 0, 0 );
		//rb3.AddForce (force * Power); //rb.AddForce(Vector3.up * Power);
		//rb.AddForce(Vector3.forward * Power);
		//rb.AddForceAtPosition( force * Power, Vector3.right * 10 );
		//rb.AddExplosionForce( Power, Vector3.up, 5.0f );
	}
}
