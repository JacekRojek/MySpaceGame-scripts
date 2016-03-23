using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Character_SingleSelection : MonoBehaviour {
    private GameObject selected_crew;
    private Button button;
    private Color color;

    void Start () {
        color = this.GetComponent<Image>().color;
        selected_crew = this.transform.parent.parent.Find("selected_crew").gameObject;
        button = this.GetComponent<Button>();
        button.onClick.AddListener(this.SetSprite);
        
    }
    void SetSprite()
    {
        selected_crew.GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
        selected_crew.GetComponent<Image>().color = Color.white;
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
