using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Planet1_1_Text : MonoBehaviour {
    private Text[] textOption;
    private int optionNumber=1;
    public GameObject questItem;
    public static bool itemPicked=false;
    private Transform planet;
   
    private int expVaule = 50;
    // Use this for initialization
    void Start () {
        planet = this.transform.Find("/Planet");
        textOption = this.transform.GetComponentsInChildren<Text>();
        if (itemPicked)
        {
            this.gameObject.GetComponent<Text>().text = "Did you found it?";
            textOption[1].text = "1. Yes";
            textOption[2].text = "2. No";
        }
	}
	
	public void Option1()
    {
        if (!itemPicked)
        {
            if (optionNumber == 1)
            {
                this.gameObject.GetComponent<Text>().text = "Yes we need help, i lost my laser gun. Cany you help me?";
                textOption[1].text = "1. accept";
                textOption[2].text = "2. refuse";
                optionNumber = 2;
            }
            else if (optionNumber == 2)
            {
                this.gameObject.GetComponent<Text>().text = " I think it was north form here";
                textOption[1].text = "1. Im on my way, don't worry";
                Destroy(textOption[2].gameObject);
                optionNumber = 3;
            }
            else if (optionNumber == 3)
            {
                Vector3 itemLocation = new Vector3(planet.transform.position.x, planet.transform.position.y +10f, planet.transform.position.z);
                GameObject questItemInstance=  Instantiate(questItem, itemLocation, Quaternion.identity) as GameObject;
                
                questItemInstance.transform.parent = planet;
               
               

                Time.timeScale = 1f;
                this.transform.parent.parent.gameObject.SetActive(false);
            }
        }
        if (itemPicked)
        {
            ExperienceSystem.EXP += expVaule;
            Debug.Log(ExperienceSystem.EXP);
            
 
            this.transform.parent.parent.gameObject.SetActive(false);
        }
    }
}
