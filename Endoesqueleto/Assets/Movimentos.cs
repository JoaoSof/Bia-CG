using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentos : MonoBehaviour {

	public GameObject Body1,Body2,Body3, Body4,Body5,Body6;
	Rigidbody rb1,rb2,rb3,rb4,rb5,rb6;
	bool s = true, c = true;
	void Awake(){
		rb1 = Body1.GetComponent<Rigidbody>();
		rb2 = Body2.GetComponent<Rigidbody>();
		rb3 = Body3.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("i")){
			inicial();
		}
		if(Input.GetKeyDown("s")){
			socarLateralmente();
		}
		if(Input.GetKeyDown("c")){
			continencia ();
		}
	}

	public void inicial(){
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring;
			springJ1.targetPosition = 0;
			rb1.GetComponent<HingeJoint> ().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring;
			springJ2.targetPosition = 0;
			rb2.GetComponent<HingeJoint> ().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring;
			springJ3.targetPosition = 0;
			rb3.GetComponent<HingeJoint> ().spring = springJ3;
	}

	public void socarLateralmente(){
		if(s == true){
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 100;
			rb1.GetComponent<HingeJoint>().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 45;
			rb2.GetComponent<HingeJoint>().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 45;
			rb3.GetComponent<HingeJoint>().spring = springJ3;
		}else{
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 0;
			rb1.GetComponent<HingeJoint>().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 0;
			rb2.GetComponent<HingeJoint>().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 0;
			rb3.GetComponent<HingeJoint>().spring = springJ3;
		}
		s = !s;
	}

	public void continencia(){
		if(c == true){
			rb1.GetComponent<HingeJoint>().axis = new Vector3(0f, 0f, 1f);
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 100;
			rb1.GetComponent<HingeJoint>().spring = springJ1;
			rb2.GetComponent<HingeJoint>().axis = new Vector3(0f, 0f, 1f);
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 120;
			rb2.GetComponent<HingeJoint>().spring = springJ2;
		}else{
			rb1.GetComponent<HingeJoint>().axis = new Vector3(0f, 0f, 1f);
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = -100;
			rb1.GetComponent<HingeJoint>().spring = springJ1;
			rb2.GetComponent<HingeJoint>().axis = new Vector3(0f, 0f, 1f);
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -120;
			rb2.GetComponent<HingeJoint>().spring = springJ2;
		}
		c = !c;
	}
}
