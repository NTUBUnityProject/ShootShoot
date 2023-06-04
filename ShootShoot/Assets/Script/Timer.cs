using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float timer;
    public Text ScoreText;

    void Start()
    {
        //  時間
        timer = 180;
    }

    void Update()
    {
        //  時間+1
        timer -= Time.deltaTime;

        //  轉換為分
        int minutes = Mathf.FloorToInt(timer / 60f);

        //  除以60取餘數為秒
        int seconds = Mathf.FloorToInt(timer % 60f);

        //  用字串格式化的方式定義格式
        timerText.text = string.Format("{0}:{1:00}", minutes, seconds);
        if(timer < 15){
            timerText.color = Color.red;
        }
        if(minutes == 0 && seconds == 0)
        {            
            //結束遊戲
            SceneManager.LoadScene("EndGame");
        }
    }
}
