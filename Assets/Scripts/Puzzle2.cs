using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    public List<GameObject> lightsInOrder; 
    private int currentIndex = 0;
    public float resetDelay = 1.0f;
    public GameObject WinButton;

    public AudioClip correctSound;
    public AudioClip wrongSound;

    private AudioSource audioSource;

    public Camera cameraToDeactivate;
    public Camera cameraToActivate;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void CheckClickedLight(GameObject clickedLight)
    {
        if (clickedLight == lightsInOrder[currentIndex])
        {
           
            currentIndex++;
            PlaySound(correctSound);

            if (currentIndex >= lightsInOrder.Count)
            {
                Debug.Log("Rätsel gelöst!");
                
                cameraToDeactivate.gameObject.SetActive(false);
                cameraToActivate.gameObject.SetActive(true);
                WinButton.SetActive(true);

            }
        }
        else
        {
            
            Debug.Log("Falsche Reihenfolge! Rätsel zurückgesetzt.");
            PlaySound(wrongSound); 
            StartCoroutine(ResetPuzzle());
        }
    }

    IEnumerator ResetPuzzle()
    {
        
        foreach (GameObject lightObj in lightsInOrder)
        {
            lightObj.SetActive(false);
        }

        yield return new WaitForSeconds(resetDelay);

        
        foreach (GameObject lightObj in lightsInOrder)
        {
            lightObj.SetActive(true);
        }

        currentIndex = 0; 
    }

    void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}