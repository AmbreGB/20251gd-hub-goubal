using UnityEngine;

public class BillboardManager : MonoBehaviour
{
    public GameObject billboard; 
    public float heightOffset = 2.0f; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            billboard.SetActive(true); 
            PositionBillboard(); 
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            billboard.SetActive(false); 
        }
    }

    void PositionBillboard()
    {
        Vector3 npcPosition = transform.position;
        billboard.transform.position = npcPosition + Vector3.up * heightOffset;
    }
}