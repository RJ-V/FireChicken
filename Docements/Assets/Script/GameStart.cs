using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[AddComponentMenu("Scene/Start")]
public class GameStart : MonoBehaviour
{

    public void OnButtonGameStart()
    {
        SceneManager.LoadScene("SampleScene");//要切换到的场景名
    }
}
