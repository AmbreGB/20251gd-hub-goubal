using UnityEngine;

public class BillboardSetUp: MonoBehaviour
{
    void LateUpdate()
    {
        transform.LookAt(Camera.main.transform);
        transform.Rotate(0, 180, 0); // Flip if needed
    }
}
