using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = transform.GetChild(0).GetComponent<Camera>();
    }

    void Update()
    {
        
    }

    void Shoot() {
        
    }
}
