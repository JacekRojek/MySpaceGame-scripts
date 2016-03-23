using UnityEngine;
using System.Collections;

public class ExitScript_Planet : MonoBehaviour {

	public void ExitPanel()
    {
        Debug.Log(Time.timeScale);
        Time.timeScale = 1f;
        Debug.Log(Time.timeScale);
    }
}
