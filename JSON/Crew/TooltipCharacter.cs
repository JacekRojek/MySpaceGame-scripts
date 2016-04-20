using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TooltipCharacter : MonoBehaviour {
    private CharacterToPick item;
    private string data;
    private GameObject tooltip;

    void Start()
    {
        tooltip = GameObject.Find("Tooltip_Character");
        Debug.Log(tooltip);
        tooltip.SetActive(false);
    }
    void Update()
    {
        if (tooltip.activeSelf)
        {
            tooltip.transform.position = Input.mousePosition;
        }
    }
    public void Activate(CharacterToPick newitem)
    {

        tooltip.SetActive(true);
        this.item = newitem;
        ConstructDataString();
       
    }
    public void Disactivate()
    {
        tooltip.SetActive(false);
    }
    public void ConstructDataString()
    {
        data = "<b>" + item.Title + "</b>\n" + "<color=#904040><b>" + "Power: " + item.Power + "</b></color>\n" +item.Discription;

        tooltip.transform.GetChild(0).GetComponent<Text>().text = data;
    }
}
