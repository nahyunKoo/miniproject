using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum BTNType
{
    Start,
    HowToPlay,
    BackToStart,
    Exit,
    Continue
}


public class BTNmanager : MonoBehaviour
{
    public BTNType type;
    public CanvasGroup OptionCanvas;

    public void ButtonClick()
    {
        switch (type)
        {
        case BTNType.Start:
                SceneManager.LoadScene("GameScene");
                Debug.Log("게임 시작");
                break;
        case BTNType.HowToPlay:
                GameObject.Find("Start").transform.Find("Canvas").gameObject.SetActive(false);
                GameObject.Find("Discription").transform.Find("DiscriptionCanvas").gameObject.SetActive(true);
                break;
        case BTNType.BackToStart:
                GameObject.Find("Start").transform.Find("Canvas").gameObject.SetActive(true);
                GameObject.Find("Discription").transform.Find("DiscriptionCanvas").gameObject.SetActive(false);
                break;
        case BTNType.Exit:
                break;
        
        }

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (OptionCanvas.alpha == 0)
            {
                OptionCanvas.alpha = 1;
                OptionCanvas.blocksRaycasts = true;
                Debug.Log("설정창");
            }
            else if(OptionCanvas.alpha == 1)
            {
                OptionCanvas.alpha = 0;
                OptionCanvas.blocksRaycasts = false;
                Debug.Log("설정창 닫음");
            }
        }
    }
}
