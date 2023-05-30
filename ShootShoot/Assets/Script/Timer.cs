using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float timer;

    void Start()
    {
        //  ��l�ɶ���0
        timer = 0f;
    }

    void Update()
    {
        //  �C��+1
        timer += Time.deltaTime;

        //  �ɶ��W�L1�����H����l���ন����
        int minutes = Mathf.FloorToInt(timer / 60f);

        //  ���
        int seconds = Mathf.FloorToInt(timer % 60f);

        //  �ԥ~��Text������i�ӡA�ñN�r��榡��
        timerText.text = string.Format("{0}:{1:00}", minutes, seconds);
    }
}
