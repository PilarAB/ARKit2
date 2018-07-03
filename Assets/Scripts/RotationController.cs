using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour {

    //rotation speed
    public float rotationSpeed = 10;

	void Update () {
        //angle of rotation
        float angleRot = rotationSpeed * Time.deltaTime;

        //rotate
        transform.Rotate(Vector3.up * angleRot, Space.World);
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

	}
}
