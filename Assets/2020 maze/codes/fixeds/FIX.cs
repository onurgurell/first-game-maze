using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIX : MonoBehaviour
{

    public Joystick Joystick;
    public FixedButton Button;
    public FixedTouchField TouchField;


    protected float CameraAngle;
    protected float CameraAngleSpeed = 0.2f;

    
    void Update()
    {
        

        CameraAngle += TouchField.TouchDist.x * CameraAngleSpeed;


        Camera.main.transform.position = transform.position + Quaternion.AngleAxis(CameraAngle, Vector3.up) * new Vector3(0f, 3f, -2.5f);
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up);


    }
}
