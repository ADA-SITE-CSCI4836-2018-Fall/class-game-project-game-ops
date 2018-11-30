using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfWayTrigger : MonoBehaviour {

    public GameObject halfWayTrigger;
    public GameObject lapCompleteTrigger;

	void OnTriggerEnter()
    {
        halfWayTrigger.SetActive(false);
        lapCompleteTrigger.SetActive(true);
    }
}
