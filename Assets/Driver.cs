using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = .3f;
    [SerializeField] float moveSpeed = 30f;
    [SerializeField] float slowSpeed = 20f;
    [SerializeField] float boostSpeed = 45f;
    [SerializeField] float slowDownSpeed = 10f;


    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
        Debug.Log("Maybe I should retake Drivers Ed...?");
    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            Debug.Log("Lets hit it into overdrive!  We got rent to make!");
        }
        if (other.tag == "SlowDown")
        {
            moveSpeed = slowDownSpeed;
            Debug.Log("...Why is my car going so slow... Did i break it when I hit that house last delivery?");
        }
    }
}
