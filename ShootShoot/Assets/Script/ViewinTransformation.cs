using UnityEngine;
using UnityEngine.SceneManagement;

public class ViewinTransformation : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level");
    }
}
