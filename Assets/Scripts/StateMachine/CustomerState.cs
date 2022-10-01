using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerState : GameBaseState
{
    public static int currentCloth;
    public static Color currentColor;
    public static int colorRandom;
    public static int currentCustomer;
    public override void EnterState(GameStateManager game)
    {
        switch (currentCloth)
        {
            case 0:
                GameObject.FindGameObjectWithTag("CeketTamirli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("CeketTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 1:
                GameObject.FindGameObjectWithTag("KazakTamirli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("KazakTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 2:
                GameObject.FindGameObjectWithTag("PantolonTamirli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("PantolonTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 3:
                GameObject.FindGameObjectWithTag("HoodyTamirli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("HoodyTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 4:
                GameObject.FindGameObjectWithTag("TshirtTamirli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("TshirtTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 5:
                GameObject.FindGameObjectWithTag("CostumeTamirli").transform.position = new Vector3(20.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("CostumeTamirli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
        }
        currentCloth = Random.Range(0, 6);
        colorRandom = Random.Range(0,3);
        currentCustomer = Random.Range(0,4);

        switch (currentCustomer)
        {
            case 0:
                GameObject.FindGameObjectWithTag("Portrait0").transform.localPosition = new Vector3(0.75792f, -0.2670982f, 0.03200051f);
                break;
            case 1:
                GameObject.FindGameObjectWithTag("Portrait1").transform.localPosition = new Vector3(0.75792f, -0.2670982f, 0.03200051f);
                break;
            case 2:
                GameObject.FindGameObjectWithTag("Portrait2").transform.localPosition = new Vector3(0.75792f, -0.2670982f, 0.03200051f);
                break;
            case 3:
                GameObject.FindGameObjectWithTag("Portrait3").transform.localPosition = new Vector3(0.75792f, -0.2670982f, 0.03200051f);
                break;
            case 4:
                GameObject.FindGameObjectWithTag("Portrait4").transform.localPosition = new Vector3(0.75792f, -0.2670982f, 0.03200051f);
                break;
        }

        switch (colorRandom)
        {
            case 0:
                currentColor = Color.yellow;
                break;
            case 1:
                currentColor = Color.grey;
                break;
            case 2:
                currentColor = Color.red;
                break;
            case 3:
                currentColor = Color.green;
                break;


        }

        switch (currentCloth)
        {
            case 0:
                GameObject.FindGameObjectWithTag("CeketHasarli").transform.position=new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("CeketHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 1:
                GameObject.FindGameObjectWithTag("KazakHasarli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("KazakHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 2:
                GameObject.FindGameObjectWithTag("PantolonHasarli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("PantolonHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 3:
                GameObject.FindGameObjectWithTag("HoodyHasarli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("HoodyHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 4:
                GameObject.FindGameObjectWithTag("TshirtHasarli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("TshirtHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 5:
                GameObject.FindGameObjectWithTag("CostumeHasarli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("CostumeHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
        }

    }

    public override void OnCollisionEnter(GameStateManager game)
    {
        
    }

    public override void UpdateState(GameStateManager game)
    {

        if (screenCT.didTalk)
        {
            game.SwitchState(game.ironingState);
        }
        if (!screenCT.didTalk)
        {
            game.Dialogue.SetActive(true);
            screenCT.didTalk = true;
        }
    }
}
