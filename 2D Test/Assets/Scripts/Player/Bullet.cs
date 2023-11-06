using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Bullet : MonoBehaviour
{
    public float bullet_speed = 4;
    public float bullet_duration = 2;
    Rigidbody2D bullet_rigidbody;

    private void Awake()
    {
        bullet_rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Invoke("DestroyBullet", bullet_duration);
    }

    private void FixedUpdate()
    {
        bullet_rigidbody.MovePosition(transform.position + transform.right * bullet_speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
{
    // Check if the collision is with an object that has a specific tag.
    if (collision.collider.CompareTag("BackgroundCollision"))
    {
        DestroyBullet();
    }
}


    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
