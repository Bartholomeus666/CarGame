using UnityEngine;
using UnityEngine.Rendering;

public class CameraMovementBuildingState : MonoBehaviour
{

    public GameObject Car;
    public GameObject Camera;

    private void Start()
    {
        Camera = FindAnyObjectByType<Camera>().gameObject;
        Camera.transform.SetParent(transform, true);
    }

    public void MoveLeft()
    {
        transform.Rotate(new Vector3(0, 1, 0), -90);
    }

    public void MoveRight()
    {
        transform.Rotate(new Vector3(0, 1, 0), 90);
    }
}
