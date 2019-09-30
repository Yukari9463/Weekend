using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    private Camera cam;
    public Camera fpsCam;
    public float damage = 10f;
    public float range = 500f;


    void Start()
    {
        cam = transform.GetChild(0).GetComponent<Camera>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot() {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
