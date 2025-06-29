using UnityEngine;

public class PlaceTurret : MonoBehaviour
{
    private Camera thisCam;

    public GameObject PrefabTurret;
    public GameObject SelectedWeapon;

    public bool IsPutDown = true;

    private void Start()
    {
        thisCam = GetComponent<Camera>();
    }

    public void AddWeapon()
    {
        Ray ray = thisCam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit)/* && hit.collider.gameObject.tag == "Car"*/)
        {
            Quaternion rotation = Quaternion.LookRotation(PrefabTurret.transform.forward, hit.normal);
            Debug.Log("Raycast hit: " + hit.collider.gameObject.name);
            SelectedWeapon = Instantiate(PrefabTurret, hit.point, rotation);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && IsPutDown)
        {
            Debug.Log("Left mouse button clicked.");
            IsPutDown = false;
            AddWeapon();
        }

        if(!IsPutDown)
        {
            CheckInput();
        }
    }

    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SelectedWeapon = null;
            IsPutDown = true;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            SelectedWeapon.transform.Rotate(0, 90, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            SelectedWeapon.transform.Rotate(0, -90, 0);
        }
    }
}
