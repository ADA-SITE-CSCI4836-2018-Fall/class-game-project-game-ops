using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditFinish : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(FinishCredits());	
	}
	IEnumerator FinishCredits()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(0);
    }
	
}
