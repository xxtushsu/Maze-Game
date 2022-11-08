using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float timeRemaining = 30f;
    public TMP_Text timeText;
    public GameObject gameOverScreen;
    
    //public GameObject player;
    public GameObject player;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);

        }
        else
        {
            Debug.Log("Time has run out!");
            timeRemaining = 0;
            StartCoroutine(DisplayGameOver());
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    IEnumerator DisplayGameOver()
    {
        yield return new WaitForSeconds(0.1f);
        gameOverScreen.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SetTime(float time)
    {
        timeRemaining = time;
    }

    public float SetTime()
    {
        return timeRemaining;
    }
}