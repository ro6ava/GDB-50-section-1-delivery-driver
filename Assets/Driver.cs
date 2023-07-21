using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 90;
    [SerializeField] float forwardSpeed = 5;

    void Start()
    {

    }

    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float forwardAmount = Input.GetAxis("Vertical") * forwardSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, forwardAmount, 0);
    }
}
