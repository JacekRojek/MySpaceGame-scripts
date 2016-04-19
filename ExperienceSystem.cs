using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExperienceSystem : MonoBehaviour {
    public static int EXP=0;
    public static int LEVEL=1;
    private Slider expSlider;
    int maxEXP=50;
    public GameObject LevelUP_panel;
    private Transform canvas;
     public delegate void LevelUP();
    public static event LevelUP Leveled;
	void Start () {
        canvas = this.transform.Find("/Canvas");
        Leveled += ShowPanel;
        expSlider = this.transform.Find("/Canvas/Character_Panel/EXP_Slider").gameObject.GetComponent<Slider>();

        expSlider.maxValue = maxEXP;
        EXP = Mathf.Clamp(EXP, 0, maxEXP);
    }
	

	void Update () {
        expSlider.value = EXP;
        if (EXP >= maxEXP)
        {
            LEVEL++;
            EXP = EXP - maxEXP;
            maxEXP = (int)(1.2f*maxEXP);
            expSlider.value = EXP;
            Leveled();
        }
	}
    void ShowPanel()
    {
        GameObject panel =Instantiate(LevelUP_panel, transform.position, Quaternion.identity) as GameObject;
        panel.transform.parent = canvas;
        panel.transform.localPosition = Vector3.zero;
        Debug.Log("Panel Created");
    }

}
