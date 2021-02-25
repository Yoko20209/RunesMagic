using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [Header("Parameters")]
    [Tooltip("Amount of agility to increace on pickup")]
    public string type;
    public string description;
    public GameObject pickupEffect;
    public Sprite iconForInventory;
    public bool pickedUp = false;


    public bool isEffective = false;
    public bool takenOff = false;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
        }
    }

    public virtual void useEffect(){
        Debug.Log("still in Items");
    }
}
