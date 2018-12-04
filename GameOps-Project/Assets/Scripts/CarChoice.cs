using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {
    public GameObject RedBody;
    public GameObject BlueBody;
    public GameObject GreenBody;
    public int CarImport;

    // Use this for initialization
    void Start () {
        CarImport = GlobalCars.CarType;
        if(CarImport == 1)
        {
            RedBody.SetActive(true);

        }
        if (CarImport == 2)
        {
            BlueBody.SetActive(true);

        }
        if (CarImport == 3)
        {
            GreenBody.SetActive(true);

        }
    }

    
}
