using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TakeDamage : MonoBehaviour
{

	public UnityEvent Event;

	void OnTriggerEnter(Collider other)
	{
		other.gameObject.GetComponent<UpdateImageValue>();
	}
	
		
}
