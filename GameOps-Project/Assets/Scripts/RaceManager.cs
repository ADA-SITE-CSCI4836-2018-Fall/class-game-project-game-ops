﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceManager : MonoBehaviour {

    public GameObject positionDisplay;
    public Car[] allCars;
    public Car[] carOrder;

    public void Start()
    {
        // set up the car objects
        carOrder = new Car[allCars.Length];
        InvokeRepeating("ManualUpdate", 0.5f, 0.5f);
    }

    // this gets called every frame
    public void ManualUpdate()
    {
        foreach (Car car in allCars)
        {
            carOrder[car.GetCarPosition(allCars) - 1] = car;
        }

        for (int i = 0; i < allCars.Length; i++)
        {
            if (carOrder[i].gameObject.tag.Equals("Player"))
            {
                positionDisplay.GetComponent<Text>().text = (i + 1).ToString();
            }
        }
    }
}
