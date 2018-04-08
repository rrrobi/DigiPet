using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PetController : MonoBehaviour {

    public Camera cam;
    public NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.Log("Left click");

            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawRay(ray.origin, ray.direction, Color.blue);
                Debug.Log("ray hit:" + hit.transform.name);
                agent.SetDestination(hit.point);
            }
        }	
	}
}
