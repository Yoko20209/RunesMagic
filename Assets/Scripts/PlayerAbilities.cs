using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    public bool fireAbility = false;
    public bool raidho = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(raidho){
            this.GetComponent<PlayerMovement>().speed = 8;
        }
    }
}
