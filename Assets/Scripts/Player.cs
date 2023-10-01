using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rd;
    public Animator animator;

    public Vector3 moveInput;

    private void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        //moveInput.y = Input.GetAxis("Vertical");
        transform.position += moveInput * moveSpeed * Time.deltaTime;

        animator.SetFloat("Speed", moveInput.sqrMagnitude);

    }
}
