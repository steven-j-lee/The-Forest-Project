using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> cameras;
    [SerializeField] GameObject main;

    // Start is called before the first frame update
    void Start()
    {
        cameras.ForEach(delegate(GameObject cameras){
            if (cameras != main)
            {
                cameras.SetActive(false);
            }
        });
    }   

    // Update is called once per frame
    void Update()
    {
       
    }

    public void cancelAllCams()
    {
        cameras.ForEach(delegate (GameObject cameras) {
            cameras.SetActive(false);

        });
    }
}
