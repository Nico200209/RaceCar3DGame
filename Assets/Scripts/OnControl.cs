using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class OnControl : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject DreamCar01;
    // Start is called before the first frame update
    void Start()
    {
        CarControl.GetComponent<BetterControl>().enabled = true;
        DreamCar01.GetComponent<CarAIControl>().enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
