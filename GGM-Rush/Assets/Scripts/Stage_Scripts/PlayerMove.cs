using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float speed = 5f;
    private float jumpPower = 15f;
    Rigidbody2D rigid;
    private bool canJump = false;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        canJump = false;
    }

    void Update()
    {
        Move();
        Jump();
    }
    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(h * speed, rigid.velocity.y);
    }
    void Jump()
    {
        if (canJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                canJump = false;
                rigid.velocity = Vector2.up * jumpPower;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            canJump = true;
        }
    }
}
