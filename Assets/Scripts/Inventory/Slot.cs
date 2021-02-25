using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public GameObject item;
    public string type;
    public string description;
    public bool empty;
    public Sprite iconForInventory;

    public bool isSelected = false;

    public void UpdateSlot(){
        this.GetComponent<Image>().sprite = iconForInventory;
        
        Debug.Log("Updated the image of the slot to the picked up item's");
    }

    public void UseItem(){
    //clicked -> delete the player's child of the previous item and set takenOff to true;
    // append the item to the player
    // set is Effective to true;
        Debug.Log("!!!Item Selected!!!");

        Transform player = GameObject.FindGameObjectWithTag("Player").transform;

        foreach(Transform child in player){
            if(child.tag == "Collectable"){
                child.GetComponent<Item>().takenOff = true;
                Debug.Log("Found item that was used before and set 'takenOff' to true");
            }
        }

        GameObject copyOfItem = Instantiate(item);
        Debug.Log("Made copy of the selectd item");

        copyOfItem.transform.parent = player;
        copyOfItem.SetActive(true);
        Debug.Log("Set the copyItem active");

        copyOfItem.GetComponent<Item>().isEffective = true;
        Debug.Log("Set the copyItem's 'esEffective' to true");

        GameObject bigSlot = GameObject.Find("SelectedItem");
        Debug.Log("Found the Big Slot object");

        bigSlot.GetComponent<Image>().sprite = iconForInventory;
        Debug.Log("Set the Big Slot object's image to the selected item;s image");

        GameObject TextBox = GameObject.Find("ItemDescription");
        Debug.Log("Found the Text Box object");
        TextBox.GetComponent<Text>().text = description;
        
        Debug.Log("Set the text box's text to the description of the selected item");

        
        Debug.Log("!!!Item Selected function end!!!");
    }

}
