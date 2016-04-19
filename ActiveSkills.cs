using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ActiveSkills : MonoBehaviour {
    public GameObject shockwave;
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Player").gameObject;
    }
    void OnEnable()
    {
        ExperienceSystem.Leveled += UnlockSkill;
    }
    void OnDisabled()
    {
        ExperienceSystem.Leveled -= UnlockSkill;
    }

    void UnlockSkill()
    {
        Debug.Log("Activated");
        if (ExperienceSystem.LEVEL >= 5)
        {
            this.transform.GetChild(0).GetComponent<Button>().interactable = true;
        }
    }
    public void ActivateShockva()
    {
        GameObject newshockwave = Instantiate(shockwave, Vector3.zero, Quaternion.identity) as GameObject;
        newshockwave.transform.SetParent(player.transform);
        newshockwave.transform.localPosition = Vector2.zero;
      
    }
}
