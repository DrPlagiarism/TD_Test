using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{

    public NavMeshAgent navMeshAgent;
    public Transform endDestination;
    

	// Use this for initialization
	void Start ()
    {
        navMeshAgent.destination = GameObject.FindGameObjectWithTag("End").transform.position;
        transform.LookAt(endDestination, Vector3.right);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
