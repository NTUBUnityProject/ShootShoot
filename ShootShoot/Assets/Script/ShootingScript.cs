using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject bulletPrefab; // 子彈實體
    public Transform firePoint; // 發射點

    public float bulletSpeed = 10f; // 子彈速度

    // 按下射擊鍵時觸發
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    // 建立射擊項目
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = firePoint.up * bulletSpeed;
    }
}
