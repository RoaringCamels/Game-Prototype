using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Bullet : MonoBehaviour
{
    public float bullet_speed = 10;
    public float bullet_duration = 2;
    Rigidbody2D bullet_rb;

    public void Awake()
    {
        bullet_rb = GetComponent<Rigidbody2D>();

    }

    public void Start()
    {
        Invoke("DestroyBullet", bullet_duration);
    }

    void FixedUpdate()
    {
        bullet_rb.MovePosition(transform.position + transform.right * bullet_speed * Time.fixedDeltaTime);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
