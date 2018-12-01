using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    public class CarControls : MonoBehaviour
    {
        public CarController car; // reference to the car controller, must be dragged in inspector
        
        private void Start()
        {
            car.enabled = true;
        }
    }
}
