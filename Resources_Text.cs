using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Resources_Text : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = ResourceManagment.Totalmetal.ToString();
	}
}
