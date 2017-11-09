using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour 
{
	float rotaSpeed = 20;

	void OnMouseDrag()
	{
		float rotX = Input.GetAxis ("Mouse X") * rotaSpeed * Mathf.Deg2Rad;
		float rotY = Input.GetAxis ("Mouse Y") * rotaSpeed * Mathf.Deg2Rad;

		transform.RotateAround(Vector3.up, -rotX);
		transform.RotateAround(Vector3.right, rotY);
	}
}
