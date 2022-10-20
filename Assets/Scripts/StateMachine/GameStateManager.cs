using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    private static GameStateManager instance = null;

    //UI
    public GameObject StartMiniGame;
    public GameObject NextDayUI;
    public GameObject EndGameUI;
    public GameObject NeedleUI;
    public GameObject PauseMenuUI;
    public GameObject GamePrefab;
    public GameObject GamePrefab2;
    public GameObject GamePrefab3;
    public GameObject Dialogue;
    public GameObject MainGame;




    //Variables
    public static int day = 1;
    public static int Totalmoney = 25;
    public static int maxDay = 3;
    public static int maxCustomer = 5;
    public static int currentCustomer = 1;
    public static int earnedToday = 0;
    public static int minigameRandom;

    public static bool didFabric = false;
    public static bool canNextCustomer = false;
    public static bool didTalk = false;
    public static bool isNextDay = false;
    public static bool canIron = true;
    public static bool NextCustomer = false;
    public static bool playing = false;
    public static bool RightNeedle;
    public static bool didIron = false;
    public static bool DidPlayButton;

    public static string score;



    
    //StateMachine

    public GameBaseState currentState;
    public PlayState playingState = new PlayState();
    public IronState ironingState = new IronState();
    public CustomerState customeringState = new CustomerState();

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
    void Start()
    {
        
        currentState = customeringState;

        currentState.EnterState(this);
    }


    void Update()
    {


        currentState.UpdateState(this);

       
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            PauseMenuUI.SetActive(true);
        }
      
    }
    public void SwitchState(GameBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    //Game FUNCTIONS
    public void CreateMiniGame()
    {
       minigameRandom = Random.Range(0, 2); 
       switch (minigameRandom)
        {
            case 0:
                Instantiate(GamePrefab);
                break;
            case 1:
                Instantiate(GamePrefab2);
                break;
            case 2:
                Instantiate(GamePrefab3);
                break;

        }
    }


    //UI FUNCTIONS

    public static void RestartGame()
    {
        didFabric = false;
        canNextCustomer = false;
        didTalk = false;
        isNextDay = false;
        canIron = true;
        earnedToday = 0;
        currentCustomer = 1;
        Totalmoney = 0;
        day = 1;
    }

    public void GoNextDay()
    {       
        NextDayUI.SetActive(false);
    }

    public void ResumeGame()
    {
        PauseMenuUI.SetActive(false);
    }

    public void GoMainMenu()
    {
        RestartGame();
        SceneManager.LoadScene(0);
    }


    public void ExitGame()
    {

        Application.Quit();
    }

    public void MiniGameButton()
    {
        DidPlayButton = true;
        StartMiniGame.SetActive(false);
        
    }
    


    
}
