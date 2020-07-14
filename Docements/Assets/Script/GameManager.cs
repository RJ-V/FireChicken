using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;
    public GameObject player_;
    
    public AudioClip m_musicClip;
    public AudioSource m_audio;
    
    public Transform canvas_menu;

    private bool music;
    private bool menu;

    void Start()
    {
        Instance = this;
        m_audio = this.gameObject.AddComponent<AudioSource>();
        m_audio.clip = m_musicClip;
        m_audio.loop = true;
        m_audio.Play();

        music = true;
        menu = false;
        canvas_menu.gameObject.SetActive(false);
        
    }

    void Update()
    {
        OnChick();
    }

    void OnChick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            var restrt_button = canvas_menu.transform.Find("Button_music").GetComponent<Button>();//音乐播放
            restrt_button.onClick.AddListener(delegate () {
                if (music)
                {
                    print("111");
                    m_audio.Stop();
                    music = false;
                }
                else
                {
                    m_audio.Play();
                    music = true;
                }
            });

            var back_button = canvas_menu.transform.Find("Button_back").GetComponent<Button>();//返回场景
            back_button.onClick.AddListener(delegate () {
                SceneManager.LoadScene("Start");//要切换到的场景名
            });
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            if (!menu)
            {
                Cursor.visible = true;//显示鼠标指针
                canvas_menu.gameObject.SetActive(true);
                menu = true;
            }
            else
            {
                Cursor.visible = false;//隐藏鼠标指针
                canvas_menu.gameObject.SetActive(false);
                menu = false;
            }
        }
    }

}
