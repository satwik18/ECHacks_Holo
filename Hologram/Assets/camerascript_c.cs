using System.Collections;
using System.Collections.Generic;
using UnitEngine;

public class DragDropScript : MonoBehaviour
{
	public GameObject otherObject;
	
	void Start()
	{

	}

	void Update()
	{
		otherObject.transform.position = transform.transformPoint (10,0,0);
	}
}
