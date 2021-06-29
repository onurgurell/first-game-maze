using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{
    public Transform[] Noktalar;
    public int sayi;
    public float hiz;

    void Start()
    {
        transform.position = Noktalar[0].position;
        sayi = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == Noktalar[sayi].position)
        {
            sayi++;
        }
        if (sayi >= Noktalar.Length)
        {
            sayi = 0;
        }

        transform.position = Vector3.MoveTowards (transform.position, Noktalar[sayi].position, hiz * Time.deltaTime);


        transform.LookAt(Noktalar[sayi]);
    } 


   
}
