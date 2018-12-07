using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    public class CarControls : MonoBehaviour
    {
        //public CarController car; // reference to the car controller, must be dragged in inspector
        //public CarAIControl AIDriver01;
        private GameObject[] aiDrivers;
        GameObject player;

        private void Start()
        {
            aiDrivers = GameObject.FindGameObjectsWithTag("AIDriver01");
            player = GameObject.FindGameObjectWithTag("Player");
            Debug.Log("PLAYER CAR NAME!!!!!!: " + player.name);
            foreach(GameObject obj in aiDrivers)
            {
                obj.GetComponent<CarAIControl>().enabled = true;
            }
            player.GetComponent<CarController>().enabled = true;
        }
    }
}
