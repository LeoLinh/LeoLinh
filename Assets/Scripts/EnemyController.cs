using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    //private Rigidbody2D rb;
    //private void Awake()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}
    //private void FixedUpdate()
    //{
    //    Vector2 rbPos = rb.position;
    //    rbPos += Vector2.down * speed * Time.fixedDeltaTime;
    //    rb.MovePosition(rbPos);
    //}
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
        }
    }
    public void Die()
    {
        // Hủy đối tượng Enemy khi bị tiêu diệt
        Destroy(gameObject);
    }
}
