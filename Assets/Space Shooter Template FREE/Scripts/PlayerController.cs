using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Cài đặt di chuyển")]
    public float moveSpeed = 10f;

    [Header("Cài đặt bắn đạn")]
    public GameObject bulletPrefab; // Kéo Prefab đạn vào đây
    public Transform firePoint;    // Điểm xuất phát của đạn (đầu phi thuyền)
    public float fireRate = 0.2f;
    private float nextFireTime = 0.0f; // Tên biến đồng nhất

    void Update()
    {
        // 1. Xử lý di chuyển
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // 2. Xử lý bắn đạn liên tục
        // Đổi nextFire thành nextFireTime cho khớp với khai báo ở trên
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFireTime) 
        {
            nextFireTime = Time.time + fireRate; 
            Shoot(); 
        }
    }

    void Shoot()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        }
    }
}