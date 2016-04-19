using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fuel : MonoBehaviour {
    public static float fuel;
    public float fuelConsumtion=100f;
    public int maxFuel=300;
    private Slider slider_fuel;
    
	void Start () {
        slider_fuel = this.transform.Find("/Canvas/Slider").GetComponent<Slider>();
        fuel = Mathf.Clamp(fuel, 0, maxFuel);
        fuel = maxFuel;
	}
	
	
	void Update () {
        fuel -= fuelConsumtion * Time.deltaTime;
        slider_fuel.value = fuel;
       
    }
    public void AddFuel(int number)
    {
        fuel += number;
    }
}
