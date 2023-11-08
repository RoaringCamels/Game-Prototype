using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoundTrigger : MonoBehaviour
{
    public CameraFollow cameraFollow;
    public float newLeftBounds;
    public float newRightBounds;
    public float newTopBounds;
    public float newBottomBounds;

    public Vector3 playerPositionChange;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // update camera position
            cameraFollow.UpdateCameraBounds(newLeftBounds, newRightBounds, newTopBounds, newBottomBounds);

            // Update player position
            other.transform.position += playerPositionChange;
        }
    }
}
