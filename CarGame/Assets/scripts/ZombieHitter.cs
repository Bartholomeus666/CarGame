using UnityEngine;

public class ZombieHitter : MonoBehaviour
{
    [SerializeField] private GameObject piecedPrefab;
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Car")
        {
            ChangeOutPrefab();
        }
    }


    private void ChangeOutPrefab()
    {
        Debug.Log("Changing");
        Instantiate(piecedPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
