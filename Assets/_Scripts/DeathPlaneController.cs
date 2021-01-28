using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    public Transform spawnPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var player = other.gameObject.GetComponent<PlayerBehavior>();

            player.controller.enabled = false;

            other.gameObject.transform.position = spawnPoint.transform.position;

            player.controller.enabled = true;
        }
    }
}
