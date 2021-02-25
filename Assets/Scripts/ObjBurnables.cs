using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjBurnables : MonoBehaviour
{
    
    public GameObject destroyedEffect;


    void OnTriggerEnter(Collider other){

        Debug.Log("Kenaz???????");
        if(other.tag == "kenazFireBall"){
            Debug.Log("Yes!!!!!!");
            Instantiate(destroyedEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
