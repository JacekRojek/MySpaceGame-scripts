using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;
public class CharacterData : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public CharacterToPick character;
    public int amount;
    private TooltipCharacter tooltip;
    private GameObject panel;
    private GameObject ChosedPanel;
    private GameObject playButton;
    

    void Start()
    {
        playButton = this.transform.Find("/Canvas/Button_Play").gameObject;
        ChosedPanel = this.transform.Find("/Canvas/CapitanSelection_Panel/selected_crew").gameObject;
        panel = this.transform.Find("/Canvas/CapitanSelection_Panel/CreqPanel").gameObject;
        tooltip = panel.GetComponent<TooltipCharacter>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {

        tooltip.Activate(character);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.Disactivate();
    }
    public void OnClick()
    {
        ChosedPanel.transform.GetChild(0).GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
        playButton.GetComponent<Button>().interactable = true;
    }
}
