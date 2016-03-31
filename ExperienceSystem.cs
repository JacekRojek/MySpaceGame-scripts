using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExperienceSystem : MonoBehaviour {
    public static int EXP=0;
    static int LEVEL=0;
    private Slider expSlider;
    int maxEXP=100;
	// Use this for initialization
	void Start () {
        
        expSlider = this.transform.Find("/Canvas/Character_Panel/EXP_Slider").gameObject.GetComponent<Slider>();

        expSlider.maxValue = maxEXP;
        EXP = Mathf.Clamp(EXP, 0, maxEXP);
    }
	
	// Update is called once per frame
	void Update () {
        expSlider.value = EXP;
        if (EXP >= maxEXP)
        {
            EXP = EXP - maxEXP;
            LEVEL++;
            maxEXP = (int)(1.2f*maxEXP);
            Debug.Log("Level =  " + LEVEL + "  EXp=  " + EXP);
        }
	}

}
