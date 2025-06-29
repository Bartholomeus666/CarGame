using Unity.VisualScripting;
using UnityEngine;

public class TurretTry : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float firePower = 1000f;

    public void Fire()
    {
        GameObject bullet = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        bullet.transform.parent = null;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * firePower);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
}
