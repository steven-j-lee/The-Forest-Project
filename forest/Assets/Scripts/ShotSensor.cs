using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSensor : MonoBehaviour
{
    [SerializeField] GameObject targetCam;
    [SerializeField] CameraManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.cancelAllCams();
            targetCam.SetActive(true);
        }
    }
}
