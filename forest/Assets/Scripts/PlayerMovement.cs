using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private Animator animator;
    public float speed = 3f;
    public float turnSmoothness = 2f;


    private void Awake()
    {


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get input from keyboard
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");


        //check for y-axis constraint and normalize vector to prevent speed increase
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        //set quaternion for player
        //Quaternion orientation = Quaternion.LookRotation(direction);

        if(direction.magnitude >= 0.1f)
        {

            controller.SimpleMove(direction * speed * Time.deltaTime);
            Quaternion orientation = Quaternion.LookRotation(direction);
            transform.rotation = orientation;

            //perform rotation
        }
        //set speed for animator to decide inbetween states
        animator.SetFloat("Speed", direction.magnitude);
    }
}
