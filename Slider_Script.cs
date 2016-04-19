using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Slider_Script : MonoBehaviour {
    private Transform panel;
    public GameObject XP_Text;
    private int oldEXP=0;
    private Text level_number;

	// Use this for initialization
	void Start () {
        level_number = this.transform.GetComponentInChildren<Text>();
        panel = this.transform.Find("XP_Panel");
        this.gameObject.GetComponent<Slider>().onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        if (ExperienceSystem.EXP > 0)
        {
            level_number.text = ExperienceSystem.LEVEL.ToString();
            GameObject textPanel = Instantiate(XP_Text, transform.position, Quaternion.identity) as GameObject;

            textPanel.transform.SetParent(panel);
            textPanel.transform.FindChild("EXP_Number").GetComponent<Text>().text = (this.GetComponent<Slider>().value - oldEXP).ToString();
            oldEXP = (int)this.GetComponent<Slider>().value;
        }
    }
}
