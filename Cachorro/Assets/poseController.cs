using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poseController : MonoBehaviour {

	public GameObject Body1,Body2,Body3, Body4,Body5,Body6;
	public GameObject cheetah;
	Rigidbody rb1,rb2,rb3,rb4,rb5,rb6;

	public GameObject chao;

	public bool pernaFrente = false;
	public bool pernaTras = false;

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
		if(Input.GetKeyDown("e")){
			esticaPernaTras();
		}
		if(Input.GetKeyDown("r")){
			esticaPernaFrente();
		}
		chao.transform.position = new Vector3(Body1.transform.position.x,-0.025f,0.0f);
		if(Body1.transform.position.y < chao.transform.position.y){
			float desl = chao.transform.position.y - Body1.transform.position.y;
			cheetah.transform.position = new Vector3 (cheetah.transform.position.x,
				                                      cheetah.transform.position.y + desl + 1.0f,
													  cheetah.transform.position.z);
		}
		//if (Body1.transform.position.x > 10.0f) {
			chao.GetComponent<MeshRenderer> ().enabled = false;
		//}
	}

	public void esticaPernaFrente( ){
		//*
		if (pernaFrente == false) {
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = -45;
				rb1.GetComponent<HingeJoint>().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 0;
				rb2.GetComponent<HingeJoint>().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 0;
				rb3.GetComponent<HingeJoint>().spring = springJ3;
		}else {
			JointSpring springJ1 = rb1.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 40;
				rb1.GetComponent<HingeJoint>().spring = springJ1;
			JointSpring springJ2 = rb2.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -120;
				rb2.GetComponent<HingeJoint>().spring = springJ2;
			JointSpring springJ3 = rb3.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 130;
				rb3.GetComponent<HingeJoint>().spring = springJ3;
		}
		//*/
		pernaFrente = !pernaFrente;
	}

	public void esticaPernaTras( ){

		if (pernaTras == false) {
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = -45;
			rb4.GetComponent<HingeJoint>().spring = springJ1;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = 0;
			rb5.GetComponent<HingeJoint>().spring = springJ2;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 0;
			rb6.GetComponent<HingeJoint>().spring = springJ3;
		}else {
//			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 40;
			JointSpring springJ1 = rb4.GetComponent<HingeJoint> ().spring; springJ1.targetPosition = 35;
			rb4.GetComponent<HingeJoint>().spring = springJ1;
//			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -120;
			JointSpring springJ2 = rb5.GetComponent<HingeJoint> ().spring; springJ2.targetPosition = -110;
			rb5.GetComponent<HingeJoint>().spring = springJ2;
//			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 130;
			JointSpring springJ3 = rb6.GetComponent<HingeJoint> ().spring; springJ3.targetPosition = 120;
			rb6.GetComponent<HingeJoint>().spring = springJ3;
		}
		//*/
		pernaTras = !pernaTras;
	}

	public void reposicionar(){
		Application.LoadLevel (0);
		//cheetah.transform.position = new Vector3 (0.0f, 1.0f, 0.0f);
	}
}
