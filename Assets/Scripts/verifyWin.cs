using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class verifyWin : MonoBehaviour, IInteractable
{
    private GameObject InventorySlots;
    public GameObject uiObject;
    public int counter;
    public Text wintext;

    
    public void Interact(DisplayImage currentDisplay)
    {
        verify();
   }

    public void verify(){
        counter=0;
        InventorySlots = GameObject.Find("Slots");

        foreach(Transform slot in InventorySlots.transform){
            if(slot.transform.GetChild(0).GetComponent<Image>().sprite.name != "empty_item"){
                counter++;
            }
        }

        if(counter == 6){
            Debug.Log("Has ganado! ;)");
            wintext.text = "You Win";
           // GameObjectVariable.GetComponent<CountdownTimer>().PauseToggle();
        }
    }
}
