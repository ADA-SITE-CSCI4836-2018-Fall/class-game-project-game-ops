using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeRecord : MonoBehaviour {
    public GameObject halfWayTrigger;
    public GameObject lapCompleteTrigger;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    void OnTriggerEnter()
    {

        if (LapTimeController.secondsPassed <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeController.secondsPassed + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeController.secondsPassed + ".";
        }

        if (LapTimeController.minutesPassed <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeController.minutesPassed + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeController.minutesPassed + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeController.millisecondsPassed.ToString("F0");
    

    PlayerPrefs.SetInt("MinuteSave", LapTimeController.minutesPassed);
        PlayerPrefs.SetInt("SecondSave", LapTimeController.secondsPassed);
        PlayerPrefs.SetFloat("MilliSecSave", LapTimeController.millisecondsPassed);

        LapTimeController.minutesPassed = 0;
        LapTimeController.secondsPassed = 0;
        LapTimeController.millisecondsPassed = 0;

        halfWayTrigger.SetActive(true);
        lapCompleteTrigger.SetActive(false);
    }
}
