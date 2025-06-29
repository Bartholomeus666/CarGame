using UnityEngine;
using UnityEngine.Rendering;

public class CameraMovementBuildingState : MonoBehaviour
{
    public void MoveLeft()
    {
        transform.Rotate(new Vector3(0, 1, 0), -90);
    }

    public void MoveRight()
    {
        transform.Rotate(new Vector3(0, 1, 0), 90);
    }
}
