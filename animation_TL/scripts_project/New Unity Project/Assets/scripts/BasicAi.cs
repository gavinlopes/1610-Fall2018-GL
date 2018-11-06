﻿
using UnityEngine;
using UnityEngine.AI;

public class BasicAi : MonoBehaviour
{
	private NavMeshAgent agent;
	public Transform Destination;
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Destination != null) agent.destination = Destination.position;
	}
}