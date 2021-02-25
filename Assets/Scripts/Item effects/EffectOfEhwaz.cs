using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectOfEhwaz : Item
{

    public float speedIncreaseRate = 10;

    void Update()
    {

        GameObject parent = this.transform.parent.gameObject;

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if(parent.tag == "Player" && isEffective){
            player.GetComponent<PlayerMovement>().speed += speedIncreaseRate;
            isEffective = false;
        } else if (takenOff){
            player.GetComponent<PlayerMovement>().speed -= speedIncreaseRate;

            takenOff = false;
            Destroy(gameObject);
        }
    }
}

