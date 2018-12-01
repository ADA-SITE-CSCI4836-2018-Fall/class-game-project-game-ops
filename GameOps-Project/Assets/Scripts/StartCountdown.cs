using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountdown : MonoBehaviour {

    public GameObject countDown;
    public AudioSource getReadyAudio;
    public AudioSource goAudio;
    public GameObject lapTimer;
    public GameObject carControls;
    public AudioSource LevelMusic;

    void Start()
    {
        StartCoroutine(CountStart());
    }


    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        countDown.GetComponent<Text>().text = "3";
        getReadyAudio.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "2";
        getReadyAudio.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "1";
        getReadyAudio.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        goAudio.Play();
        LevelMusic.Play();
        lapTimer.SetActive(true);
        carControls.SetActive(true);
    }
}
