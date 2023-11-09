using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoundTrigger : MonoBehaviour
{
    public CameraFollow cameraFollow;
    public Vector2 boundsChange;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            cameraFollow.UpdateCameraBounds(boundsChange);
        }
    }
}
