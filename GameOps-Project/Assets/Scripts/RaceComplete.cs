using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceComplete : MonoBehaviour {

    public static GameObject MyCar;
    public static GameObject FinishCamera;
    public static GameObject ViewModes;
    public static GameObject LevelMusic;
    public GameObject CompleteTrigger;
    public static AudioSource FinishMusic;
    public GameObject lapTimeController;
    public GameObject EndScreen;

    void OnDestroy()
    {
        MyCar = null;
        FinishCamera = null;
        ViewModes = null;
        LevelMusic = null;
        FinishMusic = null;
    }

    void OnTriggerEnter(Collider other)
    {
        if (ModeTime.isTimeMode == true)
        {
            //we are on race Time mode
        }
        else if(other.gameObject.transform.parent.parent.gameObject.tag.Equals("Player"))
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
