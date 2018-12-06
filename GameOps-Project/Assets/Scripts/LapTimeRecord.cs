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
    public GameObject LapCount;
    private int MaxLaps = 2;
    private int LapDone = 1;

    public  float ContinuesTime;

    public GameObject raceCompleted;

    void Update()
    {
        if(LapDone == MaxLaps)
        {
            raceCompleted.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other + " " + other + " " + other);
        if (other.gameObject.transform.parent.parent.gameObject.tag.Equals("Player"))
        {
            if(LapDone != MaxLaps) LapDone += 1;

            ContinuesTime = PlayerPrefs.GetFloat("ContinuesTime");
            if (LapTimeController.ContinuesTime <= ContinuesTime)
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
            }

            PlayerPrefs.SetInt("MinuteSave", LapTimeController.minutesPassed);
            PlayerPrefs.SetInt("SecondSave", LapTimeController.secondsPassed);
            PlayerPrefs.SetFloat("MilliSecSave", LapTimeController.millisecondsPassed);
            PlayerPrefs.SetFloat("ContinuesTime", LapTimeController.ContinuesTime);

            LapTimeController.minutesPassed = 0;
            LapTimeController.secondsPassed = 0;
            LapTimeController.millisecondsPassed = 0;
            LapTimeController.ContinuesTime = 0;
            LapCount.GetComponent<Text>().text = "" + LapDone;
            halfWayTrigger.SetActive(true);
            lapCompleteTrigger.SetActive(false);
        }
    }
}
