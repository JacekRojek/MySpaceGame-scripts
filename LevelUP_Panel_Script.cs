using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LevelUP_Panel_Script : MonoBehaviour {
   public  Sprite[] sprites;
    GameObject box1, box2;
    int value_Fuel = 50;
    int value_Metal = 100;
    // Use this for initialization
    void Start () {
        box1 = this.transform.GetChild(0).gameObject;

        box2 = this.transform.GetChild(1).gameObject;

        box1.GetComponent<LevelUP_Box_Script>().changeValues(sprites[0], "Fuel", value_Fuel);
        box2.GetComponent<LevelUP_Box_Script>().changeValues(sprites[1], "Metal", value_Metal);
        box1.GetComponent<Button>().onClick.AddListener(() => box1.GetComponent<LevelUP_Box_Script>().AddFuel(value_Fuel));
        box2.GetComponent<Button>().onClick.AddListener(() => box1.GetComponent<LevelUP_Box_Script>().AddMetal(value_Metal));

    }
    void Awake()
    {
        Time.timeScale = 0f;
    }

    public void Destroy()
    {
        Time.timeScale = 1f;
        Destroy(this.gameObject);
    }
}
