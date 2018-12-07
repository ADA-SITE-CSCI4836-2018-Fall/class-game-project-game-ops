using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplySelectedCar : MonoBehaviour {

    private string selectedCar = "";


    void Start()
    {
        selectedCar = CarSelection.selectedCar;
    }
}
