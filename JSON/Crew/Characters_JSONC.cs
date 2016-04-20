using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Characters_JSONC : MonoBehaviour {
    int slotamount;
    GameObject slotPanel;
    public GameObject inventorySlot;
    public GameObject inventoryItem;
    CharactersDatabase database;
    public List<CharacterToPick> items = new List<CharacterToPick>();
    public List<GameObject> slots = new List<GameObject>();

    void Start()
    {
        database = this.GetComponent<CharactersDatabase>();
        slotamount = 6;
        slotPanel = this.gameObject;
        for (int i = 0; i < slotamount; i++)
        {
            items.Add(new CharacterToPick());
            slots.Add(Instantiate(inventorySlot));
            slots[i].transform.SetParent(slotPanel.transform);
        }

        AddItem(0);
        AddItem(1);
        AddItem(2);
        AddItem(3);
    }

    public void AddItem(int id)
    {
        CharacterToPick itemToAdd = database.FetchItembyID(id);

      
            for (int i = 0; i < items.Count; i++)
            {
            if (items[i].ID == -1)
            {
                items[i] = itemToAdd;
                GameObject itemObject = Instantiate(inventoryItem);
                itemObject.GetComponent<CharacterData>().character = itemToAdd;
                itemObject.transform.SetParent(slots[i].transform);
                itemObject.transform.position = Vector2.zero;
                itemObject.GetComponent<Image>().sprite = itemToAdd.sprite;
                itemObject.name = itemToAdd.Title;
                itemObject.GetComponent<CharacterData>().character = itemToAdd;
                Debug.Log(itemObject.GetComponent<CharacterData>().character.ID);
                break;
            }
        }
    }
    bool CheckInventory(CharacterToPick item)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].ID == item.ID)
                return true;
        }
        return false;
    }
}
