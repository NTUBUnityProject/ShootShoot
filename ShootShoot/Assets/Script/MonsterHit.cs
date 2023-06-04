using UnityEngine;
using UnityEngine.UI;

public class MonsterHit : MonoBehaviour
{
    public Text ScoreText; 
    public int MonsterScore;

    //  這邊被標籤為子彈的物件撞到會扣血消失
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            ScoreBoard.Score += MonsterScore;
            ScoreText.text = (ScoreBoard.Score).ToString();
            Destroy(gameObject);
        }
    }
}
