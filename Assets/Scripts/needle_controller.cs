using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class needle_controller : MonoBehaviour
{
    Animator myAnimator;
    [SerializeField] float score = 0, badQua = 958, aveQua = 1916;
    public bool incScore, decScore;
    public string qua;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("needlekey"))
        {
            myAnimator.GetComponent<Animator>().enabled = true;
            if (incScore)
            {
                score++;
            }
            else if (decScore)
            {
                score--;
            }
        }
        else
        {
            myAnimator.GetComponent<Animator>().enabled = false;
        }

        if (GameStateManager.canIron && !GameStateManager.RightNeedle)
        {
            qua = "bad";
        }
        else if (!GameStateManager.canIron && !GameStateManager.RightNeedle)
        {
            if (score <= badQua)
            {
                qua = "bad";
                GameStateManager.score = qua;
            }
            else
            {
                qua = "ave";
                GameStateManager.score = qua;
            }
        }
        else if (GameStateManager.canIron && GameStateManager.RightNeedle)
        {
            if (score <= badQua)
            {
                qua = "bad";
                GameStateManager.score = qua;
            }
            else
            {
                qua = "ave";
                GameStateManager.score = qua;
            }
        }
        else if (!GameStateManager.canIron && GameStateManager.RightNeedle)
        {
            if (score <= badQua)
            {
                qua = "bad";
                GameStateManager.score = qua;
            }
            else if (score > badQua && score <= aveQua)
            {
                qua = "ave";
                GameStateManager.score = qua;
            }
            else
            {
                qua = "good";
                GameStateManager.score = qua;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        incScore = false;
        decScore = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        incScore = true;
        decScore = false;
    }
}