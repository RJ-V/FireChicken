using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[AddComponentMenu("Scene/Help")]
public class GameHelp : MonoBehaviour {

    public void OnButtonGameStart()
    {
        SceneManager.LoadScene("Help");//要切换到的场景名
    }
}
