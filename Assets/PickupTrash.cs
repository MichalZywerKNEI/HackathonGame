using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupTrash : MonoBehaviour
{
    public float pickupRange = 1f;
    public Transform trashBin;
    public int pointsPerPickup = 10;
    public Text score;
    private int currentScore = 0;
    private bool inventoryFull = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject closestPickup = FindClosestPickup();

            if (closestPickup != null && !inventoryFull)
            {
                Pickup(closestPickup);
            }
            if (IsCloseToTrashBin() && inventoryFull)
            {
                Dispose();
            }
        }
    }

    GameObject FindClosestPickup()
    {
        GameObject[] pickups = GameObject.FindGameObjectsWithTag("trash");
        GameObject closest = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject pickup in pickups)
        {
            float distance = Vector3.Distance(transform.position, pickup.transform.position);
            if (distance < pickupRange && distance < closestDistance)
            {
                closest = pickup;
                closestDistance = distance;
            }
        }

        return closest;
    }

    void Pickup(GameObject pickup)
    {
        pickup.SetActive(false);
        inventoryFull = true;
    }

    bool IsCloseToTrashBin()
    {
        float distance = Vector3.Distance(transform.position, trashBin.position);
        return distance < pickupRange;
    }

    void Dispose()
    {
        currentScore += pointsPerPickup;
        score.text = $"Score: {currentScore.ToString()}";
        inventoryFull = false;
    }
}