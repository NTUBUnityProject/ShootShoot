using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 關卡難度專案
/// </summary>

public class LevelText : MonoBehaviour
{
    public Text levelText;
    public Text ScoreText;
    public int Level;

    void Update()
    {
        Level = GetLevel();
        levelText.text = "Level " + Level.ToString();
    }

    public int GetLevel()
    {
        var Score = int.Parse(ScoreText.text);
        var _Level = 0;
        if(Score < 90)
        {
            _Level = (Score/30)+1;
        }
        else if (Score >= 90 && Score < 240)
        {
            _Level = ((Score-90)/50)+4;
        }
        else if (Score >= 240)
        {
            _Level = ((Score-240)/80)+7;
        }  
        return _Level;          
    }
}
