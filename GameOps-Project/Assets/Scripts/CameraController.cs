using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	
    public Transform car;
    public Vector3 cameraOffset;
    public float cameraFollowSpeed = 10;
    public float cameraLookSpeed = 10;

    void Start()
    {
        cameraOffset = transform.position - car.position;
    }

    public void LookAtTarget()
    {
        Vector3 _lookDirection = car.position - transform.position;
        Quaternion _rot = Quaternion.LookRotation(_lookDirection, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, _rot, cameraLookSpeed * Time.deltaTime);
    }

    public void MoveToTarget()
    {
        Vector3 _targetPos = car.position +
                             car.forward * cameraOffset.z +
                             car.right * cameraOffset.x +
                             car.up * cameraOffset.y;
        transform.position = Vector3.Lerp(transform.position, _targetPos, cameraFollowSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        LookAtTarget();
        MoveToTarget();
    }

}
