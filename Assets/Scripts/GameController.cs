using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject timeIsUp, youWin, controlText, restartButton, quitButton, startButton;

    AudioSource audioSource;
    //private AudioClip winSound;
    //private AudioClip loseSound;
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeLeft.timeLeft <= 0)
        {
            //audioSource.PlayOneShot(loseSound);
            //loseSound.Play();
            Time.timeScale = 0;
            timeIsUp.gameObject.SetActive (true);
            restartButton.gameObject.SetActive (true);
        }

        if (ItemCollector.currentApple == 5)
        {
            //audioSource.PlayOneShot(winSound);
            //Debug.Log("I Have 5 Apples");
            //winSound.Play();
            Time.timeScale = 0;
            youWin.gameObject.SetActive (true);
            quitButton.gameObject.SetActive (true);
        }
    }

    public void startScene()
    {
        Time.timeScale = 1;
        controlText.gameObject.SetActive (false);
        startButton.gameObject.SetActive (false);
    }

    public void restartScene()
    {
        timeIsUp.gameObject.SetActive (false);
        restartButton.gameObject.SetActive (false);
        Time.timeScale = 1;
        TimeLeft.timeLeft = 10f;
        SceneManager.LoadScene ("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
        // Debug.Log("I quit the game");
    }
}
