using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableFireAbility : MonoBehaviour
{

//     // public override void Interact(){
//     //     Debug.Log("override Interacted");
//     //     base.Interact(Collider);
//     // }
    public GameObject pickupEffect;
//     // public Item item;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        
        Debug.Log("kenaz picked up!");
        Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerAbilities abilities = player.GetComponent<PlayerAbilities>();
        abilities.fireAbility = true;

//         // item.name
    
        
        Destroy(gameObject);
    }
}
