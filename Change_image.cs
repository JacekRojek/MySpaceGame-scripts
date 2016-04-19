using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Change_image : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Image>().sprite =Character_SingleSelection.character;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
