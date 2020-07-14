using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    private float moveSpeed = 5.0f;

    private Transform m_transform; //角色的坐标
    private Rigidbody m_rigidbody; //角色的刚体
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        m_transform = this.transform;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag.CompareTo("Sea") == 0)
        {
            // Destroy(GetComponent<Rigidbody>());
            //m_rigidbody.isKinematic = true;
            this.transform.position = new Vector3(0, 10, 0);
            
        }
    }
}
