using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

	public float speed = 20f;
	public Rigidbody starbody;
	

	// Use this for initialization
	IEnumerator Start ()
	{
		starbody.velocity = transform.right * speed;
		yield return new WaitForSeconds(2);
		Destroy(gameObject);
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log(name);
		Destroy(gameObject);
	}
}
