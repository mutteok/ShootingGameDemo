using UnityEngine;

public class BulletControl : MonoBehaviour
{

    void Start()
    {
        Destroy(gameObject, 2f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // 적 오브젝트 파괴
            Destroy(gameObject); // 총알 오브젝트 파괴
        }
    }
}