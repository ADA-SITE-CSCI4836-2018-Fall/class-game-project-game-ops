using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceComplete : MonoBehaviour {

    public GameObject car;
    public GameObject finishCamera;
    public GameObject viewModes;
    public GameObject levelMusic;
    public GameObject completeTrigger;
    public AudioSource finishMusic;
    public GameObject lapTimeController;

    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        car.SetActive(false);
        completeTrigger.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        car.GetComponent<CarController>().enabled = false;
        car.GetComponent<CarUserControl>().enabled = false;
        car.SetActive(true);
        lapTimeController.SetActive(false);
        finishCamera.SetActive(true);
        levelMusic.SetActive(false);
        viewModes.SetActive(false);
        finishMusic.Play();
    }
}
