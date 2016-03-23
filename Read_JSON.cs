using UnityEngine;
using System.Collections;
using System.IO;
using LitJson;

public class Read_JSON : MonoBehaviour {
    private string jsonString;
    private JsonData itemData;
	// Use this for initialization
	void Start () {
        jsonString = File.ReadAllText(Application.dataPath + "Items.json");
        itemData = JsonMapper.ToObject(jsonString);

        Debug.Log(itemData["weapons"][0]["name"]);
        //GetItem()
        
	}
	
	// Update is called once per frame
	JsonData GetItem(string name, string type)
    {
        for(int i=0; i < itemData[type].Count; i++)
        {
            if (itemData[type][i]["name"].ToString() == name)
            {
                return itemData[type][i];
            }
        }
        return null;
    }
}
