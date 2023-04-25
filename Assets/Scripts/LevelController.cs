using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 使用 Text 類別必須引入

public class LevelController : MonoBehaviour
{
    public Text countDownTxt; // 文字 UI 元件 (拖曳指定)

    private float sceneTimeMax = 10; // 倒數時間 30 秒
    private float sceneTimeStart = 0; // 記錄進入場景時的秒數

    void Start()
    {
        // 記錄進入場景時的秒數
        sceneTimeStart = Time.time;
    }

    void Update()
    {
        // 計算剩餘秒數
        float timeLeft = sceneTimeMax - (Time.time - sceneTimeStart);
        if (timeLeft <= 0)
        {
            timeLeft = 0;
            countDownTxt.gameObject.SetActive(false);
        }
        if (timeLeft > 0)
        {
            countDownTxt.gameObject.SetActive(true);
        }

        // 更新倒數計時 UI (四捨五入到小數第一位)
        countDownTxt.text = (Mathf.Round(timeLeft * 1) / 1).ToString();
        
       
    }
}
