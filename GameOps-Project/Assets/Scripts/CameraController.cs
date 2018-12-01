using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject car;
    public float carX;
    public float carY;
    public float carZ;

    void LateUpdate()
    {
        carX = car.transform.eulerAngles.x;
        carY = car.transform.eulerAngles.y;
        carZ = car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(carX - carX, carY, carZ - carZ);

    }
}
