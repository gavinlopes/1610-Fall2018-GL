using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class ninjaStar : MonoBehaviour
{

	public Transform ThrowPoint;
	public GameObject starPrefab;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Launch();
		}	
		
	}

	void Launch()
	{
		Instantiate(starPrefab, ThrowPoint.position, ThrowPoint.rotation);
	}
}
