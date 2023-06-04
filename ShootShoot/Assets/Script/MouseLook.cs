using UnityEngine;

/// <summary>
/// 此為控制角色旋轉的專案
/// </summary>
public class MouseLook : MonoBehaviour
{
    public float rotateSpeed = 20f;
    public Transform cameraTransform;

    void Update()
    {
        // 利用攝影機取得滑鼠指標在畫面上的位置
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = cameraTransform.position.y - transform.position.y;

        // 將滑鼠指標的位置轉換為遊戲內的座標
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // 將目標位置的Y軸與角色保持一致
        targetPosition.y = transform.position.y; 

        // 計算角色朝向目標方向的差額
        Vector3 direction = targetPosition - transform.position;

        if (direction != Vector3.zero)
        {
            // 將角色朝向目標方向
            Quaternion rotation = Quaternion.LookRotation(direction);

            // 旋轉到目標方向
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime);
        }
    }
}