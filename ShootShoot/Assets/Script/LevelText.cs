﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelText : MonoBehaviour
{
    public Text levelText;
    private float timer;

    void Start()
    {
        timer = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;

        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);

        levelText.text = GetLevelText(minutes, seconds);

        if (minutes >= 4)
        {
            SceneManager.LoadScene("ENDGAME"); // 当时间达到4:00时切换至结束游戏场景
        }
    }

    string GetLevelText(int minutes, int seconds)
    {
        if (minutes == 0 && seconds <= 30)
        {
            return "LEVEL 1";
        }
        else if (minutes == 0 && seconds > 30)
        {
            return "LEVEL 2";
        }
        else if (minutes >= 1 && minutes < 2)
        {
            return "LEVEL 3";
        }
        else
        {
            return "FINAL";
        }
    }
}