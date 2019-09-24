using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public InventorySlot[] inventory;
    public int slotIndex = 0;
    public GameObject slotHolder;
    public GameObject selectedPanel;
    public GameObject random;

    public Sprite tempItem;
    public Sprite emptySlot;
    public Text inventoryText;
    // Start is called before the first frame update
    void Start()
    {
        inventory = slotHolder.GetComponentsInChildren<InventorySlot>();
        Debug.Log(inventory.Length);
        inventoryText.text = " ";

        random = GameObject.Find("ObjectDropPoint");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            Mathf.Clamp(slotIndex, 0, inventory.Length);
            if (slotIndex != 0) { 
                slotIndex--;
                //Debug.Log(slotIndex);
                MoveSelected();
            }
            else
            {
                slotIndex = 8;
                MoveSelected();
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Mathf.Clamp(slotIndex, 0, inventory.Length);
            if (slotIndex != 8)
            {
                slotIndex++;
                //Debug.Log(slotIndex);
                MoveSelected();
            }
            else
            {
                slotIndex = 0;
                MoveSelected();
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            random.GetComponent<RandomGen>().DropFromInv(inventory[slotIndex].gameObject.GetComponent<InventorySlot>().itemText);
            RemoveItemInSlot();
        }
    }

    void MoveSelected()
    {
        selectedPanel.transform.localPosition = new Vector3((slotIndex * 178) - 800, 0, 0);
        Mathf.Clamp(selectedPanel.transform.localPosition.x, 0, 1424);
        if (inventory[slotIndex].gameObject.GetComponent<InventorySlot>().itemIcon.sprite != emptySlot)
            inventoryText.text = inventory[slotIndex].gameObject.GetComponent<InventorySlot>().itemText;
        if (inventory[slotIndex].gameObject.GetComponent<InventorySlot>().itemIcon.sprite == emptySlot)
            inventoryText.text = " ";
    }

    public void PickUp()
    {
        if (inventory[slotIndex].gameObject.GetComponent<InventorySlot>().itemIcon.sprite == emptySlot)
        inventory[slotIndex].gameObject.GetComponent<InventorySlot>().itemIcon.sprite = tempItem;
        inventoryText.text = inventory[slotIndex].gameObject.GetComponent<InventorySlot>().itemText;
    }

    void RemoveItemInSlot()
    {
        inventory[slotIndex].gameObject.GetComponent<InventorySlot>().itemIcon.sprite = emptySlot;
        inventory[slotIndex].gameObject.GetComponent<InventorySlot>().itemText = " ";
        inventoryText.text = " ";
    }
}
