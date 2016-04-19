using UnityEngine;
using System.Collections;

public class Option : MonoBehaviour {
    public int stateToLoad;
    public void LoadState()
    {
        this.GetComponentInParent<PanelPlanet>().UpdateState(stateToLoad);
    }
}
