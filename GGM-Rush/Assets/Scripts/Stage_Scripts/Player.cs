using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bulletFactory;
    private float speed = 5f;
    private float jumpPower = 15f;
    private int life = 5;
    Rigidbody2D rigid;
    private bool canJump = false;
    private bool nonDamage = false;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        canJump = false;
    }

    void Update()
    {
        Move();
        Jump();
        SummmonBullet();
    }
    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(h * speed, rigid.velocity.y);

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if ( Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
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
        else if (collision.gameObject.CompareTag("Boss"))
        {
            if (!nonDamage)
            {
                StartCoroutine(SetHPImage());
            }
        }
    }
    public void SummmonBullet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, bulletFactory.transform.position, transform.rotation);
        }
    }
    IEnumerator SetHPImage()
    {
        life--;
        FindObjectOfType<GameManager>().SetLifeIcon(life);
        nonDamage = true;
        yield return new WaitForSeconds(2f);
        nonDamage = false;
        if (life == 0)
        {

        }
        StopCoroutine(SetHPImage());
    }
}
