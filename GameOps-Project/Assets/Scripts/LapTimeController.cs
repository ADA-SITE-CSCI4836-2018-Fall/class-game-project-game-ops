using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeController : MonoBehaviour {
    public static int minutesPassed;
    public static int secondsPassed;
    public static float millisecondsPassed;
    public static string millisecondsInStrind;

    public GameObject minuteText;
    public GameObject secondText;
    public GameObject milliseondsText;

    public static float ContinuesTime;//time to perform each task in an operation like rawtime

    void Update()
    {
        millisecondsPassed += Time.deltaTime * 10;
        ContinuesTime += Time.deltaTime;
        millisecondsInStrind = millisecondsPassed.ToString("F0");
        milliseondsText.GetComponent<Text>().text = "" + millisecondsInStrind;

        if (millisecondsPassed >= 10)
        {
            millisecondsPassed = 0;
            secondsPassed += 1;
        }

        if (secondsPassed <= 9)
        {
            secondText.GetComponent<Text>().text = "0" + secondsPassed + ".";
        }
        else
        {
            secondText.GetComponent<Text>().text = "" + secondsPassed + ".";
        }

        if (secondsPassed >= 60)
        {
            secondsPassed = 0;
            minutesPassed += 1;
        }

        if (minutesPassed <= 9)
        {
            minuteText.GetComponent<Text>().text = "0" + minutesPassed + ":";
        }
        else
        {
            minuteText.GetComponent<Text>().text = "" + minutesPassed + ":";
        }

    }
}
