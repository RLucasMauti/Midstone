using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public PlayerInventory inv;

    private void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<PlayerInventory>();    
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.GetComponent<DestroyAfterTime>())
        {
            //Debug.Log("Item Seen");
            if (Input.GetKeyDown(KeyCode.E)) {
                //Debug.Log("Item Picked Up");
                if (inv.inventory[inv.slotIndex].gameObject.GetComponent<InventorySlot>().itemIcon.sprite == inv.emptySlot)
                {
                    inv.tempItem = other.gameObject.GetComponent<DestroyAfterTime>().GetImage();
                    inv.PickUp();
                    Destroy(other.gameObject);
                }
            }
        }
    }
}
