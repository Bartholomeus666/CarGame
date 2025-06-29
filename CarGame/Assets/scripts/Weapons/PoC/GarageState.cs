using UnityEngine;
using UnityEngine.InputSystem;

public class GarageState : MonoBehaviour
{
    public Camera Camera;
    PlayerInput input;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);

        if(other.gameObject.CompareTag("Car"))
        {
            Debug.Log("IN IF");

            input = other.transform.parent.GetComponentInChildren<PlayerInput>();
            input.enabled = false;

            Camera.gameObject.SetActive(true);

        }
    }
}
