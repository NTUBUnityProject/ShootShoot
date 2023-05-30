using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float timer;

    void Start()
    {
        //  初始時間為0
        timer = 0f;
    }

    void Update()
    {
        //  每秒+1
        timer += Time.deltaTime;

        //  時間超過1分鐘以後取餘數轉成分鐘
        int minutes = Mathf.FloorToInt(timer / 60f);

        //  秒數
        int seconds = Mathf.FloorToInt(timer % 60f);

        //  拉外面Text的物件進來，並將字串格式化
        timerText.text = string.Format("{0}:{1:00}", minutes, seconds);
    }
}
