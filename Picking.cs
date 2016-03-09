using UnityEngine;
using System.Collections;

public class Picking : MonoBehaviour {
    public int Metal_value=10;
    public int Fuel_value = 10;
    public int Cristals_value = 10;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.GetComponent<controll>())
        {
            ResourceManagment.Totalcristals += Cristals_value;
            ResourceManagment.Totalmetal += Metal_value;
            Fuel.fuel += Fuel_value;
            Destroy(gameObject);
        }
            
    }
}
