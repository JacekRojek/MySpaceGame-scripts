using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Slider_Script : MonoBehaviour {
    private Transform panel;
    public GameObject XP_Text;
    private int oldEXP=0;
	// Use this for initialization
	void Start () {

        panel = this.transform.Find("XP_Panel");
        this.gameObject.GetComponent<Slider>().onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        GameObject textPanel = Instantiate(XP_Text, transform.position, Quaternion.identity) as GameObject;
        textPanel.transform.parent = panel;
        textPanel.transform.FindChild("EXP_Number").GetComponent<Text>().text=(this.GetComponent<Slider>().value-oldEXP).ToString();
        oldEXP = (int)this.GetComponent<Slider>().value;
    }
}
