using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float amplitude = 1.0f;   // Amplitude of the sine wave.
    public float speed = 1.0f;       // Speed of the vertical movement.

    private Vector2 initialPosition; // Initial position of the NPC.

    private void Start()
    {
        // Store the initial position of the NPC.
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Calculate the vertical movement using a sine wave.
        float verticalMovement = Mathf.Sin(Time.time * speed) * amplitude;

        // Update the NPC's position.
        transform.position = new Vector2(initialPosition.x, initialPosition.y + verticalMovement);
    }
}
