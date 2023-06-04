using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 開始遊戲轉場專案
/// </summary>
public class StartGame : MonoBehaviour
{
    public void ViewinTransformation()
    {
        SceneManager.LoadScene("Level");
    }
}
