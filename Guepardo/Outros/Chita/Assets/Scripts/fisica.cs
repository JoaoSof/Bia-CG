using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fisica : MonoBehaviour {

	public GameObject Body1,Body2,Body3,Body4,Body5,Body6;
	Rigidbody rb1,rb2,rb3,rb4,rb5,rb6;
	public Vector3 desiredPos = new Vector3(1,1,0);
	private int count1 = 0;
	public bool teclaEB = false;
	public bool teclaAB = false;
	public bool teclaSB = false;
	public bool teclaWB = false;
	public bool teclaQB = false;
	public bool teclaOB = false;
	public bool teclaIB = false;
	public bool teclaJB = false;

	void Awake(){
		rb1 = Body1.GetComponent<Rigidbody>();
		rb2 = Body2.GetComponent<Rigidbody>();
		rb3 = Body3.GetComponent<Rigidbody>();
		rb4 = Body4.GetComponent<Rigidbody>();
		rb5 = Body5.GetComponent<Rigidbody>();
		rb6 = Body6.GetComponent<Rigidbody>();
	}

	void Update(){
		//Pronto
		if(Input.GetKey("z")){
			voltarE ();
		}
			
		//Pronto
		if(Input.GetKey("q")){
			voltarE ();
			teclaQ ();
		}

		//Pronto
		if(Input.GetKey("a")){
			voltarE ();
			teclaA ();
		}

		//Pronto
		if(Input.GetKey("s")){
			voltarE ();
			teclaS ();
		}

		/*---------------------------------------------------------------------------------------------------------------*/
		//Pronto
		if(Input.GetKey("m")){
			voltarD ();
		}

		if(Input.GetKey("i")){
			voltarD ();
			teclaI ();
		}

		if(Input.GetKey("j")){
			voltarD ();
			teclaJ ();
		}

		if(Input.GetKey("o")){
			voltarD ();
			teclaO ();
		}

	}


	//Feito
	void teclaQ(){
		if (teclaQB == false) {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 45;
			rb4.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -150;
			rb5.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 130;
			rb6.GetComponent<HingeJoint> ().spring = springJ3;
		}
		teclaQB = true;
	}

	//Feito
	void teclaA(){
		if (teclaAB == false) {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = -15;
			rb4.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -50;
			rb5.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 90;
			rb6.GetComponent<HingeJoint> ().spring = springJ3;
		}
		teclaQB = true;
	}

	//Feito
	void teclaS(){
		if (teclaSB == false) {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = -15;
			rb4.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -50;
			rb5.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 10;
			rb6.GetComponent<HingeJoint> ().spring = springJ3;
		}
		teclaQB = true;
	}

	void teclaW(){
		if (teclaWB == false) {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = -30;
			rb4.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -40;
			rb5.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = -130;
			rb6.GetComponent<HingeJoint> ().spring = springJ3;
		}
		teclaWB = true;
	}

	void teclaE(){
		if (teclaQB == false) {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = -30;
			rb4.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -40;
			rb5.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 130;
			rb6.GetComponent<HingeJoint> ().spring = springJ3;
		}
		teclaQB = true;
	}

	void teclaO(){
		if (teclaOB == false) {
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 55;
			rb1.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -150;
			rb2.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 130;
			rb3.GetComponent<HingeJoint> ().spring = springJ3;
		}
		teclaOB = true;
	}

	void teclaI(){
		if (teclaIB == false) {
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 50;
			rb1.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -30;
			rb2.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = -130;
			rb3.GetComponent<HingeJoint> ().spring = springJ3;
		}
		teclaIB = true;
	}

	void teclaJ(){
		if (teclaJB == false) {
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = -30;
			rb1.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -90;
			rb2.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = -45;
			rb3.GetComponent<HingeJoint> ().spring = springJ3;
		}
		teclaJB = true;
	}

	void voltarD(){
		JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 0;
		rb1.GetComponent<HingeJoint>().spring = springJ1;
		JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 0;
		rb2.GetComponent<HingeJoint>().spring = springJ2;
		JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 0;
		rb3.GetComponent<HingeJoint>().spring = springJ3;
		teclaIB = false;
		teclaOB = false;
		teclaJB = false;
	}

	void voltarE(){
		JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 0;
		rb4.GetComponent<HingeJoint>().spring = springJ1;
		JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 0;
		rb5.GetComponent<HingeJoint>().spring = springJ2;
		JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 0;
		rb6.GetComponent<HingeJoint>().spring = springJ3;
		teclaQB = false;
		teclaWB = false;
		teclaQB = false;
	}
}