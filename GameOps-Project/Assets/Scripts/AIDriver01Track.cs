using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDriver01Track : MonoBehaviour {

    public GameObject theMarker;
    public List<GameObject> marks;

    public int markTracker;

    void Update()
    {
        theMarker.transform.position = marks[markTracker].transform.position;
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "AIDriver01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            markTracker += 1;
            if (markTracker == 17)
            {
                markTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
