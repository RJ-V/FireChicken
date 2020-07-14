using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public float speed = 5;

    void Start()
    {
        Cursor.visible = false;//隐藏鼠标指针
    }

    void Update()
    {
        //鼠标在这一帧移动的水平距离
        float x = Input.GetAxis("Mouse X");
        //绕世界坐标中的y轴旋转
        transform.Rotate(Vector3.up * x * speed, Space.World);
        //鼠标在这一帧移动的垂直距离
        float y = Input.GetAxis("Mouse Y");
        //绕自身的x轴转
        transform.Rotate(Vector3.right * -y * speed);
    }

}
