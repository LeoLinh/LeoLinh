using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rollBoost = 2f;
    bool rollOnce = false;

    private Rigidbody2D rd;
    public Animator animator;

    public SpriteRenderer characterSR;

    public Vector3 moveInput;

    private void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        //moveInput.y = Input.GetAxis("Vertical");
        transform.position += moveInput * moveSpeed * Time.deltaTime;

        //animator.SetFloat("Speed", moveInput.sqrMagnitude);

        //if (moveInput.x != 0)
        //{
        //    if (moveInput.x > 0)
        //    {
        //        characterSR.transform.localScale = new Vector3(1, 1, 0);
        //    }
        //    else
        //        characterSR.transform.localScale = new Vector3(-1, 1, 0);
        //}
    }
}
