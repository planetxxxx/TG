using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_controller : MonoBehaviour
{
    [SerializeField] GameObject StartGame;
    [SerializeField] GameObject EndGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startGame()
    {

        StartGame.SetActive(false);
        Time.timeScale = 1;

    }
    public void endGame()
    {
        GameStateManager.canNextCustomer = true;
        GameStateManager.didIron = false;

        Destroy(transform.parent.gameObject);
        EndGame.SetActive(false);
    }
}