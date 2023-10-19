using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTrash : MonoBehaviour
{
    //public Transform Player; //uzywajcie transform zamiast Player
    public float pickupRange = 2f;
    public Transform trashBin;
    public int pointsPerPickup = 10;

    private void Update()
    {
        // Sprawdzanie, czy gracz nacisnął klawisz spacji
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Znajdź najbliższe dostępne śmieci
            GameObject closestPickup = FindClosestPickup();

            // Jeśli znaleziono dostępne śmieci w zasięgu
            if (closestPickup != null)
            {
                // Podnieś śmieci
                Pickup(closestPickup);

                // Jeśli gracz jest wystarczająco blisko śmietnika, wrzuć śmieci
                if (IsCloseToTrashBin())
                {
                    Dispose();
                }
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
        pickup.SetActive(false); // Schowaj śmieci
    }

    bool IsCloseToTrashBin()
    {
        float distance = Vector3.Distance(transform.position, trashBin.position);
        return distance < pickupRange;
    }

    void Dispose()
    {
        // Tu możesz dodać kod, który przyznaje punkty
    }
}
