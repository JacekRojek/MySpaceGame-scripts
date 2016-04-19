using UnityEngine;
using System.Collections;
using LitJson;
using System.IO;
using UnityEngine.UI;
public class PanelPlanet : MonoBehaviour {
    public GameObject Option;
    private string JSONstring;
    private JsonData stateData;
    public string planetName;
    int randomNumber;
    void Start()
    {

        randomNumber = Random.Range((int)1f, (int)3f);
        this.transform.parent.FindChild("Name").GetComponent<Text>().text = planetName;
        this.transform.parent.FindChild("Image_Planet").GetComponent<Image>().sprite = UnityEngine.Resources.Load<Sprite>("Sprites/" + planetName);
       
        JSONstring = File.ReadAllText(Application.dataPath + "/Quests/"+planetName+"_"+randomNumber+".json");
        Debug.Log(Application.dataPath + "/Quests/" + planetName + "_" + randomNumber + ".json");
        stateData = JsonMapper.ToObject(JSONstring);
        Debug.Log(stateData[0]["options"][0]["text"]);
        Debug.Log(stateData[0]["options"][0]["load"]);
        UpdateState(0);

    }
	public void UpdateState(int newstate)
    {
        int numberOfOptions;
        this.GetComponent<Text>().text = stateData[newstate]["mainText"].ToString();
        numberOfOptions = stateData[newstate]["options"].Count;
        DestroyChildren();
        for (int i = 0; i < numberOfOptions; i++)
        {
            GameObject optionObject= Instantiate(Option, Vector3.zero, Quaternion.identity) as GameObject;
            optionObject.transform.SetParent(this.transform);
            optionObject.transform.position = Vector3.zero;
            optionObject.GetComponent<Text>().text = stateData[newstate]["options"][i]["text"].ToString();
            optionObject.GetComponent<Option>().stateToLoad = (int)stateData[newstate]["options"][i]["load"];
            if (i == numberOfOptions - 1)
            {
                optionObject.GetComponent<Button>().onClick.AddListener(() => { ExitPanel(); });
            }
        }
    }
        void ExitPanel(){
        Destroy(this.transform.parent.transform.parent.gameObject);
        Time.timeScale = 1f;
        }
    void DestroyChildren()
    {
           int childs = transform.childCount;
            for (int i = childs - 1; i >= 0; i--)
            {
                GameObject.Destroy(transform.GetChild(i).gameObject);
            }
    }
}
