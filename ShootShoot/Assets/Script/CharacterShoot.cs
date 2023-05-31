using UnityEngine;

/// <summary>
/// 此為角色射擊、生成火球及設定火球初始速度的專案
/// </summary>
public class CharacterShoot : MonoBehaviour
{
    /// <summary>
    /// 火球的物件
    /// </summary>
    public GameObject FireBall;

    /// <summary>
    /// 子彈速度，設50以上看起來比較有速度感
    /// </summary>
    public float speed = 50f;

    void Update()
    {
        // 滑鼠左鍵點擊事件
        if (Input.GetMouseButtonDown(0))  
        {
            // 在角色前方生成 Cube，營造發射火球的概念，利用position跟forward才能讓子彈朝斜前方飛行
            Vector3 cubePosition = transform.position + transform.forward;

            // 保持 Cube 的高度(y)為 3，避免直接撞到地板消失
            cubePosition.y = 3f; 
            GameObject cube = Instantiate(FireBall, cubePosition, Quaternion.identity);
            Rigidbody cubeRigidbody = cube.GetComponent<Rigidbody>();

            if (cubeRigidbody != null)
            {
                // 設定火球的初始速度
                Vector3 cubeVelocity = transform.forward * speed;
                cubeVelocity.y = 0f; // 將y軸速度設為 0
                cubeRigidbody.velocity = cubeVelocity;
            }
        }
    }
}
