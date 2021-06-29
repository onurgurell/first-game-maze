using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_cont : MonoBehaviour
{
    public Joystick fixedJoystick;

    public Transform cam;


    private float limitX;
    private float limitY;
    public float sensivity;


    private float xRot, yRot;



    void Update()
    {

        limitX = fixedJoystick.Horizontal * sensivity;
        limitY = fixedJoystick.Vertical * sensivity;


        xRot = Mathf.Clamp(limitY, -180, 90);
        yRot = Mathf.Clamp(limitX, -180, 90);


        cam.localRotation = Quaternion.Euler(xRot, yRot, 0);

    }

}
