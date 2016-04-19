using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class ItemData : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler  {
    public Item item;
    public int amount;
    private Tooltip tooltip;
    private GameObject panel;
    private GameObject shipPanel;

    void Start()
    {
        panel = this.transform.Find("/Canvas/Inventory Panel/Panel").gameObject;
        tooltip = panel.GetComponent<Tooltip>();

        shipPanel = this.transform.Find("/Canvas/ShipSelection_Panel/ShipSprite_Panel/placeholder").gameObject;

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(tooltip);
        Debug.Log(item);
        tooltip.Activate(item);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.Disactivate();
    }
    public void OnClick()
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Weapon");
        if (items[0].transform.childCount==0)
        {
            this.gameObject.transform.SetParent(items[0].transform);
            this.transform.localPosition = Vector3.zero;
        }
        else if (items[1].transform.childCount == 0)
        {
            this.gameObject.transform.SetParent(items[1].transform);
            this.transform.localPosition = Vector3.zero;
        }
        else
        {
            Debug.Log("Slots are Full");
        }
    }
}
