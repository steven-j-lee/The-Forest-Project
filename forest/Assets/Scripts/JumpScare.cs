using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    [SerializeField] private GameObject soundTriggerToDelete;
    [SerializeField] private GameObject demon;
    private AudioSource sound;
    [SerializeField] private AudioClip audioFile;


    private bool hasPlayed = false;

    private void Awake()
    {
        demon.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        sound = soundTriggerToDelete.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            demon.SetActive(true);
            PlaySound();
            StartCoroutine(Delay());
        }
    }

    private void PlaySound()
    {
        if (!hasPlayed)
        {
            sound.PlayOneShot(audioFile, 2f);
            hasPlayed = true;
        }
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        Destroy(demon);
        gameObject.SetActive(false);
        soundTriggerToDelete.SetActive(false);
    }
}
