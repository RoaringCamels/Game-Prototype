using UnityEngine;

[System.Serializable]
public class CameraBounds
{
    public float left;
    public float right;
    public float top;
    public float bottom;


    public void UpdateBounds(float newLeft, float newRight, float newTop, float newBottom)
    {
        left = newLeft;
        right = newRight;
        top = newTop;
        bottom = newBottom;
    }
}
