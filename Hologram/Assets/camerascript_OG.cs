using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript_b : MonoBehaviour
{
	public Transform target;	
	
	public Vector3 offset;

	void Start()
	{

	}

	void Update()
	{
		Vector3 desiredPosition = target.position + offset;
		transform.position = desiredPosition;
	}
}
