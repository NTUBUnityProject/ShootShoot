using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public float speed = 5f; // 怪物的移动速度

    void Update()
    {
        // 沿Z轴方向移动
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}