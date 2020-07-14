using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick_Center : MonoBehaviour {

    public Transform center;
    
	void Start () {
		
	}
	
	
	void Update () {
        GetComponent<Rigidbody>().centerOfMass = center.localPosition;
	}
}
