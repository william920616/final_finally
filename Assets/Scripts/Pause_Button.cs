using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Button : MonoBehaviour
{
    private bool isPause = true;//标志位，来判断游戏是否需要被暂停
    public GameObject option;//这是我的设置UI界面
    // Update is called once per frame
    void Update()
    {
        //游戏需要被暂停，按下ESC，游戏暂停，显示我的设置UI界面，然后将标志位设置成false，等待下次点击ESC启动游戏
        if (isPause == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                isPause = false;
                option.SetActive(true);
            }
        }
        //游戏不需要被暂停，按下ESC，游戏启动，隐藏我的设置UI界面，然后将标志位设置成true，等待下次点击ESC暂停游戏
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 1;
                isPause = true;
                option.SetActive(false);
            }
        }
    }
}
