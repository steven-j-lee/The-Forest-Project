using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControls : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private Animator animator;
    public float speed = 3f;
    public float smoothTurn = 90f;
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //determine direction
        transform.Rotate(0, Input.GetAxis("Horizontal")*smoothTurn*Time.deltaTime, 0);
        direction = transform.forward * Input.GetAxis("Vertical") * speed;
        //move at the desired direction
        controller.SimpleMove(direction * Time.deltaTime -  Vector3.up * 0.1f );
        //play moving rotation upon moving
        animator.SetFloat("Speed", direction.magnitude);
    }
}
