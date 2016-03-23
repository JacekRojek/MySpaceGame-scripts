using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {
    public Material standardMaterial;
    public Material highlightMaterial;
    public GameObject window;
    // Use this for initialization
    void Start () {
        gameObject.GetComponent<SpriteRenderer>().material = standardMaterial;
	}
	
	void OnMouseOver()
    {
        gameObject.GetComponent<SpriteRenderer>().material = highlightMaterial;
    }
    void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().material = standardMaterial;
    }
    void OnMouseDown()
    {
        window.SetActive(true);
    }
}
