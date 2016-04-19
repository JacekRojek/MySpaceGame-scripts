using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Play_button_SelectionScreen : MonoBehaviour {

    void Start()
    {
        Disable();
    }
    public void Disable()
    {
        this.GetComponent<Button>().interactable = false;
       
    }
    public void Enable()
    {
        this.GetComponent<Button>().interactable = true;
        
    }
}
