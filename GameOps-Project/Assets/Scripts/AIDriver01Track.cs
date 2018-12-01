using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDriver01Track : MonoBehaviour {

    public GameObject theMarker;
    public List<GameObject> marks;
    public GameObject mark01;
    public GameObject mark02;
    public GameObject mark03;
    public GameObject mark04;
    public GameObject mark05;
    public GameObject mark06;
    public GameObject mark07;
    public GameObject mark08;
    public GameObject mark09;
    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;
    public GameObject mark13;
    public GameObject mark14;
    public GameObject mark15;
    public GameObject mark16;
    public GameObject mark17;

    public int markTracker;

    void Update()
    {
        /*
        if (markTracker == 0)
        {
            theMarker.transform.position = mark01.transform.position;
        }
        if (markTracker == 1)
        {
            theMarker.transform.position = mark02.transform.position;
        }
        if (markTracker == 2)
        {
            theMarker.transform.position = mark03.transform.position;
        }
        if (markTracker == 3)
        {
            theMarker.transform.position = mark04.transform.position;
        }
        if (markTracker == 4)
        {
            theMarker.transform.position = mark05.transform.position;
        }
        if (markTracker == 5)
        {
            theMarker.transform.position = mark06.transform.position;
        }
        */
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
