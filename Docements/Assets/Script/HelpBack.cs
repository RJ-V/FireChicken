using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HelpBack : MonoBehaviour {

    public void OnButtonGameStart()
    {
        SceneManager.LoadScene("Start");//要切换到的场景名
    }
}
