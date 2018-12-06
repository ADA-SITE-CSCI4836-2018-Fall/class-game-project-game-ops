using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceComplete : MonoBehaviour {

    public GameObject MyCar;
    public GameObject FinishCamera;
    public GameObject ViewModes;
    public GameObject LevelMusic;
    public GameObject CompleteTrigger;
    public AudioSource FinishMusic;
    public GameObject lapTimeController;
    public GameObject EndScreen;

    void OnTriggerEnter()
    {
        if (ModeTime.isTimeMode == true)
        {
            //we are on race Time mode
        }
        else
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MyCar.SetActive(false);
            CompleteTrigger.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            MyCar.GetComponent<CarController>().enabled = false;
            MyCar.GetComponent<CarUserControl>().enabled = false;
            MyCar.SetActive(true);
            lapTimeController.SetActive(false);
            FinishCamera.SetActive(true);
            LevelMusic.SetActive(false);
            ViewModes.SetActive(false);
            FinishMusic.Play();
            GlobalCash.TotalCash += 100;
            PlayerPrefs.SetInt("SavedCash",GlobalCash.TotalCash);
            EndScreen.SetActive(true);
        }
    }
}
