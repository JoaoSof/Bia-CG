using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fisica : MonoBehaviour {

	public GameObject Body1,Body2,Body3;
	Rigidbody rb1,rb2,rb3;
	public float ks = 2.0f;
	public float kd = 0.2f;
	public Vector3 desiredPos = new Vector3(1,1,0);
	public float angle1 = 0.0f;
	public float angle2 = 0.0f;
	public float angle3 = 0.0f;

	public bool clicado = false;


	void Awake(){
		rb1 = Body1.GetComponent<Rigidbody>();
		rb2 = Body2.GetComponent<Rigidbody>();
		rb3 = Body3.GetComponent<Rigidbody>();
	}

	void Update(){
		//Vector3 force1 = 30*ks*(desiredPos - rb1.position) - 30*kd*(rb1.velocity);
		//rb1.AddForce(force1);
		float torque1 = 30*ks*(angle1 - rb1.rotation.eulerAngles.z) - kd*(rb1.angularVelocity.z);
		rb1.AddTorque(Vector3.forward * torque1);

		float torque2 = 30*ks*(angle2 - Body2.GetComponent<HingeJoint>().angle) - kd*(Body2.GetComponent<HingeJoint>().velocity);
		rb2.AddTorque(Vector3.forward * torque2);
		float torque3 = 30*ks*(angle3 - Body3.GetComponent<HingeJoint>().angle) - kd*(Body3.GetComponent<HingeJoint>().velocity);
		rb3.AddTorque(Vector3.forward * torque3);
	}

	public void ThrowObjectWithForce( float Power ){

		if (clicado == false) {

			angle1 = 90.0f;
			angle2 = -52.34f;
			angle3 = -0.9f;

			clicado = true;

		}else {

			angle1 = 90.0f;
			angle2 = 85.1f;//34.3f;
			angle3 = 72.15f;//43.3f;

			clicado = false;

		}


		//Vector3 force = new Vector3 ( 1, 0, 0 );
		//rb3.AddForce (force * Power); //rb.AddForce(Vector3.up * Power);
		//rb.AddForce(Vector3.forward * Power);
		//rb.AddForceAtPosition( force * Power, Vector3.right * 10 );
		//rb.AddExplosionForce( Power, Vector3.up, 5.0f );
	}
}
