using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRotation : MonoBehaviour
{
    public GameObject turntable;
    public float turnSpeed;
    public bool canRotate = false;

    void Start()
    {
    }

    void Update()
    {
        StartTurntableRotation();

        StopTurntableRotation();
    }

    public void StartTurntableRotation()
    {
        if (Input.GetKey(KeyCode.W))
        {
            canRotate = true;
        }

        if (canRotate)
        {
            turntable.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
    }

    public void StopTurntableRotation()
    {
        if (Input.GetKey(KeyCode.S))
        {
            canRotate = false;
        }

        if (!canRotate)
        {
            turntable.transform.Rotate(0, 0, 0);
        }
    }
}
