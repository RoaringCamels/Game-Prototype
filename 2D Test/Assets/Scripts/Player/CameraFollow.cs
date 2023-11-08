using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public CameraBounds cameraBounds;

    private void FixedUpdate()
    {
        if (transform.position != target.position)
        {
            Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);
            targetPos.x = Mathf.Clamp(targetPos.x, cameraBounds.left, cameraBounds.right);
            targetPos.y = Mathf.Clamp(targetPos.y, cameraBounds.bottom, cameraBounds.top);

            transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
        }
    }

    public void UpdateCameraBounds(float newLeft, float newRight, float newTop, float newBottom)
    {
        cameraBounds.UpdateBounds(newLeft, newRight, newTop, newBottom);
    }
}
