using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Character_SingleSelection : MonoBehaviour {
    private GameObject selected_crew;
    private GameObject text_select;
    private Button button;
    private Color color;
    public static Sprite character;
    private GameObject Play_button;

    void Start () {
        Play_button = this.transform.Find("/Canvas/Button_Play").gameObject;
        color = this.GetComponent<Image>().color;
        selected_crew = this.transform.parent.parent.Find("selected_crew").gameObject;
        text_select= this.transform.parent.parent.Find("Text").gameObject;
        button = this.GetComponent<Button>();
        button.onClick.AddListener(this.SetSprite);
        
    }
    void SetSprite()
    {
        selected_crew.GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
        selected_crew.GetComponent<Image>().color = Color.white;
        character = selected_crew.GetComponent<Image>().sprite;
        Play_button.GetComponent<Play_button_SelectionScreen>().Enable();
        text_select.SetActive(false);

    }
    public void OnMouseOver()
    {
       
        this.GetComponent<Image>().color = Color.white;
    }
    public void OnMouseExit()
    {
        
        this.GetComponent<Image>().color = color;
    }
}
