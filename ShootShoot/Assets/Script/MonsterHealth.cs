using UnityEngine;
using UnityEngine.UI;

public class MonsterHealth : MonoBehaviour
{
    public Text healthText; // Text 对象用于显示生命值
    public Transform headTransform; // 怪物头部的 Transform 组件

    private void Start()
    {
        // 获取或创建 Canvas 对象
        Canvas canvas = GetComponentInChildren<Canvas>();

        // 将 Canvas 设置为 World Space 模式
        canvas.renderMode = RenderMode.WorldSpace;

        // 设置 Canvas 的缩放和位置与怪物头部一致
        canvas.transform.localScale = Vector3.one * 0.02f; // 根据需要调整大小
        canvas.transform.position = headTransform.position;
    }

    public void UpdateHealth(int currentHealth, int maxHealth)
    {
        // 更新生命值文本内容
        healthText.text = currentHealth.ToString() + "/" + maxHealth.ToString();
    }

    //  這邊被標籤為子彈的物件撞到會扣血消失
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
