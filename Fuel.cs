using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fuel : MonoBehaviour {
    public static float fuel;
    public float fuelConsumtion=100f;
    public int maxFuel=300;
    public Slider slider_fuel;
    
	void Start () {
        
        fuel = Mathf.Clamp(fuel, 0, maxFuel);
        fuel = maxFuel;
        Debug.Log(fuel);

	}
	
	
	void Update () {
        
        
        fuel -= fuelConsumtion * Time.deltaTime;
        slider_fuel.value = fuel;
       
    }
}
