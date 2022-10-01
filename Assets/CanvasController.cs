using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public GameObject NextDayUI;
    public GameObject EndGameUI;
    public GameObject NeedleUI;
    public GameObject PauseMenuUI;
    public GameObject GamePrefab;
    public GameObject GamePrefab2;
    public GameObject GamePrefab3;


    public void Update()
    {
        if (screenCT.playing == true)
        {
            Play();
            screenCT.playing = false;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            PauseMenuUI.SetActive(true);
        }
        if (screenCT.isNextDay)
        {
            NextDay();
        }
    }
    public void NextDay()
    {

        NextDayUI.SetActive(true);
        screenCT.isNextDay = false;

    }
    public void Played()
    {
        screenCT.playing = true;


    }

    public void Play()
    {
        Instantiate(GamePrefab);
       
        
    }


    public void GoNextDay()
    {
        screenCT.Totalmoney += screenCT.earnedToday;
        NextDayUI.SetActive(false);
    }

    public void ExitGame()
    {

        Application.Quit();
    }

    public void GoMainMenu()
    {
        screenCT.RestartGame();
        SceneManager.LoadScene(0);
    }

    public void ResumeGame()
    {
        PauseMenuUI.SetActive(false);
    }




}
