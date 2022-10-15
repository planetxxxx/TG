using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayState : GameBaseState
{
    public Color currentColor;
    public int currentCloth;
    public override void EnterState(GameStateManager game)
    {
        machineCT.rend.sprite = machineCT.normal;
        IronCt.rend.sprite = IronCt.normal;
        GameStateManager.DidPlayButton = false;
        GameStateManager.canIron = true;
        GameStateManager.didFabric = false;
        GameStateManager.DidPlayButton = false;
        currentColor = CustomerState.currentColor;
        currentCloth = CustomerState.currentCloth;
        
        
        switch (currentCloth)
        {
            case 0:
                GameObject.FindGameObjectWithTag("CeketHasarli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("CeketHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 1:
                GameObject.FindGameObjectWithTag("KazakHasarli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("KazakHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 2:
                GameObject.FindGameObjectWithTag("PantolonHasarli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("PantolonHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 3:
                GameObject.FindGameObjectWithTag("HoodyHasarli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("HoodyHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 4:
                GameObject.FindGameObjectWithTag("TshirtHasarli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("TshirtHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 5:
                GameObject.FindGameObjectWithTag("CostumeHasarli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("CostumeHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
        }
        switch (currentCloth)
        {
            case 0:
                GameObject.FindGameObjectWithTag("CeketTamirli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("CeketTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 1:
                GameObject.FindGameObjectWithTag("KazakTamirli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("KazakTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 2:
                GameObject.FindGameObjectWithTag("PantolonTamirli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("PantolonTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 3:
                GameObject.FindGameObjectWithTag("HoodyTamirli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("HoodyTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 4:
                GameObject.FindGameObjectWithTag("TshirtTamirli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("TshirtTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 5:
                GameObject.FindGameObjectWithTag("CostumeTamirli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("CostumeTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
        }


        game.StartMiniGame.SetActive(false);
        game.MainGame.SetActive(false);
        game.CreateMiniGame();

        

    }

    public override void OnCollisionEnter(GameStateManager game)
    {
        
    }

    public override void UpdateState(GameStateManager game)
    {
        if (GameStateManager.currentCustomer == 5)
        {
            GameStateManager.Totalmoney += GameStateManager.earnedToday;
            GameStateManager.day++;
            GameStateManager.currentCustomer = 0;
            GameStateManager.earnedToday = 0;
            game.NextDayUI.SetActive(true);

        }
        else
        {
            
            if (GameStateManager.canNextCustomer)
            {
                if (GameStateManager.score == "good")
                {
                    GameStateManager.earnedToday += 15;
                }
                else if (GameStateManager.score == "ave")
                {
                    GameStateManager.earnedToday += 5;
                }
                else if (GameStateManager.score == "bad")
                {
                    GameStateManager.earnedToday += -5;
                }
                GameStateManager.currentCustomer++;
                GameStateManager.canNextCustomer = false;
                game.MainGame.SetActive(true);
                game.SwitchState(game.customeringState);

            }
        }
        
      
       
    }
}
