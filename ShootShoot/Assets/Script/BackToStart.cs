using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 返回主畫面
/// </summary>
public class BackToStart : MonoBehaviour
{
    public void ViewinTransformation()
    {
        ScoreBoard.Score = 0;
        SceneManager.LoadScene("SplashScreen");
    }
}
