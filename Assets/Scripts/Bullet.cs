using UnityEngine;   // BẮT BUỘC PHẢI CÓ

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 20;
    public float lifeTime = 3f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (collision.CompareTag("Enemy"))
    //     {
    //         Health hp = collision.GetComponent<Health>();

    //         if (hp != null)
    //         {
    //             hp.TakeDamage(damage);
    //         }

    //         Destroy(gameObject);
    //     }
    // }

    private void OnTriggerEnter2D(Collider2D collision)
{
    var enemy = collision.GetComponent<EnemyHealth>();

    if (enemy != null)
    {
        Debug.Log("Damage = " + damage);

        enemy.TakeDamage(damage);
    }

    Destroy(gameObject);
}

}
