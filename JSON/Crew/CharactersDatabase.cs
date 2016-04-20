using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;
using System.IO;

public class CharactersDatabase : MonoBehaviour {
    private List<CharacterToPick> database = new List<CharacterToPick>();
    private JsonData itemData;


    void Start()
    {

        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/characters.json"));
        ConstructItemDatabase();
        Debug.Log(database[1].Title);
    }
    public CharacterToPick FetchItembyID(int id)
    {

        for (int i = 0; i < database.Count; i++)
        {
            if (database[i].ID == id)
                return database[i];
        }
        return null;
    }
    void ConstructItemDatabase()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            database.Add(new CharacterToPick((int)itemData[i]["id"], itemData[i]["title"].ToString(),  (int)itemData[i]["stats"]["power"], (int)itemData[i]["stats"]["defence"],
                (int)itemData[i]["stats"]["vitality"], itemData[i]["decription"].ToString(), itemData[i]["slug"].ToString()));
        }
    }
}
public class CharacterToPick
{
    private Sprite[] sprites = UnityEngine.Resources.LoadAll<Sprite>("Sprites/Characters_Sprite");
    
    public int ID { get; set; }
    public string Title { get; set; }
    public int Power { get; set; }
    public int Defence { get; set; }
    public int Vitality { get; set; }
    public string Discription { get; set; }
    public string Slug { get; set; }
    public Sprite sprite { get; set; }

    public CharacterToPick(int id, string title, int power, int defence, int vitality, string discription, string slug)
    {
        Debug.Log(sprites);
        this.ID = id;
        this.Title = title;
        this.Power = power;
        this.Defence = defence;
        this.Vitality = vitality;
        this.Discription = discription;
        this.Slug = slug;
        this.sprite = sprites[id];



    }
    public CharacterToPick()
    {
        this.ID = -1;
    }
}
