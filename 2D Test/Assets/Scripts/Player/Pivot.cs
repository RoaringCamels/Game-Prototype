using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
    public Transform gun_holder;
    public Transform fire_point;
    public GameObject bullet;

    private void Update()
    {
        RotateGunTowardsMouse();
        PlayerInput();
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

    void PlayerInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, fire_point.position, transform.rotation);
        }
    }
}
