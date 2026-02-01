using UnityEngine;

public class Dan : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval;
    
    // 1. Thêm biến để điều chỉnh khoảng cách vị trí bắn
    public Vector3 bulletOffset; 
    
    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        // 2. Cộng thêm bulletOffset vào vị trí hiện tại (transform.position)
        Instantiate(bulletPrefabs, transform.position + bulletOffset, transform.rotation);
    }
}