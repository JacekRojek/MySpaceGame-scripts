using UnityEngine;
using LitJson;
using System.Collections;
using System.IO; 

public class Write_JSON : MonoBehaviour {

    public Character player = new Character(0,"player0",1231,false,new int[] { 1, 2, 3 });
    JsonData playerJson;
	// Use this for initialization
	void Start () {
        // 
        playerJson = JsonMapper.ToJson(player);
        Debug.Log(playerJson);
        File.WriteAllText(Application.dataPath+"/Player.json",playerJson.ToString());
	}
	

}
public class Character
{
    public int id;
    public string name;
    public int health;
    public bool isAggresive;
    public int[] stats;
    public Character(int id, string name, int health, bool isAggresive, int[] stats)
    {
        this.id = id;
        this.name = name;
        this.health = health;
        this.isAggresive = isAggresive;
        this.stats = stats;
    }
}