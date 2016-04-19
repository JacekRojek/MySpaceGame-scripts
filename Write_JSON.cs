using UnityEngine;
using LitJson;
using System.Collections;
using System.IO; 

public class Write_JSON : MonoBehaviour {

    public State player = new State(0, "Amerath Prime",0, 3,"you found empty planet");
    JsonData stateJson;
    
	// Use this for initialization
	void Start () {
        stateJson = JsonMapper.ToJson(player);
        Debug.Log(stateJson);
        File.WriteAllText(Application.dataPath+"/Quest.json",stateJson.ToString());
	}
}
public class State
{
    public int id;
    public string name;
    public Sprite sprite;
    private int state;
    public int numberOfOptions;
    public string mainText;
  //  public int[] stats;
    public State(int id, string name, int state, int numberOfOptions,string maintext)
    {
        this.id = id;
        this.name = name;
        this.sprite = UnityEngine.Resources.Load<Sprite>("Sprites/" + name);
        this.state = state;
        this.numberOfOptions = numberOfOptions;
        this.mainText = maintext;

    }
}
