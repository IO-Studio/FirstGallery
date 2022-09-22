using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitXRotationScript : MonoBehaviour
{
    public float Ysensitivity;
    private float rotationY = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            rotationY += Input.GetAxis("Mouse Y") * Ysensitivity;


            rotationY = Mathf.Clamp(rotationY, -25, 25);
            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, transform.localEulerAngles.z);
        }
    }
}
