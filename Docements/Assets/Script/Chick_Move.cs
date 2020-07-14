using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick_Move : MonoBehaviour {

    private float chick_speed = 1.0f;
    private float chick_rotate = 5.0f;
    
    private Quaternion rotate;

    private Transform chick_transform; //鸡的坐标
    public Rigidbody chick_rigidbody; //鸡的刚体

    private int dd;
    private int flag;
    private float chick_time = 1.0f; //固定时间间隔
    //private float chick_way = 5.0f;//固定移动距离

   // Vector3 cc;
    private Transform player;
    private Transform hand;

    public bool isFire;
    ///private Transform player_transform;

    public AudioClip m_musicClip;
    public AudioSource m_audio;

    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
        hand = GameObject.FindGameObjectWithTag("Hand").GetComponent<Transform>();
        chick_rigidbody = GetComponent<Rigidbody>();
        chick_transform = this.transform;
       
        dd = 0;
        flag = 0;

        isFire = false;
        //Invoke("Move", 2.0f);
    }

    void Update()
    {
        //  Vector3 temp = player.position;
        //碰撞改变后的坐标，为角色的当前坐标
        //cc = new Vector3(player_transform.position.x,
        //  player_transform.position.y, player_transform.position.z + 0.5f);

        //transform.position = player.position + new Vector3(1.2f, 0.0f, 0.0f);
        //transform.RotateAround(player.position, player.up, player.rotation.y);
        Move();
        
    }

    void Move()
    {
        if (flag == 0)
        {
            rotate = Random.rotation;//rotate取随机值
           
            Vector3 roatation = new Vector3(0.0f, rotate.eulerAngles.y, 0.0f);
            transform.Rotate(roatation * chick_rotate * Time.deltaTime);
            flag = 1;
        }

        else if (flag == 1)
        {
            transform.Translate(Vector3.forward * chick_speed * Time.deltaTime);

            chick_time -= Time.deltaTime;
            if (chick_time <= 0)
            {
                flag = 0;
                chick_time = 1.0f;
            }
        }
        /*chick_time -= Time.deltaTime;
        if(chick_time <= 0)
        {
            float cx = Random.Range(-7.3f, 8.9f);
            float cz = Random.Range(-3.0f, 3.2f);

            //Vector3 tras = transform.position - new Vector3(cx,0.0f,cz);

            transform.position = Vector3.MoveTowards(transform.position, 
                new Vector3(cx, 1.1f, cz), chick_speed * Time.deltaTime);

            chick_time = 5.0f;
        }*/

        /*if (chick_time <= 0)
        {
            rotate = Random.rotation;//rotate取随机值
            Vector3 roatation = new Vector3(0.0f, rotate.eulerAngles.y, 0.0f);

            transform.Rotate(roatation * chick_rotate * Time.deltaTime);

            chick_time = 5.0f;
        }
        transform.Translate(Vector3.forward * chick_speed * Time.deltaTime);*/
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.CompareTo("Sea") == 0)
        {
            Destroy(this.gameObject);
        }

        if (other.tag.CompareTo("Hand") == 0)
        {
            //if(Input.GetMouseButtonDown(0)||Input.GetKey(KeyCode.C))
            
                m_audio = this.gameObject.AddComponent<AudioSource>();
                m_audio.clip = m_musicClip;
                m_audio.Play();
                
                this.tag = "firechick";
                chick_rigidbody.isKinematic = true;
                    
                flag = 3;
                dd = 1;

                print("catch");
                this.transform.parent = player.transform;
                transform.position = hand.position + new Vector3(0.0f, 0.5f, 0.8f);
         
            
        }

        if(other.tag.CompareTo("Battery") == 0 && dd == 1)
        {
            isFire = true;
        }
    }
}
