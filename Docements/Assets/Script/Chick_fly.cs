using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick_fly : MonoBehaviour {
    
    private Rigidbody rd;
    private float modifer = 5.0f;
    void Start ()
    {
        Destroy(this.gameObject, 3.0f);
    }
	void Update () {
	}

}
