using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionStablize : MonoBehaviour {

    public GameObject car;
    public float carX;
    public float carY;
    public float carZ;

    void LateUpdate()
    {
        carX = car.transform.eulerAngles.x;
        carY = car.transform.eulerAngles.y;
        carZ = car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(0f, carY, 0f);

    }
}
