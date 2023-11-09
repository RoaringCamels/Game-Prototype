using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
    public Transform gun_holder;
    public Transform fire_point;
    public GameObject bullet;

    public float shootCooldown;
    public AudioSource audioSource;
    public AudioClip shootingAudioClip;
    private void Update()
    {
        RotateGunTowardsMouse();
        if (Input.GetMouseButtonDown(0))
        {
            PlayerShoot();
        }
    }

    void RotateGunTowardsMouse()
    {
        if (UnityEngine.Camera.main != null)
        {
            Vector2 mousePosition = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
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
