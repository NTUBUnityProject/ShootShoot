using UnityEngine;
using UnityEngine.UI;   

/// <summary>
/// 怪物越線專案
/// </summary>
public class MonsterDisappear : MonoBehaviour
{
    public Text ScoreText; 
    public int MonsterScore;

    void Update()
    {
        //  判斷z座標 小於-10就消失
        if (transform.position.z < 20)
        {
            ScoreBoard.Score -= MonsterScore;
            ScoreText.text = (ScoreBoard.Score).ToString();
            Destroy(gameObject);
        }
    }
}
