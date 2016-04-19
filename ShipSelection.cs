using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShipSelection : MonoBehaviour {

    public GameObject[] ships;
    private GameObject placeholder;
    private string ship_name = "ship_instance";
    private int ship_number = 0;
    private int max_ship_number =0;
    public GameObject playButton;
    //private bool isUnlocked = false;
    void Start () {
        
        max_ship_number = ships.Length;
        placeholder = this.transform.Find("placeholder").gameObject;
        Debug.Log(ship_number);
       
        GameObject ship = Instantiate(ships[ship_number], placeholder.transform.position, Quaternion.identity) as GameObject;
        ship.transform.parent = placeholder.transform;
        ship.name = ship_name;
    }

	public void selectionLeft()
    {

        if (ship_number > 0)
        {
            Debug.Log(">0  " + ship_number);
            ship_number--;
            Debug.Log(">0  " + ship_number);
            INstantiateShip();
            
        }
        else
        {
            ship_number = max_ship_number-1;
            INstantiateShip();

        }
        
    }

    private void INstantiateShip()
    {
        Destroy(placeholder.transform.FindChild(ship_name).gameObject);
        GameObject ship = Instantiate(ships[ship_number], placeholder.transform.position, Quaternion.identity) as GameObject;
        //ship.transform.parent = placeholder.transform;
        ship.transform.SetParent(placeholder.transform);
        ship.name = ship_name;
        Debug.Log(ship_number);
        if (ship.tag=="Unlocked")
        {
            playButton.GetComponent<Play_button_SelectionScreen>().Enable();
        }
        else {
            playButton.GetComponent<Play_button_SelectionScreen>().Disable();
        }
    }

    public void selectionRight()
    {
        if (ship_number == 0)
        {
            ship_number++;
            INstantiateShip();
            ship_number++;

        }
        else if (ship_number < max_ship_number)
        {
            INstantiateShip();
            ship_number++;
            
        }
        else
        {
            
            ship_number = 0;
            INstantiateShip();
        }
        
    }
  
}
