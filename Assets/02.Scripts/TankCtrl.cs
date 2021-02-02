using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCtrl : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float turnSpeed = 100.0f;

    private Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();        
    }

    void Update()
    {
        float v = Input.GetAxis("Vertical");   // Up, Down Arrow , W, S [-1.0f ~ 0.0f ~ 1.0f]
        float h = Input.GetAxis("Horizontal"); // Left, Right Arrow, A, D [-1.0f ~ 0.0f ~ 1.0f]

        tr.Translate(Vector3.forward * Time.deltaTime * moveSpeed * v);
        tr.Rotate(Vector3.up * Time.deltaTime * turnSpeed * h);        
    }
}
