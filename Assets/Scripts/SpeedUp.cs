using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [Header("Parameters")]
    [Tooltip("Amount of agility to increace on pickup")]
    public float agilityIncreace;
    public float duration;
    public GameObject pickupEffect;
    public Sprite iconForInventory;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider player)
    {
        Debug.Log("Speedup picked up!");

        Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerMovement movement = player.GetComponent<PlayerMovement>();
        movement.speed *= agilityIncreace;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<SphereCollider>().enabled = false;

        yield return new WaitForSeconds(duration);

        movement.speed /= agilityIncreace;

        Destroy(gameObject);
    }
}
