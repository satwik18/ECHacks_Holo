using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
	public float mouseSensitivity = 10;
	public Transform target;
	public float dstFromTarget = 2;
	public Vector2 pitchMinMax = new Vector2 (-40, 85);

	public float rotationSmoothTime = 1.2f;
	Vector3 rotationSmoothVelocity;
	Vector3 currentRotation;

	float yaw;
	float pitch;

	void Start()
	{

	}

	void Update()
	{
		yaw+= Input.GetAxis("Mouse X") * mouseSensitivity;
		pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
		pitch = Mathf.Clamp (pitch, pitchMinMax.x, pitchMinMax.y);

		currentRotation = Vector3.SmoothDamp (currentRotation, new Vector3 (pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);
		transform.eulerAngles = currentRotation;

		transform.position = target.position - transform.forward * dstFromTarget;
	}
}
