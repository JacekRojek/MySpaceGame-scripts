using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fuel_Production_Building : MonoBehaviour {
    private Text[] text;
    private int fuelProduction=10;
    public static int Totalfuel=50;
    private int reqiredMetal=20;
	// Use this for initialization
	void Start () {
        //ResourceManagment.Totalmetal += 100;
        text = this.GetComponentsInChildren<Text>();
        InvokeRepeating("Producefuel", 1f, 60f);
        text[1].text = fuelProduction.ToString();
        text[2].text = Totalfuel.ToString();
        text[4].text = reqiredMetal.ToString();
        text[3].gameObject.SetActive(false);
    }
	
    void Producefuel()
    {
        Totalfuel += fuelProduction;
        text[2].text = Totalfuel.ToString();
    }
    public void changeProduction(int number)
    {

        if (ResourceManagment.Totalmetal >= reqiredMetal)
        {
            text[3].gameObject.SetActive(false);
            ResourceManagment.Totalmetal -= reqiredMetal;
            Debug.Log("Clicked");
            fuelProduction += number;
            Debug.Log(fuelProduction);
            text[1].text = fuelProduction.ToString();
            reqiredMetal= reqiredMetal+50;
            text[4].text = reqiredMetal.ToString();
        }
        else
        {
            text[3].gameObject.SetActive(true);
            
        }

    }
}
