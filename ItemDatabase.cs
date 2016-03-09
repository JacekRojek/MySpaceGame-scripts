﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;
using System.IO;

public class ItemDatabase : MonoBehaviour {
    private List<Item> database = new List<Item>();
    private JsonData itemData;
    
    void Start()
    {
        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));
        ConstructItemDatabase();
        Debug.Log(database[1].Title);
    }  
    public Item FetchItembyID(int id)
    {

        for (int i = 0; i< database.Count; i++) {
            if (database[i].ID==id)
            return database[i];
                }
        return null;
            }
    void ConstructItemDatabase()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            database.Add(new Item((int)itemData[i]["id"], itemData[i]["title"].ToString(), (int)itemData[i]["value"], (int)itemData[i]["stats"]["power"], (int)itemData[i]["stats"]["defence"],
                (int)itemData[i]["stats"]["vitality"]  , itemData[i]["decription"].ToString(), (bool)itemData[i]["stackable"], (int)itemData[i]["rarity"], itemData[i]["slug"].ToString()));
        }
    }
}
public class Item
{
    public int ID { get; set; }
    public string Title { get; set; }
    public int Value { get; set; }
    public int Power { get; set; }
    public int Defence { get; set; }
    public int Vitality { get; set; }
    public string Discription { get; set; }
    public bool Stackable { get; set; }
    public int Rarity { get; set; }
    public string Slug { get; set; }

    public Item(int id,string title,int value,int power, int defence, int vitality, string discription, bool stackable, int rarity, string slug){
        this.ID = id;
        this.Title = title;
        this.Value = value;
        this.Power = power;
        this.Defence = defence;
        this.Vitality = vitality;
        this.Discription = discription;
        this.Stackable = stackable;
        this.Rarity = rarity;
        this.Slug = slug;


        }
    public Item()
    {
        this.ID = -1;
    }
}