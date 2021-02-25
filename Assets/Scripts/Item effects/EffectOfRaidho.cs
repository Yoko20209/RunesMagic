using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectOfRaidho : Item
{

    public float jumpHeightIncrease = 5;

    // // Update is called once per frame
    void Update()
    {

        GameObject parent = this.transform.parent.gameObject;

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if(parent.tag == "Player" && isEffective){
            Debug.Log("If the parent obj is the player and 'isEffect' is true, increase the jumpHeigt of the player");

            player.GetComponent<PlayerMovement>().jumpHeight += jumpHeightIncrease;
            isEffective = false;
            
        } else if (takenOff){
            Debug.Log("if 'takenOff' is true, decrease the player's jumpHeight and turn 'takenOff' to false, and also destroy this game object");

            player.GetComponent<PlayerMovement>().jumpHeight -= jumpHeightIncrease;

            takenOff = false;
            Destroy(gameObject);
        }
    }
}
