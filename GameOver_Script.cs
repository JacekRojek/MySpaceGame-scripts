using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameOver_Script : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        ExperienceSystem.Leveled += UpdateText;

    }
    void Disabe()
    {
        ExperienceSystem.Leveled -= UpdateText;

    }
    void UpdateText()
    {
       
            Debug.Log(this.GetComponentInChildren<Text>().text);
            this.GetComponentInChildren<Text>().text = ExperienceSystem.LEVEL.ToString();
            Debug.Log(this.GetComponentInChildren<Text>().text);
        
    }
}
