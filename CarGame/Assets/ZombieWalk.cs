using UnityEngine;
using UnityEngine.AI;

public class ZombieWalk : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;

    public GameObject Rig;
    public Collider Collider;

    private Collider[] colliders;
    private Rigidbody[] rigidbodies;

    private void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Car").transform;

        colliders = GetComponentsInChildren<Collider>();
        rigidbodies = GetComponentsInChildren<Rigidbody>();

        RagdollOff();
    }
    private void Update()
    {
        agent.SetDestination(target.position);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            RagdollOn();
        }
    }

    public void RagdollOff()
    {
        GetComponent<NavMeshAgent>().enabled = true;
        GetComponent<Animator>().enabled = true;

        foreach (Collider collider in colliders)
        {
            collider.enabled = true;
        }
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.isKinematic = false;
        }
        Collider.enabled = true;
    }
    
    
    
    public void RagdollOn()
    {
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<Animator>().enabled = false;

        foreach (Collider collider in colliders)
        {
            collider.enabled = false;
        }
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.isKinematic = true;
        }
        Collider.enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }
}
