using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float bulletSpeed = 15f;
    void Start()
    {
        
    }

    void Update()
    {
        MoveBullet();
    }
    public void MoveBullet()
    {
        if (transform.rotation.y == 0)
            transform.Translate(transform.right * bulletSpeed * Time.deltaTime);
        else
            transform.Translate(transform.right * -1 * bulletSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
