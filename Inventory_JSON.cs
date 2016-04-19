using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Inventory_JSON : MonoBehaviour {
    int slotamount ;
    GameObject slotPanel;
    public GameObject inventorySlot;
    public GameObject inventoryItem;
    ItemDatabase database;
    public List<Item> items = new List<Item>();
    public List<GameObject> slots = new List<GameObject>();
    // Use this for initialization
    void Start () {
        database = this.GetComponent<ItemDatabase>();
        slotamount = 20;
        slotPanel = this.gameObject;
        for(int i=0; i<slotamount; i++)
        {
            items.Add(new Item());
            slots.Add(Instantiate(inventorySlot));
            slots[i].transform.SetParent(slotPanel.transform);
        }
        AddItem(0);
        AddItem(1);
        AddItem(1);

    }
	
	public void AddItem(int id)
    {
        Item itemToAdd = database.FetchItembyID(id);

        if (itemToAdd.Stackable && CheckInventory(itemToAdd))
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ID == id)
                {
                    ItemData data = slots[i].transform.GetComponentInChildren<ItemData>();
                    data.amount++;
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
                    
                    break;
                }

            }
        }
        else {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ID == -1)
                {
                    items[i] = itemToAdd;
                    GameObject itemObject = Instantiate(inventoryItem);
                    itemObject.transform.SetParent(slots[i].transform);
                    itemObject.transform.position = Vector2.zero;
                    itemObject.GetComponent<Image>().sprite = itemToAdd.sprite;
                    itemObject.name = itemToAdd.Title;
                    itemObject.GetComponent<ItemData>().item = itemToAdd;
                    break;
                }
            }
        }
    }
    bool CheckInventory(Item item)
    {
        for(int i=0; i < items.Count; i ++)
        {
            if(items[i].ID == item.ID)
            return true;
        }
        return false;
    }
}
