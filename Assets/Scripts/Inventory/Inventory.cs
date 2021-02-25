using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inventory tutorial: also shows how to design it
//https://www.youtube.com/watch?v=welWr2OFMw4

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    public GameObject slotHolder;
    public int numberOfSlots = 27;

    private bool inventoryEnabled;
    
    private int enabledSlots;
    private GameObject[] slot;

    public bool itemSelected = false;


    void Start(){
        slot = new GameObject[numberOfSlots];
        for(int i = 0; i < numberOfSlots; i++){
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if(slot[i].GetComponent<Slot>().item == null){
                slot[i].GetComponent<Slot>().empty = true;
            }
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.I)){
            inventoryEnabled = !inventoryEnabled;
        }

        MouseLook mouseLock = GameObject.FindWithTag("MainCamera").GetComponent<MouseLook>(); 

       if (inventoryEnabled == true){
           Cursor.lockState = CursorLockMode.None;
           mouseLock.cameraMovementOn = false;
           inventory.SetActive(true);
       }else{
           Cursor.lockState = CursorLockMode.Locked;
           mouseLock.cameraMovementOn = true;
           inventory.SetActive(false);
       }

    }


    private void OnTriggerEnter(Collider other){
        if(other.tag == "Collectable"){
            GameObject itemPickedUp = other.gameObject;

            Item item = itemPickedUp.GetComponent<Item>();

            AddItem(itemPickedUp, item.type, item.description, item.pickupEffect, item.iconForInventory);
        }
    }

    void AddItem(GameObject itemPickedUp, string type, string description, GameObject pickupEffect, Sprite iconForInventory){
        
        for(int i = 0; i < numberOfSlots; i++){
            if(slot[i].GetComponent<Slot>().empty){
                itemPickedUp.GetComponent<Item>().pickedUp = true;

                slot[i].GetComponent<Slot>().item = itemPickedUp;
                slot[i].GetComponent<Slot>().iconForInventory = iconForInventory;
                slot[i].GetComponent<Slot>().type = type;
                slot[i].GetComponent<Slot>().description = description;

                itemPickedUp.transform.parent = slot[i].transform;
                itemPickedUp.SetActive(false);
                
                slot[i].GetComponent<Slot>().UpdateSlot();
                slot[i].GetComponent<Slot>().empty = false;
                return;
            }
        }
    }
}
