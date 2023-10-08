using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBall : MonoBehaviour
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

    protected int hp;
    public int countHit;

    public virtual void preset()
    {
        //atk = 4;
    }
    public virtual void Update()
    {
        if (GameManager.Instance.isPausing)
        {
            return;
        }
        Move();
    }

    private void Start()
    {
        preset();
    }

    public virtual void Move()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
        }
    }

    public virtual void CheckDie()
    {
        countHit++;
        if (countHit == hp)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        // H?y ??i t??ng Enemy khi b? tiêu di?t
        Debug.Log("Work");
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Debug.Log("Visable");
        Destroy(gameObject);
    }
}
