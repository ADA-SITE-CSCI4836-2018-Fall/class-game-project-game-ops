using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelectionRotate : MonoBehaviour {
    private float rotationAngle;
    private float angleX;
    private float angleZ;
	
    void Start ()
    {
        rotationAngle = this.transform.eulerAngles.y;
        angleX = this.transform.eulerAngles.x;
        angleZ = this.transform.eulerAngles.z;
    }

	void Update () {
        this.transform.eulerAngles = new Vector3(angleX, rotationAngle++, angleZ);
        if(rotationAngle > 360)
        {
            rotationAngle = rotationAngle % 360;
        }
	}
}
