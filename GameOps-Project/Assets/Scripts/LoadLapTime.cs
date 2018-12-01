using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour {

    public int Minpassed;
    public int Secpassed;
    public float Millipassed;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    // Use this for initialization
    void Start () {

        Minpassed = PlayerPrefs.GetInt("MinuteSave");
        Secpassed = PlayerPrefs.GetInt("SecondSave");
        Millipassed = PlayerPrefs.GetFloat("MilliSecSave");

        MinuteDisplay.GetComponent<Text>().text = "" + Minpassed +":";
        SecondDisplay.GetComponent<Text>().text = "" + Secpassed +".";
        MilliDisplay.GetComponent<Text>().text = "" + Millipassed;
    }


}
