using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {
    public Material standardMaterial;
    public Material highlightMaterial;

    // Use this for initialization
    void Start () {
        gameObject.GetComponent<SpriteRenderer>().material = standardMaterial;
	}
	
	void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().material = highlightMaterial;
    }
    void OnMouseUp()
    {
        gameObject.GetComponent<SpriteRenderer>().material = standardMaterial;
    }
}
