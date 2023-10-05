using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Player : MonoBehaviour
{
    //public float moveSpeed = 5f;
    private Vector2 Velocity;
    private Rigidbody2D rb;
    public float speed;
    //public Animator animator;
    //public Vector3 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 pos = new Vector2(x, y);
        Velocity = pos.normalized * speed;

        //moveInput.x = Input.GetAxis("Horizontal");
        //moveInput.y = Input.GetAxis("Vertical");
        //transform.position += moveInput * moveSpeed * Time.deltaTime;
        //animator.SetFloat("Speed", moveInput.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        Vector2 rbPos = rb.position;
        rbPos += Velocity * Time.fixedDeltaTime;

        Vector2 leftEdge = Camera.main.ScreenToWorldPoint(Vector2.zero);
        Vector2 rightEdge = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        rbPos.x = Mathf.Clamp(rbPos.x, leftEdge.x + 0.5f, rightEdge.x - 0.5f);
        rbPos.y = Mathf.Clamp(rbPos.y, leftEdge.y + 0.5f, rightEdge.y - 0.5f);
        rb.MovePosition(rbPos);
    }
}
