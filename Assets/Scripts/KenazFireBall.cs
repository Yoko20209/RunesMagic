using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KenazFireBall : MonoBehaviour
{
    // public Vector3 target = new Vector3(20, 0, 0);
    public float speed = 10;
    public float range = 10;
    
    private float distance;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        distance += Time.deltaTime*speed;
        if(distance >= range){
            Destroy( gameObject );
        }

        // if (Input.GetMouseButtonDown(0)){
        //     Camera cam = Camera.main;
        //     GameObject 




            // Transform player = GameObject.FindGameObjectWithTag("Player").transform;
            // transform.position = Vector3.MoveTowards(transform.position, target + player, Time.deltaTime * speed);
        // }
        
    }

    void OnTriggerExit(Collider other){
        Debug.Log("CUbe????");
        if(other.tag == "burnable")
        { 
            Debug.Log("yep");
            Destroy(gameObject);

        }
    }
}
