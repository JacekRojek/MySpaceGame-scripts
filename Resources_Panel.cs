using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Resources_Panel : MonoBehaviour {
    private Text[] resources;
	// Use this for initialization
	void Start () {
        resources = this.transform.GetComponentsInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        resources[1].text = Fuel_Production_Building.Totalfuel.ToString();
        resources[0].text = ResourceManagment.Totalmetal.ToString();

    }
}
