using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LichtStaturen : MonoBehaviour
{
    private int currentIndex = 0;
    public GameObject WinningScreen;
    private int winningIndex = 4;

    public AudioClip correctSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LilaObject") && gameObject.CompareTag("LilaBeam"))
        {
            currentIndex++;
            CheckWinCondition();
            Debug.Log("lila getroffen");
            PlaySound(correctSound);
        }

        if (other.CompareTag("BlueObject") && gameObject.CompareTag("BlueBeam"))
        {
            currentIndex++;
            CheckWinCondition();
            Debug.Log("blue getroffen");
            PlaySound(correctSound);
        }

        if (other.CompareTag("RedObject") && gameObject.CompareTag("RedBeam"))
        {
            currentIndex++;
            CheckWinCondition();
            Debug.Log("red getroffen");
            PlaySound(correctSound);
        }

        if (other.CompareTag("GreenObject") && gameObject.CompareTag("GreenBeam"))
        {
            currentIndex++;
            CheckWinCondition();
            Debug.Log("green getroffen");
            PlaySound(correctSound);
        }
    }

    private void CheckWinCondition()
    {
        Debug.Log("Checking Win Condition...");
       
        if (currentIndex>= winningIndex)
        {
            Debug.Log("Winning Condition Met!");
            WinningScreen.SetActive(true);
        }
    }

    private void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
