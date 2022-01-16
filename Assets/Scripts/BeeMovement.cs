using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor;

public class BeeMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float floatingSpeed = 3f;
    public Rigidbody rb;
    public Collider coll;
    
    private CharacterController controller;
    private bool isOnGround;
    
    //private float jumpHeight = 1.0f;
    //private float gravityValue = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        var vert = Input.GetAxisRaw("Vertical");
        controller.Move(transform.forward * vert * playerSpeed * Time.deltaTime*(-1f));
        var hori = Input.GetAxisRaw("Mouse X");
        transform.Rotate(Vector3.up*hori*360f*Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(transform.up * floatingSpeed * Time.deltaTime);
        }
    }
}
