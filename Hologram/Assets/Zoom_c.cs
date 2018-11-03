using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom_c : MonoBehaviour
{
	float speed = 5f;
    Vector3 temp;
    float yaw;
    Vector3 currentRotation;
    float zoom_2;

    float rotationSmoothTime = 1.2f;
	Vector3 rotationSmoothVelocity;

	void Start()
	{

	}

	void Update()
	{
        yaw-= Input.GetAxis("Mouse X") * 10;
		temp = transform.localScale;
        zoom_2 = Input.GetAxis("Mouse Y");
        temp.x += zoom_2;
        temp.y += zoom_2;
        temp.z += zoom_2;
        transform.localScale = temp;
        currentRotation = Vector3.SmoothDamp (currentRotation, new Vector3 (0 , yaw), ref rotationSmoothVelocity, rotationSmoothTime);
	}
}
