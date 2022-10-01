using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenCT : MonoBehaviour
{
    private static screenCT instance = null;

    public static int day = 1;
    public static int Totalmoney = 25;
    public static int maxDay = 3;
    public static int maxCustomer = 5;
    public static int currentCustomer = 1;
    public static int earnedToday = 0;

    public static bool didIron = false;
    public static bool didFabric = false;
    public static bool didPlay = false;
    public static bool didTalk = false;
    public static bool isNextDay = false;
    public static bool canIron = true;
    public static bool NextCustomer = false;

    public static string score;



    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    private void Update()
    {

        if (currentCustomer>5)
        {
            currentCustomer = 0;
            day++;
            isNextDay = true;
        }
    }

 
   
    public static void nextCustomer()
    {
        currentCustomer++;
        didFabric = false;
        didIron = false;
        didPlay = false;
        didTalk = false;
        canIron = true;
        machineCT.rend.sprite = machineCT.normal;
        IronCt.rend.sprite = IronCt.normal;
        if (score == "good")
        {
            earnedToday += 15;
        }
        else if (score == "average")
        {
            earnedToday += 5;
        }
        else if (score == "bad")
        {
            earnedToday += -5;
        }
        int skor;
        skor = Random.Range(0, 2);
        switch (skor)
        {
            case 0:
                screenCT.score = "good";
                break;
            case 1:
                screenCT.score = "average";
                break;
            case 2:
                screenCT.score = "bad";
                break;
        }

    }



    public void close()
    {
        Application.Quit();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public static void RestartGame()
    {
        didIron = false;
        didFabric = false;
        didPlay = false;
        didTalk = false;
        isNextDay = false;
        canIron = true;
        earnedToday = 0;
        currentCustomer = 1;
        Totalmoney = 0;
        day = 1;


    }

}
