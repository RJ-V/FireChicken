using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_Chick : MonoBehaviour {
    private float Rx;
    private float Rz;

    public Transform ChickP;

    private float chick_time = 3.0f;
    
	void Update ()
    {
        Rx = Random.Range(-7.0f, 8.5f);
        Rz = Random.Range(-2.0f, 2.0f);
    
       Vector3 relativePos = new Vector3(Rx, transform.position.y, Rz);
        
        chick_time -= Time.deltaTime;
        if (chick_time <= 0)
        {
            Instantiate(ChickP, relativePos, transform.rotation);
            chick_time = 3.0f;
        }

    }
}
