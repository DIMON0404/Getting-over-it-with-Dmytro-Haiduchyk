using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {

    public bool isTied = false;
    public Vector3 pointTrigger;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        isTied = true;
        pointTrigger = transform.position;
    }
    private void OnTriggerExit(Collider other)
    {
        isTied = false;
    }
}
