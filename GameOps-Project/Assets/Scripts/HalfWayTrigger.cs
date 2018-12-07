using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfWayTrigger : MonoBehaviour {

    public GameObject halfWayTrigger;
    public GameObject lapCompleteTrigger;

	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.parent.parent.gameObject.tag.Equals("Player")) {
            halfWayTrigger.SetActive(false);
            lapCompleteTrigger.SetActive(true);
        }
    }
}
