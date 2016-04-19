using UnityEngine;
using System.Collections;

public class SelectedCharacter : MonoBehaviour {
    public GameObject character;
public void Select(CharacterToPick newchar)
    {
        if (this.transform.childCount == 0)
        {
            GameObject newcharacter= Instantiate(character, Vector3.zero, Quaternion.identity) as GameObject;
            newcharacter.GetComponent<CharacterData>().character = newchar;
            newcharacter.transform.localPosition = Vector3.zero;
            newcharacter.transform.SetParent(this.transform);
            
        }
        else
        {
            this.transform.GetChild(0).GetComponent<CharacterData>().character = newchar;
        }
    }
}
