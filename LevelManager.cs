using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    public float autoLoadNextLevelAfter;
    public string levelName;

    void Start()
    {
        if (autoLoadNextLevelAfter == 0)
        {
        }
        else {

            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
    }
    public void LoadLevelByNumber(int number)
    {
        Application.LoadLevel(number);
    }
    

    
	public void LoadLevel(string name){
		
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

}
