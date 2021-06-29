using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public FixedJoystick variableJoystick;
    public Rigidbody rb;

    

    public float jumpSpeed;
    public AudioSource voicerrr;

    public GameObject gameover;

   
    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);

        

    }


    void OnCollisionEnter(Collision nesne)
    {
        if (nesne.gameObject.tag == "dusman")
        {
            gameover.SetActive(true);
            Time.timeScale = 0;
            voicerrr.Pause();
            Invoke("gameover", 5f);
            Destroy(nesne.gameObject);

        }
    }


    public void jumping()
    {
        if (rb.velocity.y == 0)
        {
            rb.velocity = Vector3.up * jumpSpeed;
        }
    }



}