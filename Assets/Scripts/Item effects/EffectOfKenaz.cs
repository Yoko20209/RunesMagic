using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectOfKenaz : Item
{

    public GameObject fireBall;
    // public float speedOfFire;

    // Update is called once per frame
    void Update()
    {
        GameObject parent = this.transform.parent.gameObject;

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if(parent.tag == "Player" && isEffective){

             if (Input.GetMouseButtonDown(0)){
                Camera cam = Camera.main;
                 Instantiate(fireBall, player.transform.position + new Vector3(0, 1, 0), cam.transform.rotation);
             }
        }
        if (takenOff){
            isEffective = false;
            takenOff = false;
            Destroy(gameObject);
        }
    }
}
