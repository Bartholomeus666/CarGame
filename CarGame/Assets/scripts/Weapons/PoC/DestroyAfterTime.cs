using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public bool TimerBased = false;
    public bool CollisionBased = false;

    public float DestructionTime = 5f; // Time in seconds after which the object will be destroyed

    private void Start()
    {
        if (TimerBased && CollisionBased)
        {
            Debug.LogWarning("Both TimerBased and CollisionBased are enabled. Only one will be used.");
        }
        else if (!TimerBased && !CollisionBased)
        {
            Debug.LogWarning("Neither TimerBased nor CollisionBased is enabled. The object will not be destroyed automatically.");
        }
    }
    private void Update()
    {
        if (TimerBased)
        {
            Destroy(gameObject, DestructionTime); // Destroys the object after 5 seconds
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (CollisionBased && !collision.gameObject.CompareTag("Car"))
        {
            Destroy(gameObject);
        }
    }
}
