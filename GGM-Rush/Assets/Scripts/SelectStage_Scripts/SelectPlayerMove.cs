using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayerMove : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rigid;
    Animator anim;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
    }
    public void Move()
    {
        anim.SetBool("Back", Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow));
        anim.SetBool("Front", Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow));
        anim.SetBool("Right", Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow));
        anim.SetBool("Left", Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow));
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rigid.velocity = input * speed;
    }
}
