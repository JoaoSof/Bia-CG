using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fisica : MonoBehaviour {

	public GameObject Body1,Body2,Body3,Body4,Body5,Body6;
	Rigidbody rb1,rb2,rb3,rb4,rb5,rb6;
	public Vector3 desiredPos = new Vector3(1,1,0);
	private int count1 = 0;
	public bool teclaQB = false;
	public bool teclaWB = false;
	public bool teclaEB = false;
	public bool teclaOB = false;
	public bool teclaIB = false;

	void Awake(){
		rb1 = Body1.GetComponent<Rigidbody>();
		rb2 = Body2.GetComponent<Rigidbody>();
		rb3 = Body3.GetComponent<Rigidbody>();
		rb4 = Body4.GetComponent<Rigidbody>();
		rb5 = Body5.GetComponent<Rigidbody>();
		rb6 = Body6.GetComponent<Rigidbody>();
	}

	void Update(){
		if(Input.GetKey("e")){
			teclaE ();
		}

		if(Input.GetKey("w")){
			teclaW ();
		}

		if(Input.GetKey("i")){
			teclaI ();
		}

		if(Input.GetKey("o")){
			teclaO ();
		}

	}


	void teclaE(){
		if (teclaEB == false) {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 55;
			rb4.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -150;
			rb5.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 130;
			rb6.GetComponent<HingeJoint> ().spring = springJ3;
		} else {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 0;
			rb4.GetComponent<HingeJoint>().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 0;
			rb5.GetComponent<HingeJoint>().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 0;
			rb6.GetComponent<HingeJoint>().spring = springJ3;
		}
		teclaEB = !teclaEB;
	}

	void teclaW(){
		if (teclaWB == false) {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = -30;
			rb4.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -40;
			rb5.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = -130;
			rb6.GetComponent<HingeJoint> ().spring = springJ3;
		} else {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 0;
			rb4.GetComponent<HingeJoint>().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 0;
			rb5.GetComponent<HingeJoint>().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 0;
			rb6.GetComponent<HingeJoint>().spring = springJ3;
		}
		teclaWB = !teclaWB;
	}

	void teclaQ(){
		if (teclaQB == false) {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = -30;
			rb4.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -40;
			rb5.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 130;
			rb6.GetComponent<HingeJoint> ().spring = springJ3;
		} else {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 0;
			rb4.GetComponent<HingeJoint>().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 0;
			rb5.GetComponent<HingeJoint>().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 0;
			rb6.GetComponent<HingeJoint>().spring = springJ3;
		}
		teclaQB = !teclaQB;
	}

	void teclaO(){
		if (teclaOB == false) {
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 55;
			rb1.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -150;
			rb2.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 130;
			rb3.GetComponent<HingeJoint> ().spring = springJ3;
		} else {
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 0;
			rb1.GetComponent<HingeJoint>().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 0;
			rb2.GetComponent<HingeJoint>().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 0;
			rb3.GetComponent<HingeJoint>().spring = springJ3;
		}
		teclaOB = !teclaOB;
	}

	void teclaI(){
		if (teclaIB == false) {
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = -30;
			rb1.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -40;
			rb2.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = -130;
			rb3.GetComponent<HingeJoint> ().spring = springJ3;
		} else {
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 0;
			rb1.GetComponent<HingeJoint>().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 0;
			rb2.GetComponent<HingeJoint>().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 0;
			rb3.GetComponent<HingeJoint>().spring = springJ3;
		}
		teclaIB = !teclaIB;
	}
}