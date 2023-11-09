using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
    public Transform gun_holder;
    public Transform fire_point;
    public GameObject bullet;
    public AudioSource audioSource;
    public AudioClip shootingAudioClip;

    private float nextShootTime = 0.0f; // Time when the next shot is allowed
    public float shootCooldown = 0.5f;

    private void Update()
    {
        RotateGunTowardsMouse();

        // Check if the left mouse button is held down and the cooldown time has passed.
        if (Input.GetMouseButton(0) && Time.time >= nextShootTime)
        {
            PlayerShoot();
            nextShootTime = Time.time + shootCooldown;
        }
    }

    void RotateGunTowardsMouse()
    {
        if (Camera.main != null)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePosition - (Vector2)gun_holder.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else
        {
            Debug.LogError("Main camera not found");
        }
    }

    void PlayerShoot()
    {
        audioSource.PlayOneShot(shootingAudioClip);
        Instantiate(bullet, fire_point.position, transform.rotation);
    }
}
