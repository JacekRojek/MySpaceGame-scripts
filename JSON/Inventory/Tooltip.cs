using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Tooltip : MonoBehaviour {
    private Item item;
    private string data;
    private GameObject tooltip;

    void Start()
    {
        tooltip = GameObject.Find("Tooltip");

        tooltip.SetActive(false);
    }
    void Update()
    {
        if (tooltip.activeSelf)
        {
            tooltip.transform.position = Input.mousePosition;
        }
    }
	public void Activate(Item newitem)
    {
        this.item = newitem;
        ConstructDataString();
        tooltip.SetActive(true);
    }
    public void Disactivate()
    {
        tooltip.SetActive(false);
    }
    public void ConstructDataString()
    {
        data = "<b>"+item.Title+"</b>\n"+ "<color=#904040><b>" + "Power: "+item.Power + "</b></color>\n";
        
        tooltip.transform.GetChild(0).GetComponent<Text>().text = data;
    }
}
