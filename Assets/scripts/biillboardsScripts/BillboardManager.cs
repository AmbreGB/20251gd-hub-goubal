using UnityEngine;

public class BillboardManager : MonoBehaviour
{
    public GameObject billboard; // The billboard GameObject
    public float heightOffset = 2.0f; // Adjust this to set how high above the NPC the billboard appears

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the triggering object is the player
        {
            billboard.SetActive(true); // Enable the billboard
            PositionBillboard(); // Update its position above the NPC
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            billboard.SetActive(false); // Disable the billboard
        }
    }

    void PositionBillboard()
    {
        // Position the billboard above the NPC
        Vector3 npcPosition = transform.position;
        billboard.transform.position = npcPosition + Vector3.up * heightOffset;
    }
}