using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 分數結算
/// </summary>
public class EndGameScore : MonoBehaviour
{
    public Text ScoreText;

    void Start()
    {
        ScoreText.text = (ScoreBoard.Score).ToString();
    }    
}
