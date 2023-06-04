using UnityEngine;

/// <summary>
/// 怪物移動專案
/// </summary>
public class MonsterMovement : MonoBehaviour
{
    public float speed ; // 怪物的移动速度

    void Update()
    {
        // 朝Z軸方向移動(玩家的方向)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}