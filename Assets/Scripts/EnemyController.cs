using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        Vector2 rbPos = rb.position;
        rbPos += Vector2.down * speed * Time.fixedDeltaTime;
        rb.MovePosition(rbPos);
    }
}
