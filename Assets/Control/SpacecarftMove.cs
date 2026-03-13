using UnityEngine;

public class SpacecarftMove : MonoBehaviour
{
    public float speed = 5f; // ¼Óµµ
    public float bullletspeed = 10f; // ÃÑ¾Ë ¼Óµµ
    public GameObject BulletPrefab; // ÃÑ¾Ë ÇÁ¸®ÆÕ
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Fire();
    }

    void Fire()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
            Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
            rigid.AddForce(Vector2.up * bullletspeed, ForceMode2D.Impulse);
        }
    }
    void Move()
    {
        Vector2 dir = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
            dir += new Vector2(0f, 1f);

        if (Input.GetKey(KeyCode.S))
            dir += new Vector2(0f, -1f);

        if (Input.GetKey(KeyCode.A))
            dir += new Vector2(-1f, 0f);

        if (Input.GetKey(KeyCode.D))
            dir += new Vector2(1f, 0f);

        transform.Translate(dir * speed * Time.deltaTime);

    }

}
