using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayState : GameBaseState
{
    public Color currentColor;
    public int currentCloth;
    public override void EnterState(GameStateManager game)
    {
        currentColor = CustomerState.currentColor;
        currentCloth = CustomerState.currentCloth;
        game.Dialogue.SetActive(false);

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

    }

    public override void OnCollisionEnter(GameStateManager game)
    {
        
    }

    public override void UpdateState(GameStateManager game)
    {
      
        if (screenCT.didPlay)
        {
            screenCT.nextCustomer();
            game.SwitchState(game.customeringState);
           
        }
    }
}
