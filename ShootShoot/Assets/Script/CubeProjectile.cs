using UnityEngine;

/// <summary>
/// 此為控制Cube碰撞反應的專案
/// </summary>
public class CubeProjectile : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //  這邊射擊為撞到標籤為牆壁的物件時將Cube移除
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        //  這邊射擊為撞到標籤為地板的物件時將Cube移除
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }

        //  這邊射擊為撞到標籤為怪物的物件時將Cube移除
        if (collision.gameObject.CompareTag("Monster"))
        {
            Destroy(gameObject);
        }
    }
}
