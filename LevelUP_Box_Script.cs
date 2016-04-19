using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LevelUP_Box_Script : MonoBehaviour {
    private Image sprite;
    private Text text_Header;
    private Text number_string;
   
	// Use this for initialization
	void Awake () {
        sprite = this.transform.GetChild(0).GetComponent<Image>();
        text_Header = this.transform.GetChild(1).GetComponent<Text>();
        number_string = this.transform.GetChild(2).GetComponent<Text>();
        Debug.Log("Sprite  "+ sprite+ "Text1  " + text_Header + "Text2 " + number_string);
 
    }
    public void changeValues(Sprite spriteN, string headerN, int valueN)
        {
        sprite.sprite = spriteN;
        text_Header.text = headerN;
        number_string.text = valueN.ToString();
       

        }
  
    public  void AddFuel(int value)
    {
        Fuel.fuel += value;

    }
    public void AddMetal(int value)
    {
        ResourceManagment.Totalmetal += value;
    }
}
