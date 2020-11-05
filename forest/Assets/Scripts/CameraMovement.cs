using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    public Vector3 offset;
    public float speed = 5f;
    private Transform CameraPos;

    // Start is called before the first frame update
    void Start()
    {
        CameraPos = gameObject.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CameraPos.position = new Vector3(player.transform.position.x - offset.x, CameraPos.position.y, player.transform.position.z-offset.z);

        
    }
}
