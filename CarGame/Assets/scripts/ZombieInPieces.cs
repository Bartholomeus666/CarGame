using UnityEngine;

public class ZombieInPieces : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.transform.DetachChildren();
    }
}
