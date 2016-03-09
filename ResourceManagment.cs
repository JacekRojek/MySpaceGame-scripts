using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResourceManagment : MonoBehaviour {
    public static int Totalmetal = 0;
    public static int Totalcristals = 0;
    public Text text_Metal;
    public Text text_Fuel;
    public Text text_Cristalsl;
    // Use this for initialization
    void Start () {
        text_Fuel.text = "Fuel: \n" + Mathf.RoundToInt(Fuel.fuel).ToString();
        text_Metal.text = "Metal \n" + Mathf.RoundToInt(Totalmetal).ToString();
        text_Cristalsl.text = "Cristals \n" + Mathf.RoundToInt(Totalcristals).ToString();
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
