using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCars : MonoBehaviour {
    public GameObject TrackWindow;
    public static int CarType; // 1 = Red, 2 = Blue
        public void RedCar()      //red car
    {
        CarType = 1;
        TrackWindow.SetActive(true);
    }

    public void BlueCar()      // orange Car second one
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    }

    public void GreenCar()      // orange Car second one
    {
        CarType = 3;
        TrackWindow.SetActive(true);
    }

}
