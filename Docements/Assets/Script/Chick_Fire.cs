using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick_Fire : MonoBehaviour {

    public GameObject Chick;
    public GameObject BatteryShoot;//炮口
    public Transform batterypoint;
    public GameObject wildfire;

    public AudioSource Fire;
    public AudioClip Boom;

    public GameObject[] Child_BatteryShoot_Name;
    public GameObject Child_BatteryPoint_Name;
    
    public AudioClip m_musicClip;
    public AudioSource m_audio;

    void Start ()
    {
        Fire = this.gameObject.AddComponent<AudioSource>();
        Fire.clip = Boom;
    }

	void Update ()
    {
	}

    void OnTriggerEnter(Collider other)
    {
        //print(other.gameObject.name);
        if (other.gameObject.tag.CompareTo("firechick") == 0)
        {
            if ((other.GetComponent<Chick_Move>().isFire == true))
            {
                GameObject temp =  Instantiate(Chick, BatteryShoot.transform.position, BatteryShoot.transform.rotation);

                temp.GetComponent<Rigidbody>().velocity  = (BatteryShoot.transform.position - batterypoint.transform.position) * 5.0f;

                GameObject fireboom = Instantiate(wildfire, BatteryShoot.transform.position, BatteryShoot.transform.rotation);

                fireboom.GetComponent<Rigidbody>().velocity = (BatteryShoot.transform.position - batterypoint.transform.position) * 5.0f;

                m_audio = this.gameObject.AddComponent<AudioSource>();
                m_audio.clip = m_musicClip;
                m_audio.Play();

                Fire.Play();

                Destroy(other.gameObject);
            }

            
        }

    }
}
