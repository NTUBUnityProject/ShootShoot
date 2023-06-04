using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 此為控制Cube碰撞反應的專案
/// </summary>
public class CubeProjectile : MonoBehaviour
{
    public Text ScoreText; 
    private void OnTriggerEnter(Collider other)
    {
        //  這邊射擊為撞到標籤為牆壁的物件時將Cube移除
        if (other.gameObject.CompareTag("Wall"))
        {
            ScoreBoard.Score -= 1;
            ScoreText.text = (ScoreBoard.Score).ToString();
            Destroy(gameObject);
        }
        //  這邊射擊為撞到標籤為地板的物件時將Cube移除
        if (other.gameObject.CompareTag("Floor"))
        {
            ScoreBoard.Score -= 1;
            ScoreText.text = (ScoreBoard.Score).ToString();
            Destroy(gameObject);
        }
        //  這邊射擊為撞到標籤為怪物的物件時將Cube移除
        if (other.gameObject.CompareTag("Monster"))
        {
            Destroy(gameObject);
        }
    }
    
}
