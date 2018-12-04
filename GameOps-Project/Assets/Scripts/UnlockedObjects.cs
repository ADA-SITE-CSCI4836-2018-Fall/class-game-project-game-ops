using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObjects : MonoBehaviour {

    public int greenSelect;
    public GameObject Fake;

	// Use this for initialization
	void Start () {
        greenSelect = PlayerPrefs.GetInt("GreenBought");
        if(greenSelect == 100)
        {
            Fake.SetActive(false);

        }
		
	}
	

}
