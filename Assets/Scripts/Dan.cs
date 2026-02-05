using UnityEngine;

public class Dan : MonoBehaviour
{
    [Header("Bullet Settings")]
    public GameObject bulletPrefabs;   // Prefab đạn
    public float shootingInterval = 0.2f; // Thời gian giữa 2 lần bắn

    [Header("Shoot Position")]
    public Vector3 bulletOffset = new Vector3(0, 1f, 0); // Vị trí bắn

    private float lastBulletTime;

    void Update()
    {
        // Giữ chuột trái để bắn
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time - lastBulletTime >= shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        // Kiểm tra có gán prefab chưa
        if (bulletPrefabs == null)
        {
            Debug.LogError("Bullet Prefab is NULL! Chưa gán Bullet vào Dan.cs");
            return;
        }

        // Tính vị trí bắn
        Vector3 spawnPos = transform.position + bulletOffset;

        // Tạo đạn
        GameObject bullet = Instantiate(
            bulletPrefabs,
            spawnPos,
            Quaternion.identity   // Không xoay → bay thẳng lên
        );

        Debug.Log("Shoot bullet!");
    }
}
