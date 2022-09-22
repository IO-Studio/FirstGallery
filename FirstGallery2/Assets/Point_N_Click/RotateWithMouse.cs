using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{

    public float Speed = 5.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            rotationY += Speed = Input.GetAxis("Mouse X");
            rotationX -= Speed = Input.GetAxis("Mouse Y");

            rotationX = Mathf.Clamp(rotationX, -20f, 20f);

            transform.eulerAngles = new Vector3(rotationX, rotationY, 0);

            //transform.Rotate(transform.up ,-Input.GetAxis("Mouse X") * Speed  ); //1
        }
    }
}